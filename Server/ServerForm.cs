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
        // Id подключившегося пользователя
        static int id = 0;
        private RSAClass rs = new RSAClass();
        // Класс, который следит за новыми подключениями
        static TcpListener listener;
        // Коллекция, хранящая сопоставление id пользователя и его публичного ключа
        Dictionary<int, RSAParameters> connectedUsers = new Dictionary<int, RSAParameters>();

        public FormServer()
        {
            InitializeComponent();
        }
        // Блокируем кнопку остановки сервера, пока он не был запущен
        private void FormServer_Load(object sender, EventArgs e)
        {
            buttonStop.Enabled = false;
        }
        // При нажатии на кнопку запуска сервера происходит инициализация listenera и запуск
        // задачи прослушки указанного адреса с портом
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
        // В бесконечном цикле ждём новых пользователей. При подключении создаём новый поток, который его обрабатывает
        private void Server_Listen()
        {
            try
            {
                listener.Start();
                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    connectedUsers.Add(id, new RSAParameters());
                    Task.Run(() => Process_User(ref client, id++));
                }
            }
            catch
            {
                MessageBox.Show("Server stopping ");
            }
        }
        // Обработка запросов от пользователя. При получении пакета с кодом disconnect прекращаем
        private void Process_User(ref TcpClient client, int id)
        {
            bool connected = true;
            try
            {
                MessageClass message;
                while (connected)
                {
                    message = GetFromStream(ref client);
                    switch (message.code)
                    {
                        // При получении публичного ключа отсылаем свой.
                        case codes.PUBLIC_KEY:
                            connectedUsers[id] = JsonConvert.DeserializeObject<RSAParameters>(message.info);
                            // Вывод значений в textbox-формы
                            textDecrypt.BeginInvoke(new Action(() => textDecrypt.Text = "Sent to user " + id));
                            textStatus.BeginInvoke(new Action(() => textStatus.Text = message.info));
                            SendToStream(new MessageClass(codes.PUBLIC_KEY, rs.PublicKeyString()), ref client);
                            break;
                        // При получении зашифрованного сообщения расшифровываем своим приватным ключом, добавляем текст,
                        // шифруем и отсылаем
                        case codes.ENCRYPTED_MESSAGE:
                            textDecrypt.Text = message.info;
                            SendToStream(new MessageClass(codes.ENCRYPTED_MESSAGE, rs.Encrypt("Пажилое сообщение: " + 
                                rs.Decrypt(message.info), connectedUsers[id])), ref client);
                            break;
                        // Удаляем пользователя, захотевшего уйти
                        case codes.DISCONNECT_MESSAGE:
                            connectedUsers.Remove(id);
                            connected = false;
                            break;
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("In Process_User: " + e.Message);
            }
        }
        // При нажатии на кнопку стоп закрываем listener и переключаем кнопки
        private void ClickStop(object sender, EventArgs e)
        {
            listener.Stop();
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
        }
    }
}
