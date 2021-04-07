using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComTest
{
    public partial class FormServer : Form
    {
        public FormServer()
        {
            InitializeComponent();
        }
        delegate void cbAddText(string str);    // string str을 인수로 받아서 tbServer에 출력하는 콜백 함수
        //invoke
        void AddText(string str)    // Thread 내부에서 호출될 함수 sbServer 출력
        {
            if (tbServer.InvokeRequired)
            {
                cbAddText at = new cbAddText(AddText);
                object[] oArr = { str };
                Invoke(at, oArr);
                //Invoke(at, new object[] { str });
            }
            else
            {
                tbServer.Text += str;   // Thread에서 수행해야 할 본래 작업
            }
        }

        Thread thread = null;
        TcpListener listener = null;
        string mainMsg = "";
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (thread == null)
            {
                thread = new Thread(ServerProcess);
                thread.Start();
            }
            timer1.Start();
            sbServerMessage.Text = "Listener started..";
            AddText($"ServerProcess now startd... Open Port is {tbServerPort}.");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            thread.Abort(); //thread.Suspend(); thread.Resume();
            thread = null;
            timer1.Stop();
            sbServerMessage.Text = "Server stopped..";
        }

        void ServerProcess()
        {
            while (true)
            {
                if (listener == null)
                {
                    listener = new TcpListener(int.Parse(tbServerPort.Text));
                    listener.Start();
                }
                if (listener.Pending())             // Non-Blocking Method
                {
                    ////TcpClient tcp = listener.AcceptTcpClient();     // Blocking Method

                    //Socket sock = listener.AcceptSocket();        // Mission : TcpClinet 가 아닌 Socket 을 이용해서 Accept 및 입력 stream 처리

                    //byte[] bArr = new byte[200];
                    //sock.Receive(bArr, 0, 200);
                    //EndPoint ep = tcp.Client.RemoteEndPoint;
                    //sbServerLabel2.Text = ep.ToString();    //xxx.xxx.xxx.xxx   :xxxx
                    //NetworkStream ns = tcp.GetStream();
                    //while (ns.DataAvailable)        // ns에 읽을 data가 있다면 진입
                    //{
                    //    int n = ns.Read(bArr, 0, 200);
                    //    //tbServer.Text += Encoding.Default.GetString(bArr, 0, n);    // Cross-thread error
                    //    //mainMsg += Encoding.Default.GetString(bArr, 0, n);    // Cross-thread error
                    //    AddText(Encoding.Default.GetString(bArr, 0, n));
                    //}

                    Socket sock = listener.AcceptSocket();        // Mission : TcpClinet 가 아닌 Socket 을 이용해서 Accept 및 입력 stream 처리
                    byte[] bArr = new byte[sock.Available];
                    int n = sock.Receive(bArr);
                    AddText(Encoding.Default.GetString(bArr, 0, n));

                    IPEndPoint ep = (IPEndPoint)sock.RemoteEndPoint;      // 127.0.0.1:76543
                    sbServerLabel2.Text = $"{ep.Address}:{ep.Port}";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)    //  1/1000 초 단위로 tick 발생
        {
            tbServer.Text += mainMsg;
            mainMsg = "";
        }

        private void FormServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread.Abort(); // Thread 종료
        }
    }
}
