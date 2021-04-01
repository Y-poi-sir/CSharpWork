using System;
using System.Collections.Generic;
using System.Text;

namespace E4
{
    class OrderDetails
    {
        public Goods Good;
        public int GoodsNum;
        public OrderDetails(Goods goods,int goodsNum)
        {
            Good = goods;
            GoodsNum = goodsNum;
        }

        public override bool Equals(object obj)
        {
            return obj is OrderDetails details &&
                   EqualityComparer<Goods>.Default.Equals(Good, details.Good) &&
                   GoodsNum == details.GoodsNum;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Good, GoodsNum);
        }

        public override string ToString()
        {
            return "\ngoodsName:" + Good.GoodName + "\ngoodsPrice:" + Good.GoodPrice + "\ngoodsNum:" + GoodsNum;
        }

    }
}
