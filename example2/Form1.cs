﻿//
//  Created by Giannis Giorgoulakis on 7/7/13.
//  Copyright (c) 2013 SoftOne Technologies. All rights reserved.
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace example2
{
	public partial class Form1 : Form
	{
		static string loginID = "";
		static string clientID = "";

		public Form1()
		{
			InitializeComponent();
		}

		private string executeRequest(string postData)
		{
			HttpWebRequest request = HttpWebRequest.Create($"http://{tbSerialNumberOrRegisteredName.Text}.oncloud.gr/s1services") as HttpWebRequest;

			request.Method = "POST";
			// Create POST data and convert it to a byte array.
			byte[] byteArray = Encoding.UTF8.GetBytes(postData);
			// Set the ContentType property of the WebRequest.
			//request.ContentType = "application/json";
			request.ContentType = "application/x-www-form-urlencoded";
			request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
			// Set the ContentLength property of the WebRequest.
			request.ContentLength = byteArray.Length;

			//
			// Get the request stream.
			Stream dataStream = request.GetRequestStream();
			// Write the data to the request stream.
			dataStream.Write(byteArray, 0, byteArray.Length);
			// Close the Stream object.
			dataStream.Close();
			// Get the response.

			//-------------------------------------------------------------------
			string responseFromServer = "";
			Encoding Soft1Encoding = Encoding.GetEncoding(1253);

			using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
			{
				using (Stream responseStream = response.GetResponseStream())
				{
					using (StreamReader reader = new StreamReader(responseStream, Soft1Encoding))
					{
						responseFromServer = reader.ReadToEnd();
					}
				}
			}
			return responseFromServer;
		}

		private string Login(string username, string password, string appId)
		{
			string loginStr = "\"service\": \"login\",  \"username\": \"{0}\",  \"password\":\"{1}\",  \"appId\": \"{2}\"";
			string rs = executeRequest("{" + string.Format(loginStr, username, password, appId) + "}");

			Newtonsoft.Json.Linq.JObject jo = Newtonsoft.Json.Linq.JObject.Parse(rs);
			Boolean success = Convert.ToBoolean(jo["success"].ToString());
			if (success)
			{
				foreach (var item in jo["objs"].Children())
				{
					tbCompany.Text = item["COMPANY"].ToString();
					tbBranch.Text = item["BRANCH"].ToString();
					tbModule.Text = item["MODULE"].ToString();
					tbRefID.Text = item["REFID"].ToString();
				}
				return jo["clientID"].ToString();
			}
			else
			{
				tbCompany.Text = "";
				tbBranch.Text = "";
				tbModule.Text = "";
				tbRefID.Text = "";
				MessageBox.Show(jo["error"].ToString());
				return "";
			}
		}

		/// <summary>
		/// Access to the application with selected login data. Returns the code (clientID), needed for all subsequent calls.
		/// </summary>
		/// <param name="theClientId"></param>
		/// <returns></returns>
		private string authenticate(string theClientId)
		{
			string rs = "";
			string authStr = "";
			if (tbUserID.Text != "")
			{
				authStr = "\"service\": \"authenticate\",\"clientID\": \"{0}\", \"COMPANY\": \"{1}\", \"BRANCH\": \"{2}\", \"MODULE\": \"{3}\", \"REFID\": \"{4}\", \"USERID\": \"{5}\"";
				rs = executeRequest("{" + string.Format(authStr, theClientId, tbCompany.Text, tbBranch.Text, tbModule.Text, tbRefID.Text, tbUserID.Text) + "}");
			}
			else
			{
				authStr = "\"service\": \"authenticate\",\"clientID\": \"{0}\", \"COMPANY\": \"{1}\", \"BRANCH\": \"{2}\", \"MODULE\": \"{3}\", \"REFID\": \"{4}\"";
				rs = executeRequest("{" + string.Format(authStr, theClientId, tbCompany.Text, tbBranch.Text, tbModule.Text, tbRefID.Text) + "}");
			}

			Newtonsoft.Json.Linq.JObject jo = Newtonsoft.Json.Linq.JObject.Parse(rs);
			Boolean success = Convert.ToBoolean(jo["success"].ToString());
			if (success)
			{
				return jo["clientID"].ToString();
			}
			else
			{
				MessageBox.Show(jo["error"].ToString());
				return "";
			}
		}



		private string postNewSalDoc(string seriesId, string trdrId, string itemId)
		{
			string postStr = "{\"OBJECT\": \"saldoc\",\"SERVICE\": \"setData\",\"clientID\": \"" + clientID +
					"\",\"appId\": \""+ tbAppID.Text + "\",\"KEY\": \"\",\"data\": {\"SALDOC\": [{\"SERIES\": \"" + seriesId +
					"\",\"TRDR\": \"" + trdrId +
					"\",\"TRNDATE\": \"" + String.Format("{0:u}", DateTime.Now) +"\"}],\"ITELINES\": [{\"LINENUM\": \"0\",\"MTRL\": \"" + itemId +
					"\",\"QTY1\": \"1\"}]}}";
			string rs = executeRequest(postStr);

			Newtonsoft.Json.Linq.JObject jo = Newtonsoft.Json.Linq.JObject.Parse(rs);
			Boolean success = Convert.ToBoolean(jo["success"].ToString());
			if (success)
			{
				MessageBox.Show("Success post");
				return jo["id"].ToString();
			}
			else
			{
				MessageBox.Show(jo["error"].ToString());
				return "0";
			}
		}


		/// <summary>
		/// It is used to Login the web account defined by RegisteredName in request URL. It returns a temporary 
		/// access token (clientID) that can be later used in the “authenticate” method. It also returns the available 
		/// set of login permissions for the User (Company, Branch, etc.).
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
			loginID = Login(tbWebUsername.Text, tbWebPassword.Text, tbAppID.Text);
			if (loginID != "")
			{
				MessageBox.Show("Success login");
			}
			else
			{
				MessageBox.Show("Unsuccesfull login");
			}
		}

		private void btnAuthenticate_Click(object sender, EventArgs e)
		{
			if (loginID != "")
			{
				clientID = authenticate(loginID);
				if (clientID != "")
				{
					MessageBox.Show("Authentication was succesfull");
				}
				else
				{
					MessageBox.Show("Authentication Failed");
				}
			}
			else
			{
				MessageBox.Show("Please login first");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (clientID != "" && tbSQLScriptName.Text != "")
			{
				textBox4.Text = execSql(tbSQLScriptName.Text);
			}
		}

		private string execSql(string text)
		{
			string result = "";
			try
			{
				string rs = "";
				string authStr = "";

				authStr = "\"service\": \"SqlData\",\"clientID\": \"{0}\", \"AppID\": \"{1}\", \"SqlName\": \"{2}\"";
				rs = executeRequest("{" + string.Format(authStr, clientID, tbAppID.Text, tbSQLScriptName.Text) + "}");

				Newtonsoft.Json.Linq.JObject jo = Newtonsoft.Json.Linq.JObject.Parse(rs);
				Boolean success = Convert.ToBoolean(jo["success"].ToString());
				if (success)
				{
					result = jo["rows"].ToString();
				}
				else
				{
					MessageBox.Show(jo["error"].ToString());
					result = "";
				}
				return result;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return result;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			textBox4.Text = postNewSalDoc(series.Text, trdr.Text, item.Text);
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Ping (Get Method) - Pings the SoftOne API.It is the simplest method that you can use to see that the API is functioning.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button4_Click(object sender, EventArgs e)
		{
			try
			{
				if (tbSerialNumberOrRegisteredName.Text != "")
				{
					HttpWebRequest request = HttpWebRequest.Create($"http://{tbSerialNumberOrRegisteredName.Text}.oncloud.gr/s1services?ping") as HttpWebRequest;
					HttpWebResponse response = (HttpWebResponse)request.GetResponse();
					Stream receiveStream = response.GetResponseStream();
					StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
					MessageBox.Show(readStream.ReadToEnd().Replace("<br>", "\n"));
					response.Close();
					readStream.Close();
				}
				else
				{
					MessageBox.Show("Please Enter SN or Registered Name");
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		/// <summary>
		/// Restarts and refreshes the SoftOne API for the specific URL and returns OK when job is completed. 
		/// Usually used when web application parameters are changed in SoftOne and user needs to see the changes immediately
		/// (e.g. change of the user web menu in SoftOne S360 application).
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>		 
		private void btnRefresh_Click(object sender, EventArgs e)
		{

			try
			{
				if (tbSerialNumberOrRegisteredName.Text != "")
				{
					HttpWebRequest request = HttpWebRequest.Create($"http://{tbSerialNumberOrRegisteredName.Text}.oncloud.gr/s1services?refresh") as HttpWebRequest;
					request.Timeout = 5000;
					HttpWebResponse response = (HttpWebResponse)request.GetResponse();
					Stream receiveStream = response.GetResponseStream();
					StreamReader readStream = new StreamReader(receiveStream);//, Encoding.UTF8);
					MessageBox.Show(readStream.ReadToEnd().Replace("<br>", "\n"));
				}
				else
				{
					MessageBox.Show("Please Enter SN or Registered Name");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
