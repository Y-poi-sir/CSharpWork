using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            Goods good1 = new Goods("book", 10);
            Goods good2 = new Goods("pen", 3);
            Goods good3 = new Goods("eraser", 2);

            Client client1 = new Client("Ye");
            Client client2 = new Client("Yong");

            OrderDetails orderDetails1 = new OrderDetails(good1, 1);
            OrderDetails orderDetails2 = new OrderDetails(good2, 2);
            OrderDetails orderDetails3 = new OrderDetails(good3, 3);

            OrderDetails[] orderDetails_1 = { orderDetails1, orderDetails2 };
            OrderDetails[] orderDetails_2 = { orderDetails2, orderDetails3 };
            OrderDetails[] orderDetails_3 = { orderDetails1, orderDetails3 };

            Order order1 = new Order(1, client1, orderDetails_1);
            Order order2 = new Order(2, client1, orderDetails_2);
            Order order3 = new Order(3, client2, orderDetails_3);

            OrderService orderService = new OrderService();
            orderService.Add(order3);
            orderService.Add(order2);
            orderService.Add(order1);
            orderService.DisplayId();
            orderService.Sub(3);
            orderService.DisplayId();
            orderService.Sub(3);

            List<Order> list = orderService.GetOrderById("Ye");
            foreach(Order order in list)
            {
                Console.WriteLine(order);
            }

            List<Order> order4 = orderService.GetOrder(1);
            foreach (Order order in order4)
            {
                Console.WriteLine(order);
            }

            orderService.Export();
            //Console.ReadKey();




        }
    }
}
