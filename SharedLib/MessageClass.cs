using System.Collections.Generic;

namespace SharedLib
{
    /// <summary>
    /// Класс, представляющий собой единицу передачи данных между клиентом и сервером
    /// </summary>
    public class MessageClass
    {
        public Interactions.codes code { get; private set; }
        public string info { get; private set; }
        public MessageClass(Interactions.codes code, string info = null)
        {
            this.code = code;
            this.info = info;
        }
    }
}
