using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            //  1. 무한 수신 대기 Waiting
            //  2. 기존 이벤트 처리 : 
            //  3. 외부 접속 요청 수신시 해당 요청 처리
            if (thread == null)
            {
                thread = new Thread(ServerProcess);  // Thread 선언
                thread.Start();
            }
            else
            {
                thread.Resume();
            }
            sbServerMessage.Text = "Thread on Running.";
            timer1.Enabled = true;
            // ServerProcess();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            thread.Suspend();
            if (thread.IsAlive) sbServerMessage.Text = "Thread Alived.";
            else sbServerMessage.Text = "Thread not Alived.";
        }

        Thread thread = null;
        TcpListener listener = null;
        string MainMsg; // tbServer.Text
        byte[] bArr = new byte[200];

        private void ServerProcess()
        {
            while (true)
            {
                if(listener == null) listener = new TcpListener(int.Parse(tbServerPort.Text));
                listener.Start();       // listener는 계속 수행 --- Stop 명령 까지
//                sbServerMessage.Text = "Listening....";
//                Invalidate();       // == this.invalidate();
                if(listner.Pending())     // 현재 대기중인 요청이 있는가?
                {
                    TcpClient tcp = listener.AcceptTcpClient();     // 외부로부터의 접속 요청 수신 // Tcp Type Socket 블로킹(Blocking) 논(Non) 블로킹
//                   Socket sock = listener.AcceptSocket();
//                   sbServerMessage.Text = "Connected";
//                   sbServerLabel2.Text = "Connected";
                    NetworkStream ns = tcp.GetStream();
                    while (ns.DataAvailable)
                    {
                        ns.Read(bArr, 0, 200);
                        MainMsg += Encoding.Default.GetString(bArr);
                    }
                }
                listener.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)  // Send 1 packet : 통신 메세지 단위 1024Byte ~= 1K LTE
        {
            //  1.  Socket 생성 : 주소가 없음
            //  2.  Socket Open - Conection 수립 - 주소 부여
            //  3.  메세지 전송 : Message - 문자열 외에 이미지나 동영상도 가능, 단 양측이 서로 약속된 규악에 의해서... => 프로토콜 제정
            Socket sock = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);    // TCP : 수신 확인      UDP : 수신 확인 없음(방송)
            sock.Connect(tbIP.Text, int.Parse(tbPort.Text));
            string str = tbClient.Text;
            byte[] bArr = Encoding.Default.GetBytes(str);       //  char[]  ==  string

            sock.Send(bArr);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tbServer.Text = MainMsg;
        }

        private void FormServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            thread.Abort();
        }
    }
}
