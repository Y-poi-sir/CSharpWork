using System;
using System.Collections.Generic;
using System.Text;

namespace E4
{
    public class Goods
    {
        public string GoodName { set; get; }
        public double GoodPrice { set; get; }
        public Goods(string name,double price)
        {
            this.GoodName = name;
            this.GoodPrice = price;
        }
        public Goods() { }
        public override string ToString()
        {
            return "goodsName:" + GoodName + "goodPrice:" + GoodPrice;
        }

    }
}
