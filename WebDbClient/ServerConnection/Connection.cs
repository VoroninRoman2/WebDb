using System.Net.Sockets;

namespace WebDbClient.ServerConnection
{
    static class Connection
    {
        public static TcpClient Client;       
        public static void Initialize(string ip, int port)
        {
            Client = new TcpClient();
            Client.Connect(ip, port);
        }


    }
}
