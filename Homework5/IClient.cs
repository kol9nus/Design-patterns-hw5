using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public interface IClient
    {
        string Name { get; }
        void SendMsg(string text, IClient receiver);
        void RecvMsg(Message msg);
    }
}
