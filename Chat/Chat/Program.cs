using System;
using System.Threading;

namespace Chat
{
    class Program
    {
        static ServerObject _server;
        // потока для прослушивания
        static Thread _listenThread;
        static void Main()
        {
            try
            {
                _server = new ServerObject();
                _listenThread = new Thread(_server.Listen);
                _listenThread.Start();
            }
            catch (Exception ex)
            {
                _server.Disconnect();
                Console.WriteLine(ex.Message);
            }
        }
    }
}
