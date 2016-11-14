using System;

namespace Homework5
{
    public class DecoratorBase : IClient
    {
        private readonly IClient _decoratee;

        public string Name => _decoratee.Name;

        protected DecoratorBase(IClient client)
        {
            this._decoratee = client;
        }
        public void SendMsg(string text, IClient receiver)
        {
            string ecryptedText = OnBeforeSendMsg(text);
            _decoratee.SendMsg(ecryptedText, receiver);
        }

        public void RecvMsg(Message receivingMsg)
        {
            Message decryptedMessage = OnBeforeRecvMsg(receivingMsg);
            _decoratee.RecvMsg(decryptedMessage);

        }

        public virtual string OnBeforeSendMsg(string text)
        {
            return text;
        }

        public virtual Message OnBeforeRecvMsg(Message msg)
        {
            return msg;
        }
    }

    public class EncryptDecorator : DecoratorBase
    {
        public override string OnBeforeSendMsg(string text)
        {
            Console.WriteLine("Зашифровываем " + text);
            text = "72385" + text + "72385";
            Console.Write("Encrypting ");
            return text;
        }

        public EncryptDecorator(IClient client) : base(client)
        {
        }
    }

    public class DecryptDecorator : DecoratorBase
    {
        public override Message OnBeforeRecvMsg(Message msg)
        {
            Console.WriteLine("Расшифровываем " + msg.Text);
            msg.Text = msg.Text.Substring(5, msg.Text.Length - 10);
            Console.Write("Decrypting ");
            return msg;
        }

        public DecryptDecorator(IClient client) : base(client)
        {
        }
    }
}
