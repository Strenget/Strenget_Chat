using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;

namespace Chat.BussinesLayer
{
    class Server
    {
        private void Listen()
        {
            // listen on port 50001
            TcpListener tcpl = new TcpListener(50001);

            string a;
            int i = 0;
            char b = ' ';

            tcpl.Start();

            // wait for a client
            for (; ; )
            {
                // block here waiting for client onnection
                Socket newSocked = tcpl.AcceptSocket();

                Console.WriteLine("User connected");

                a = Convert.ToString(Console.ReadLine());

                if (newSocked.Connected)
                {
                    // create a NetworkStream on the socket
                    NetworkStream ns = new NetworkStream(newSocked);

                    for (i = 0; i < a.Length; i++)
                    {
                        b = Convert.ToChar(a[i]);
                        byte[] buf = { Convert.ToByte(b) };

                        ns.Write(buf, 0, 1);
                    }

                    ns.Flush();
                    ns.Close();
                }
                // clean up and quit
                newSocked.Close();
                // break;
            }

        }

        public static void Maiin(string[] args)
        {
            // launch a listening thread. запустить прослушивающую нить
            Server listener = new Server();
            listener.Listen();

        }
    }
}
