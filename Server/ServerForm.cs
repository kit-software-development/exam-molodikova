using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedLib;
using static SharedLib.Interactions;
using System.Security.Cryptography;
using Newtonsoft.Json;

namespace Server
{
    public partial class FormServer : Form
    {
        static int id = 0;
        private RSAClass rs = new RSAClass();
        static TcpListener listener;
        Dictionary<int, RSAParameters> connectedUsers = new Dictionary<int, RSAParameters>();

        public FormServer()
        {
            InitializeComponent();
        }
        
        private void FormServer_Load(object sender, EventArgs e)
        {
            buttonStop.Enabled = false;
        }
        private void ClickStart(object sender, EventArgs e)
        {
            try
            {
                listener = new TcpListener(IPAddress.Parse(textHost.Text), Convert.ToInt32(textPort.Text));
                MessageBox.Show("Server starting");
                buttonStart.Enabled = false;
                buttonStop.Enabled = true;
                Task.Run(() => Server_Listen());
            }
            catch
            {
                MessageBox.Show("Bad ip or port");
            }
        }
        private void Server_Listen()
        {
            try
            {
                listener.Start();
                while (true)
                {
                    Console.WriteLine("Waiting for connections...");
                    TcpClient client = listener.AcceptTcpClient();
                    Console.WriteLine("Somebody connected.");
                    connectedUsers.Add(id, new RSAParameters());
                    Task.Run(() => Process_User(ref client, id++));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Server stopping " + e.Message);
            }
        }
        private void Process_User(ref TcpClient client, int id)
        {
            try
            {
                MessageClass message;
                while (true)
                {
                    message = GetFromStream(ref client);
                    switch (message.code)
                    {
                        case codes.PUBLIC_KEY:
                            connectedUsers[id] = JsonConvert.DeserializeObject<RSAParameters>(message.info);
                            textDecrypt.BeginInvoke(new Action(() => textDecrypt.Text = "Sent to user " + id));
                            textStatus.BeginInvoke(new Action(() => textStatus.Text = message.info));
                            SendToStream(new MessageClass(codes.PUBLIC_KEY, rs.PublicKeyString()), ref client);
                            break;
                        case codes.ENCRYPTED_MESSAGE:
                            textDecrypt.Text = message.info;
                            SendToStream(new MessageClass(codes.ENCRYPTED_MESSAGE, rs.Encrypt("Пажилое сообщение: " + 
                                rs.Decrypt(message.info), connectedUsers[id])), ref client);
                            break;
                        case codes.DISCONNECT_MESSAGE:
                            connectedUsers.Remove(id);
                            break;
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("In Process_User: " + e.Message);
            }
        }

        private void ClickStop(object sender, EventArgs e)
        {
            listener.Stop();
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
        }
    }
}
