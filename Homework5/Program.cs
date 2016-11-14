using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client("Петя");
            Client client2 = new Client("Вася");
            EncryptDecorator encryptingClient1 = new EncryptDecorator(client1);
            DecryptDecorator decryptingClient2 = new DecryptDecorator(client2);
            client1.SendMsg("Hello", client2);
            Console.WriteLine();
            encryptingClient1.SendMsg("Hello", decryptingClient2);
            Console.WriteLine();
            encryptingClient1.SendMsg("Hello", client2);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
