using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace E4
{
    class OrderService
    {
        public List<Order> Orders = new List<Order>();
        public OrderService(){}
        public OrderService(List<Order> orders)
        {
            Orders = orders;
        }
        public void Add(Order order)
        {
            Orders.Add(order);
        }
        public void Sub(int n)   //删除订单
        {
            int i = -1;
            int j = -1;
            try
            {
                foreach(Order order in Orders)
                {
                    i++;
                    if (order.OrderNum == n)
                    {
                        j = i;
                    }
                }
                Orders.RemoveAt(j);//n如果不存在于list中则j也不存在则无法修改，抛出异常
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("订单号输入错误，请检查。");
            }
        }
        public void Modify(int n,Order orderN)   //修改订单
        {
            int i = -1;
            int j = -1;
            try
            {
                foreach (Order order in Orders)
                {
                    i++;
                    if (order.OrderNum == n)
                    {
                        j = i;
                    }
                }
                Orders[j] = orderN;//n如果不存在于list中则j也不存在则无法修改，抛出异常
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("订单号输入错误，请检查。");
            }

        }
        
        public List<Order> GetOrder(int n)
        {
            var order = Orders.Where(a => a.OrderNum == n);
            List<Order> orders = order.ToList();
            return orders;
        }
        public List<Order> GetOrderById(String name)
        {
            var order = Orders.Where(a => a.Client.ClientName == name);
            List<Order> orders= order.ToList();
            return orders;
        }
        public void Sort()//排序
        {
            Orders.Sort((p1, p2) => p1.OrderNum - p2.OrderNum);
        }
        public void DisplayId()//输出所有的订单编号
        {
            Sort();
            foreach (Order order in Orders)
            {
                Console.WriteLine(order.OrderNum + ",");
            }
        }
    }
}
