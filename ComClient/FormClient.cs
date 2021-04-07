using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComClient
{
    public partial class FormClient : Form
    {
        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string sec, string key, string defStr, StringBuilder sb, int nsb, string path);
        [DllImport("kernel32")]
        static extern int WritePrivateProfileString(string sec, string key, string str, string path);

        public FormClient()
        {
            InitializeComponent();
        }

        string init_IP = "";
        int init_Port = 0;

        private void btbSend_Click(object sender, EventArgs e)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Connect(tbIP.Text, int.Parse(tbPort.Text));
            //string str = tbClient.Text;
            //byte[] bArr = Encoding.Default.GetBytes(str);
            //sock.Send(bArr);

            int ret = sock.Send(Encoding.Default.GetBytes(tbClient.Text));
            if (ret > 0) sbMessage.Text = $"{ret} byte(s) send success.";
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            int x1, y1, x2, y2;
            StringBuilder sb = new StringBuilder(512);
            GetPrivateProfileString("Comm","IP","127.0.0.1", sb, 512, ".\\ComClient.ini"); init_IP = sb.ToString();     // Section [Comm]   , Key [IP   Port]  , ........ FileName  : ComClient.ini
            GetPrivateProfileString("Comm","Port","9001", sb, 512, ".\\ComClient.ini"); init_Port = int.Parse(sb.ToString());
            GetPrivateProfileString("Form", "LocX", $"0", sb, 512, ".\\ComClient.ini"); x1 = int.Parse(sb.ToString());
            GetPrivateProfileString("Form", "LocY", $"0", sb, 512, ".\\ComClient.ini"); y1 = int.Parse(sb.ToString());
            GetPrivateProfileString("Form", "SizeX", $"500", sb, 512, ".\\ComClient.ini"); x2 = int.Parse(sb.ToString());
            GetPrivateProfileString("Form", "SizeY", $"500", sb, 512, ".\\ComClient.ini"); y2 = int.Parse(sb.ToString());

            Location = new Point(x1, y1);
            Size = new Size(x2, y2);
            tbIP.Text = init_IP;
            tbPort.Text = $"{init_Port}";
        }

        private void FormClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            WritePrivateProfileString("Comm", "IP", tbIP.Text, ".\\ComClient.ini");
            WritePrivateProfileString("Comm","Port", tbPort.Text, ".\\ComClient.ini");     // init_Port = int.Parse(sb.ToString());
            WritePrivateProfileString("Form", "LocX", $"{Location.X}", ".\\ComClient.ini");
            WritePrivateProfileString("Form", "LocY", $"{Location.Y}", ".\\ComClient.ini");
            WritePrivateProfileString("Form", "SizeX", $"{Size.Width}", ".\\ComClient.ini");
            WritePrivateProfileString("Form", "SizeY", $"{Size.Height}", ".\\ComClient.ini");

        }
    }
}
