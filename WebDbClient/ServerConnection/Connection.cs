using System.Net.Sockets;

namespace WebDbClient.ServerConnection
{
    static class Connection
    {
        private static TcpClient client;
        public static TcpClient Client
        {
            get
            {
                return client;
            }
        }
        public static void Initialize(string ip, int port)
        {
            client = new TcpClient();
            client.Connect(ip, port);
        }


    }
}
