using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System;

namespace BasicIPAddress.GUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			cbxResolveTo.SelectedIndex = 0;
		}

		private void btnResolve_Click(object sender, System.EventArgs e)
		{
			IPHostEntry ipHostEntry = new IPHostEntry();
			if (cbxResolveTo.SelectedIndex == 0)		//if chose to resolve to host name
			{
				try
				{
					ipHostEntry = Dns.GetHostByAddress(txtInput.Text);		//resolve to host name
				}
				catch(Exception exc){
					MessageBox.Show(exc.Message);
				}
			}
			else if (cbxResolveTo.SelectedIndex == 1)
			{
				try
				{
					ipHostEntry = Dns.GetHostByName(txtInput.Text);
				}
				catch (Exception exc)
				{
					MessageBox.Show(exc.Message);
				}
			}

			//print host name
			try
			{
				txtHostname.Text = ipHostEntry.HostName;
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}

			//print aliases
			if (ipHostEntry.Aliases.Length == 0)		//if no aliases
			{
				lblAliases.Text = "No aliases";
			}
			else
			{
				string aliasText = "";
				foreach (string alias in ipHostEntry.Aliases)
				{
					aliasText += alias + "\n";
				}
				lblAliases.Text = aliasText;
			}

			//print IPs
			string ipText = "";
			foreach (IPAddress ipAddress in ipHostEntry.AddressList)
			{
				ipText += ipAddress.ToString() + "\n";
			}
			lblIPs.Text = ipText;
		}
	}
}
