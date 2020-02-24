using System;
using System.Net.Sockets;
using System.Text;

namespace Chat
{
    public class ClientObject
    {
        public string Id { get; private set; }
        public NetworkStream Stream { get; private set; }
        private string _userName;
        private readonly TcpClient _client;
        private readonly ServerObject _server;

        public ClientObject(TcpClient tcpClient, ServerObject serverObject)
        {
            Id = Guid.NewGuid().ToString();
            _client = tcpClient;
            _server = serverObject;
            serverObject.AddConnection(this);
        }

        public void Process()
        {
            try
            {
                Stream = _client.GetStream();
                // получаем имя пользователя
                var message = GetMessage();
                _userName = message;

                message = _userName + " вошел в чат";
                // посылаем сообщение о входе в чат всем подключенным пользователям
                _server.BroadcastMessage(message, this.Id);
                Console.WriteLine(message);

                // в бесконечном цикле получаем сообщения от клиента
                while (true)
                {
                    try
                    {
                        message = GetMessage();
                        message = $"{_userName}: {message}";
                        Console.WriteLine(message);
                        _server.BroadcastMessage(message, this.Id);
                    }
                    catch
                    {
                        message = $"{_userName}: покинул чат";
                        Console.WriteLine(message);
                        _server.BroadcastMessage(message, this.Id);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                _server.RemoveConnection(this.Id);
                Close();
            }
        }

        // чтение входящего сообщения и преобразование в строку
        private string GetMessage()
        {
            var data = new byte[64];
            var builder = new StringBuilder();
            do
            {
                var bytes = Stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (Stream.DataAvailable);

            return builder.ToString();
        }

        public void Close()
        {
            Stream?.Close();
            _client?.Close();
        }
    }
}