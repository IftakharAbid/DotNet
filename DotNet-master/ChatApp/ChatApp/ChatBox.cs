using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ChatApp
{
    public partial class ChatBox : Form
    {
        Socket sck;
        EndPoint epSender, epReceiver;
        byte[] buffer;

        public ChatBox()
        {
            InitializeComponent();
        }

        private void ChatBox_Load(object sender, EventArgs e)
        {
            //set up socket
            sck = new Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket,SocketOptionName.ReuseAddress,true);

            //get user ip Auto
            txtMyIP.Text = GetLocalIP();
            txtReceiverIP.Text= GetLocalIP();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            //binding socket
            epSender = new IPEndPoint(IPAddress.Parse(txtMyIP.Text), Convert.ToInt32(txtMyPort.Text));
            sck.Bind(epSender);

            //connecting to receiver ip(remote ip)
            epReceiver= new IPEndPoint(IPAddress.Parse(txtReceiverIP.Text), Convert.ToInt32(txtReceiverPort.Text));
            sck.Connect(epReceiver);

            //Listen the specific port

            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epReceiver, new AsyncCallback(MessageCallBack), buffer);

        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "127.0.0.1";
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
           
                if (txtMesseage.Text == "")
                {
                    MessageBox.Show("Please type a Message");

                }
                else
                {
                    //converting string message to byte[]
                    ASCIIEncoding aEcoding = new ASCIIEncoding();
                    byte[] sendingMessage = new byte[1500];
                    sendingMessage = aEcoding.GetBytes(txtMesseage.Text);

                    //sending the encoded message
                    sck.Send(sendingMessage);

                    //adding to the list box

                    chatList.Items.Add("Me: " + txtMesseage.Text);
                    txtMesseage.Text = "";
                }
           }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;

                //converting byte to string

                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);

                //adding this intoo listbox
                chatList.Items.Add("Friend: " + receivedMessage);

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epReceiver, new AsyncCallback(MessageCallBack), buffer);
             //  MessageBox.Show("Connected");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
