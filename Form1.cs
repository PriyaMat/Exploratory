using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TlsExploration4._7
{
	public partial class Form1 : Form
	{
		string sConnected = "Connected!";
		private string sValidationCaption = "UI Validation";
		private string sValidationMsg = "Choose atleast one URL";
		private string sNotConnected = " Connection Failed!";
		private string sConnectedUrl = "Attempted connection to:";

		public Form1()
		{
			InitializeComponent();
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			ValidateUI();

			if (chkDev.Checked)
			{
				Connect(chkDev.Text);
			}
			if (chkProd.Checked)
			{
				Connect(chkProd.Text);
			}
			if (chkStaging.Checked)
			{
				Connect(chkStaging.Text);
			}
		}

		private void ValidateUI()
			{
				if (!chkDev.Checked && !chkProd.Checked && !chkStaging.Checked)
				{
					MessageBox.Show(sValidationMsg, sValidationCaption, MessageBoxButtons.OK);
				}		
			
			}

			private void Connect(string sUrl)
			{
				string[] sSplitUrl = sUrl.Split('=');
		
			
				try
				{
					var request = (HttpWebRequest)WebRequest.Create(sSplitUrl[1]);
					//request.Credentials = CredentialCache.DefaultCredentials;
				
					if (chkSsl.Checked)
						System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
					if (chkTls10.Checked)
						System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
					if (chkTls11.Checked)
						System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11;
					if (chkTls1pt2.Checked)
						System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

					var response = (HttpWebResponse)request.GetResponse();
					var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
					MessageBox.Show(text: sConnectedUrl + sSplitUrl[1] + "\nHTTP Status:" + response.StatusDescription + ". Security Protocol used : " + ServicePointManager.SecurityProtocol, caption: sConnected, buttons: MessageBoxButtons.OK);
				}
				catch (Exception e)
				{
					string sErrorMsg = sConnectedUrl + sSplitUrl[1] + e.Message;
					MessageBox.Show(sErrorMsg + "\nSecurity Protocol used : " + System.Net.ServicePointManager.SecurityProtocol + "\n\n", sNotConnected, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			
			}
		}
	}

