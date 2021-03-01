using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool flag = true;
            Console.Write("请输入第一个数字：");
            string numFirst = Console.ReadLine();
            if (int.TryParse(numFirst, out num))
            {}else{
                Console.WriteLine("警告：您输入的不是数字");
                flag = false;
            };

            Console.Write("请输入运算符：");
            string operatorOfTest = Console.ReadLine();

            Console.Write("请输入第二个数字：");
            string numSecond = Console.ReadLine();

            if (int.TryParse(numSecond, out num))
            {
            }else
            {
                Console.WriteLine("警告：您输入的不是数字");
                flag = false;

            };

            string result="";


            switch (operatorOfTest)
            {
                case "+":
                    result = Convert.ToString(Convert.ToDouble(numFirst) + Convert.ToDouble(numSecond));

                    break;
                case "-":
                    result = Convert.ToString(Convert.ToDouble(numFirst) - Convert.ToDouble(numSecond));
                    break;
                case "*":
                    result = Convert.ToString(Convert.ToDouble(numFirst) * Convert.ToDouble(numSecond));
                    break;
                case "/":
                    if(numSecond=="0"){
                        flag=false;
                    }else
                    {
                        result = Convert.ToString(Convert.ToDouble(numFirst) / Convert.ToDouble(numSecond));
                    }
                    break;

                default:
                    Console.WriteLine("警告：运算符出错");
                    flag=false;
                    break;
            }
            if(flag){
                Console.WriteLine("运算结果是 : "+result);
            }
            else{
                Console.WriteLine("输入格式有误，请检查");
            }
        }
    }
}
