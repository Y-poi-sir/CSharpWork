using System;
using System.Collections.Generic;

namespace E3_01
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                //yield return表达式以枚举对象返回
                yield return current.Data;
                current = current.Next;
            }
        }

        public void ForEach(Action<T> action)
        {
            Node<T> n = this.head;
            while (n != null)
            {
                action(n.Data);
                n = n.Next;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> genericList = new GenericList<int> ();
            genericList.Add(1);
            genericList.Add(2);
            genericList.Add(10);
            /*使用foreach
            foreach (int i in genericList)
            {
                Console.WriteLine(i);
            }
            */
            genericList.ForEach(m => Console.WriteLine(m));

            //最小值
            int sum = 0;
            genericList.ForEach(m => { sum += m; });

            Console.WriteLine("总和为："+sum);

            //最小值
            int max = 0;
            genericList.ForEach(m => { if (max < m) max = m; });

            Console.WriteLine("最大值:"+max);

            //最小值
            int min = max;
            genericList.ForEach(m => { if (min > m) min = m; });

            Console.WriteLine("最小值:"+min);


            Console.WriteLine("Hello World!");
        }
    }
}
