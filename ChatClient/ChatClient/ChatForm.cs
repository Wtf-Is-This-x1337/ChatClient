using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace ChatClient
{
    public partial class ChatForm : Form
    {
        // Check for Special Characters
        public static bool hasSymbols(string s)
        {
            string symbols = @"*@\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in symbols)
            {
                if (s.Contains(item)) return true;
            }

            return false;
        }

        // IP
        public static string[] GetAllLocalIPv4(NetworkInterfaceType _type)
        {
            List<string> ipAddrList = new List<string>();
            foreach (NetworkInterface item in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            ipAddrList.Add(ip.Address.ToString());
                        }
                    }
                }
            }
            return ipAddrList.ToArray();
        }

        // Network Interface
        public class Adapters
        {
            public System.Collections.Generic.List<String> net_adapters()
            {
                List<String> values = new List<String>();
                foreach (NetworkInterface nic in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
                {
                    values.Add(nic.Name);
                }
                return values;
            }
        }

        // Client
        TcpClient client;
        byte[] _buffer = new byte[4096];

        public ChatForm()
        {
            InitializeComponent();
        }

        private void connect(string ip, int port, string username)
        {
            string textToSend = "**/%%/***" + username;

            // Connect to the remote server. The IP address and port # could be
            // picked up from a settings file.
            client.Connect(ip, port);

            // Start reading the socket and receive any incoming messages
            client.GetStream().BeginRead(_buffer,
                                            0,
                                            _buffer.Length,
                                            Server_MessageReceived,
                                            null);

            // Create a TCPClient object at the IP and port
            //TcpClient clientMessage = new TcpClient(ip, port);
            NetworkStream nwStream = client.GetStream();
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);

            // Send the user
            nwStream.Write(bytesToSend, 0, bytesToSend.Length);
        }

        private void Server_MessageReceived(IAsyncResult ar)
        {
            if (ar.IsCompleted)
            {
                // End the stream read
                var bytesIn = client.GetStream().EndRead(ar);
                if (bytesIn > 0)
                {
                    var tmp = new byte[bytesIn];
                    Array.Copy(_buffer, 0, tmp, 0, bytesIn);
                    var str = Encoding.ASCII.GetString(tmp);

                    BeginInvoke((Action)(() =>
                    {
                        listBox1.Items.Add(str);
                        listBox1.SelectedIndex = listBox1.Items.Count - 1;
                    }));
                }

                // Clear the buffer and start listening again
                Array.Clear(_buffer, 0, _buffer.Length);
                client.GetStream().BeginRead(_buffer,
                                                0,
                                                _buffer.Length,
                                                Server_MessageReceived,
                                                null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Encode the message and send it out to the server.
            var msg = Encoding.ASCII.GetBytes(textBox1.Text);
            client.GetStream().Write(msg, 0, msg.Length);

            // Clear the text box and set it's focus
            textBox1.Text = "";
            textBox1.Focus();
        }
        

        private void ChatForm_Load(object sender, EventArgs e)
        {
            // Resize chatform for settings 
            this.Text = "Client Settings";
            this.Width = 369;
            this.Height = 237;

            // Update "Useless Stuff"
            ip.Text = GetAllLocalIPv4(NetworkInterfaceType.Ethernet).FirstOrDefault();
            var obj = new Adapters();
            var values = obj.net_adapters();
            NetworkInterface.DataSource = values;
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            bool result = false;
            string ip = TextIp.Text;
            string port = TextPort.Text;
            string user = TextUser.Text;
            int IntPort = Int32.Parse(port); // or "try{convert port to int}catch{error}"

            if (hasSymbols(user))
            {
                MessageBox.Show("Don't use symbols in your username", "Error");
            }
            else
            {
                if (ip != "" && port != "" && user != "")
                {
                    try
                    {
                        client = new TcpClient();
                        connect(ip, IntPort, user);
                        result = true;
                    }
                    catch
                    {
                        MessageBox.Show("Server wasn't found", "Error");
                        result = false;
                    }
                }
                else { MessageBox.Show("Please enter valid input", "Error"); }

                if (result == true)
                {
                    this.Width = 901;
                    this.Height = 571;
                    SettingsPanel.Visible = false;
                }
            }
        }
    }
}
