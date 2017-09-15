using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace BasicIPAddress.GUI
{
	public partial class MainForm : Form
	{
		private IPAddress ipAddress;


		public MainForm()
		{
			InitializeComponent();
			ipAddress = IPAddress.Parse("192.168.1.150");

		}
	}
}
