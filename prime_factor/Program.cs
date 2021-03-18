using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_factor
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> results = new List<int>();

            int number = Int32.Parse(Console.ReadLine());

            for (int pri = 2; pri < number; pri++)
            {
                while (number % pri == 0 && pri != number)
                {
                    results.Add(pri);
                    number /= pri;
               }

            }
            results.Add(number);
            Console.WriteLine("质因数为：");
 
            foreach (var result in results)
            {
                Console.Write(result);
                Console.Write(",");
            }
            Console.WriteLine("输出完毕");
            Console.Read();
        }
    }
}
