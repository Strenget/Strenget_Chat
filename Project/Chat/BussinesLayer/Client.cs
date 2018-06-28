using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net.Sockets;

namespace Chat.BussinesLayer
{
    class Client
    {
        public static void Cl(string[] args)
        {
            for (; ; )
            {
                TcpClient newSocked = new TcpClient("localhost", 50001);
                NetworkStream ns = newSocked.GetStream();
                byte[] buf = new byte[100];
                ns.Read(buf, 0, 100);
                char x;
                string str = "";
                char[] buff = new char[100];

                for (int i = 0; i < 100; i++)
                {
                    buff[i] = (char)buf[i];
                    x = buff[i];
                    str += x;
                }
                Console.WriteLine(str);

                ns.Close();
                newSocked.Close();
            }

        }
    }
}
