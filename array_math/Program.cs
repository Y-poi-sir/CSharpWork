using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_math
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {1,2,3,4,5,6,7,8,9,10};
            Console.WriteLine("最大的数是："+ array.Max());
            Console.WriteLine("最小的数是："+ array.Min());
            Console.WriteLine("平均数是："+ array.Average());
            Console.Read();
        }
    }
}
