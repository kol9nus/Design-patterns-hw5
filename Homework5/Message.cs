using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class Message
    {
        public IClient Author;
        public IClient Receiver;
        public string Text;

        public Message(string text, IClient author, IClient receiver)
        {
            this.Author = author;
            this.Receiver = receiver;
            this.Text = text;
        }
    }
}
