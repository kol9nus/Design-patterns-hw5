using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class Client : IClient
    {
        public string Name { get; }

        public Client(string name)
        {
            this.Name = name;
        }
        public void SendMsg(string text, IClient receiver)
        {
            Message msg = new Message(text, this, receiver);
            Console.WriteLine(this.Name + " отправил сообщение '" + msg.Text + "' к " + receiver.Name);
            receiver.RecvMsg(msg);
        }

        public void RecvMsg(Message msg)
        {
            Console.WriteLine(this.Name + " получил сообщение '" + msg.Text + "' от " + msg.Author.Name);
        }
    }
}
