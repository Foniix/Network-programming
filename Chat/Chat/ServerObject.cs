using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Chat
{
    public class ServerObject
    {
        static TcpListener _tcpListener;
        private readonly List<ClientObject> _clients = new List<ClientObject>();

        public void AddConnection(ClientObject clientObject)
        {
            _clients.Add(clientObject);
        }
        public void RemoveConnection(string id)
        {
            var client = _clients.FirstOrDefault(c => c.Id == id);
            if (client != null)
                _clients.Remove(client);
        }
        // прослушивание входящих подключений
        public void Listen()
        {
            try
            {
                _tcpListener = new TcpListener(IPAddress.Any, 50000);
                _tcpListener.Start();
                Console.WriteLine("Сервер запущен. Ожидание подключений...");
                while (true)
                {
                    var tcpClient = _tcpListener.AcceptTcpClient();
                    var clientObject = new ClientObject(tcpClient, this);
                    var clientThread = new Thread(clientObject.Process);
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Disconnect();
            }
        }

        public void BroadcastMessage(string message, string id)
        {
            var data = Encoding.Unicode.GetBytes(message);
            foreach (var t in _clients)
            {
                t.Stream.Write(data, 0, data.Length);
            }
        }

        public void Disconnect()
        {
            _tcpListener.Stop();

            foreach (var t in _clients)
            {
                t.Close();
            }
            Environment.Exit(0);
        }
    }
}