using System;
using System.Collections.Generic;
using System.Text;

namespace E4
{
    public class Client
    {
        public string ClientName { set; get; }
        public Client(string name)
        {
            ClientName = name;
        }
        public Client() { }
        public override string ToString()
        {
            return "clientNmae:" + ClientName;
        }
    }
}
