using System;
using System.Collections.Generic;
using System.Text;

namespace E4
{
    class Client
    {
        public string ClientName { set; get; }
        public Client(string name)
        {
            ClientName = name;
        }
        public override string ToString()
        {
            return "clientNmae:" + ClientName;
        }
    }
}
