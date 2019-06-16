﻿using System;
using System.Text;
using System.Net.Sockets;
using Newtonsoft.Json;

namespace SharedLib
{
    public static class Interactions
    {
        /// <summary>
        /// Унифицированный формат кодов для "общения" клиента и сервера
        /// </summary>
        public enum codes
        { 
            PUBLIC_KEY,
            ENCRYPTED_MESSAGE,
            DISCONNECT_MESSAGE
        }
        /// <summary>
        /// Отправка в поток преобразованного в json объекта класса Message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="client"></param>
        public static void SendToStream(MessageClass message, ref TcpClient client)
        {
            try
            {
                NetworkStream stream = client.GetStream();
                string temp = JsonConvert.SerializeObject(message);
                byte[] data = Encoding.Unicode.GetBytes((temp.Length * 2).ToString() + temp);
                if (stream != null && stream.CanWrite)
                    stream.Write(data, 0, data.Length);
            }
            catch
            {
                if (client != null)
                    client.Close();
            }
        }
        /// <summary>
        /// Получение сообщения из потока и его расшифровка из jsona в объект класса Message
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static MessageClass GetFromStream(ref TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            StringBuilder builder = new StringBuilder();
            byte[] data = new byte[64];
            int toGet = 0, got = 0, from = 0, bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, (toGet != 0 && toGet - got < data.Length ? toGet - got : data.Length));
                got += bytes;
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                if (toGet == 0 && builder.Length > 0)
                {
                    string temp = builder.ToString();
                    toGet = int.Parse(temp.Substring(0, temp.IndexOf("{")));
                    from = (int)Math.Log10(toGet) + 1;
                    got -= from * 2;
                }
            }
            while (toGet == 0 || toGet > got);
            return JsonConvert.DeserializeObject<MessageClass>(builder.ToString().Substring(from));
        }
    }
}
