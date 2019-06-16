using System;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading.Tasks;
using SharedLib;
using System.Security.Cryptography;
using static SharedLib.Interactions;
using Newtonsoft.Json;

namespace CryptographyRSA
{
    public partial class MainForm : Form
    {
        RSAParameters serverKey;
        private RSAClass rs = new RSAClass();
        TcpClient client;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            textPublicKey.Text = rs.PublicKeyString();
            buttonSend.Enabled = false;
        }
        private void clickEncrypt(object sender, EventArgs e)
        {
            if (textContent.Text == "")
            {
                MessageBox.Show("Please, inform some content!");
                return;
            }
            else
            {
                textEncrypt.Text = rs.Encrypt(textContent.Text, rs._publicKey);
            }
        }
        private void click_Connect(object sender, EventArgs e)
        {
            try
            {
                buttonConnect.Enabled = false;
                client = new TcpClient("127.0.0.1", Convert.ToInt32(textPort.Text));
                SendToStream(new MessageClass(codes.PUBLIC_KEY, rs.PublicKeyString()), ref client);
                Task.Run(() => GetNewMessages());
            }
            catch (Exception ex)
            {
                MessageBox.Show("In click_Connect: " + ex.Message);
            }
        }
        private void clickSend(object sender, EventArgs e)
        {
            try
            {
                SendToStream(new MessageClass(codes.ENCRYPTED_MESSAGE, rs.Encrypt(textContent.Text, serverKey)), ref client);
            }
            catch (Exception ex)
            {
                MessageBox.Show("In clickSend: " + ex.Message);
            }
        }
        private void GetNewMessages()
        {
            MessageClass message;
            try
            {
                while (true)
                {
                    message = GetFromStream(ref client);
                    switch (message.code)
                    {
                        case codes.PUBLIC_KEY:
                            buttonSend.Invoke(new Action(() => buttonSend.Enabled = true));
                            serverKey = JsonConvert.DeserializeObject<RSAParameters>(message.info);
                            //SendToStream(new MessageClass(codes.ENCRYPTED_MESSAGE, rs.Encrypt(textContent.Text, serverKey)), ref client);
                            break;
                        case codes.ENCRYPTED_MESSAGE:
                            textEncrypt.Text = message.info;
                            textDecrypt.Text = rs.Decrypt(message.info);
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("In GetNewMessages: " + e.Message);
            }
        }
        //проверка расшифровки//удалить позже
        private void clickDecrypt(object sender, EventArgs e)
        {
            var data = textEncrypt.Text;
            textDecrypt.Text = rs.Decrypt(data);
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SendToStream(new MessageClass(codes.DISCONNECT_MESSAGE), ref client);
        }
    }
}
