using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pris = new List<int>();
            for(int num = 2;num <= 100; num++)
            {
                bool flag = true;
                int i = 2;
                while (i <= 10){
                    if (i != num && num % i == 0)
                    {
                        flag = false;
                        break;
                    }
                    i++;
                }
                if (flag)
                {
                    pris.Add(num);
                }
            }
            Console.WriteLine("2到100的质数有：");
            foreach(var pri in pris)
            {
                Console.Write(pri+",");
            }
            Console.Read();
        }
    }
}
