using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace OperaChromeFoxEdge
{
    class Program
    {
        static void Main(string[] args)
        {
            const string IP = "127.0.0.1";
            const int PORT = 8080;
            const int MAXBUF = 9999;
            string command = "GET";
            string operand = "index.html";

            if (args.Length>0)

            Console.WriteLine("Client started");
            IPAddress addr = IPAddress.Parse(IP);
            var client = new TcpClient();
            Console.WriteLine($"Client attempting to connect to {IP}");
            client.Connect(addr, PORT);

            var stream = client.GetStream();
            string s = command + " " + operand + " HTTP/1.1\n";
            stream.Write(Encoding.ASCII.GetBytes(s, 0, s.Length), 0, s.Length);
            byte[] buffer = new byte[MAXBUF];
            int iLen = stream.Read(buffer, 0, MAXBUF);
        }
    }
}