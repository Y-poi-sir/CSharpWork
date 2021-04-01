using System;
using System.Collections.Generic;
using System.Text;

namespace E4
{
    class Order
    {
        public int OrderNum { set; get; }
        public Client Client { set; get; }
        public OrderDetails[] OrderDetails { set; get; }
        public double Sum { set; get; }

        public Order(int orderNum,Client client, OrderDetails[] orderDetails)
        {
            OrderNum = orderNum;
            Client = client;
            OrderDetails = orderDetails;
        }

        public void Calculate()
        {
            foreach(OrderDetails orderDetail in OrderDetails)
            {
                Sum += (orderDetail.Good.GoodPrice) * (orderDetail.GoodsNum);
            }
        }
        public override string ToString()
        {
            Calculate();
            StringBuilder details = new StringBuilder();
            foreach(OrderDetails orderDetails in OrderDetails)
            {
                details.Append(orderDetails.ToString());
            }
            return "\nOrderNum:" + OrderNum + "\nClient:" + Client.ClientName 
                +details + "\nSum:" + Sum;
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   OrderNum == order.OrderNum &&
                   EqualityComparer<Client>.Default.Equals(Client, order.Client) &&
                   EqualityComparer<OrderDetails[]>.Default.Equals(OrderDetails, order.OrderDetails) &&
                   Sum == order.Sum;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(OrderNum, Client, OrderDetails, Sum);
        }
    }
}
