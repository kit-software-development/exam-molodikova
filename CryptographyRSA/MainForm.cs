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
        // Публичный ключ сервера
        RSAParameters serverKey;
        private RSAClass rs = new RSAClass();
        // Класс, через который происходит общение клиента с сервером
        TcpClient client;
        public MainForm()
        {
            InitializeComponent();
        }
        // При загрузке формы выводится публичный ключ клиента и отключается кнопка отправки
        private void MainForm_Load(object sender, EventArgs e)
        {
            textPublicKey.Text = rs.PublicKeyString();
            buttonSend.Enabled = false;
        }
        /*
        При нажатии на connect, подключаемся к указанным адресу и порту
        и запускаем новый поток(задача) с прослушкой новых сообщений от сервера,
        потому что если запускать её в основном потоке, то он зависнет до получения сообщения.
        */
        private void click_Connect(object sender, EventArgs e)
        {
            try
            {
                buttonConnect.Enabled = false;
                client = new TcpClient(textHost.Text, Convert.ToInt32(textPort.Text));
                SendToStream(new MessageClass(codes.PUBLIC_KEY, rs.PublicKeyString()), ref client);
                Task.Run(() => GetNewMessages());
            }
            catch (Exception ex)
            {
                MessageBox.Show("In click_Connect: " + ex.Message);
            }
        }
        // При нажатии на кнопку send отсылается сообщение и закодированный текст из textContent
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
        // В цикле while ждём новых сообщений от сервера (обрабатываются в case)
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
                        // При получении публичного ключа сервера сохраняем его
                        case codes.PUBLIC_KEY:
                            buttonSend.Invoke(new Action(() => buttonSend.Enabled = true));
                            serverKey = JsonConvert.DeserializeObject<RSAParameters>(message.info);                      
                            break;
                        // При получении зашифрованного сервером сообщения расшифровываем и выводиим в два поля
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
        // При закрытии окна говорим серверу, что уходим
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SendToStream(new MessageClass(codes.DISCONNECT_MESSAGE), ref client);
        }
    }
}
