using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Client_FileTranfer
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ipa = IPAddress.Parse("127.0.0.1");
            IPEndPoint iep = new IPEndPoint(ipa, 6000);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(iep);

            byte[] msgBytes = new byte[1024];
            byte[] Size = new byte[4]
            for (int i = 0; i < msgBytes.Length; i++)
            {
                if (i < 4)
                {
                    Size[i] = msgBytes[i];
                }
            }
            int msgSize = socket.Receive(Size);
            string msgStr = Encoding.ASCII.GetString(msgBytes);
            for (int i = 0; i < msgSize; i++)
            {
                Console.Write(msgStr[i]);
            }
            Console.WriteLine();
            Array.CopyTo
            Console.ReadLine();
            
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }
    }
}
