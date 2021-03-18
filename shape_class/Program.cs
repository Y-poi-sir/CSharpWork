using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace shape_class
{
    public abstract class Shapes
    {
        public abstract double  Area();
        public abstract bool Is_right();
    }

    public class Triangle : Shapes
    {
        public Triangle(double value1,double value2,double value3)
        {
            length1 = value1;
            length2 = value2;
            length3 = value3;
        }

        public Triangle()
        {
            length1 = new Random().Next(1, 10);
            Thread.Sleep(10);
            length2 = new Random().Next(1, 10);
            Thread.Sleep(10);
            length3 = new Random().Next(1, 10);
            Thread.Sleep(10);
        }

       
        public override bool Is_right()
        {
            if ((length1 + length2 > length3 )&&( length2 + length3 > length1) &&( length1 + length3 > length2))
            {
                Console.WriteLine("该三角形合理");
                return true;
            }else{
                Console.WriteLine("该三角形不合理");
                return false;
            }
        }
        public override double Area()
        {
            if (Is_right())
            {
                double p = (length1 + length2 + length3) / 2;
                return Math.Sqrt(p * (p - length1) * (p - length2) * (p - length3));
            }
            else
            {
                return 0;
            }
        }
        public double length1, length2, length3;
    }

    public class Rectangle : Shapes
    {
        public Rectangle(double value1, double value2)
        {
            width = value1;
            highth = value2;
        }

        public Rectangle()
        {
            width = new Random().Next(1, 10);
            Thread.Sleep(10);
            highth = new Random().Next(1, 10);
            Thread.Sleep(10);
        }

        public override double Area()
        {
            return width * highth;
        }
        public override bool Is_right()
        {
            Console.WriteLine("该长方形形状合理");
            return true;
        }
        public double width, highth;
    }

    public class ShapeFactory
    {
        private Shapes shape = null;
        public Shapes CreateShapes(string brand)
        {
            switch (brand)
            {
                case "triangle":

                    shape = new Triangle();
                    break;
                case "rectangle":
                    shape = new Rectangle();
                    break;
                default:
                    break;
            }
            return shape;
        }

        }
    

    class Program
    {
        static void Main(string[] args)
        {
            //测试长方形类
            Rectangle r1 = new Rectangle(10, 5);
            Console.WriteLine(r1.Area());
            r1.Is_right();

            //测试三角形类
            Triangle t1 = new Triangle(3, 4, 5);
            Triangle t2 = new Triangle(1, 1, 2);
            Console.WriteLine("当三角形不合理时，面积为0");

            Console.WriteLine(t1.Area());
            Console.WriteLine(t2.Area());
            t1.Is_right();
            t2.Is_right();
            Console.WriteLine("#################分割线###########3");

            ShapeFactory shapeFactory = new ShapeFactory();
            Shapes shape1 = shapeFactory.CreateShapes("triangle");
            Shapes shape2 = shapeFactory.CreateShapes("triangle");
            Shapes shape3 = shapeFactory.CreateShapes("triangle");
            Shapes shape4 = shapeFactory.CreateShapes("triangle");
            Shapes shape5 = shapeFactory.CreateShapes("triangle");
            Shapes shape6 = shapeFactory.CreateShapes("rectangle");
            Shapes shape7 = shapeFactory.CreateShapes("rectangle");
            Shapes shape8 = shapeFactory.CreateShapes("rectangle");
            Shapes shape9 = shapeFactory.CreateShapes("rectangle");
            Shapes shape10 = shapeFactory.CreateShapes("rectangle");

            Console.WriteLine("面积分别为为：" + shape1.Area() +"," +shape2.Area() +","+ shape3.Area() + "," + shape4.Area() + "," + shape5.Area() + "," + shape6.Area() + "," + shape7.Area() + "," + shape8.Area() + "," + shape9.Area() + "," + shape10.Area());

            Console.WriteLine("总面积为："+(shape1.Area() + shape2.Area() + shape3.Area() + shape4.Area() + shape5.Area() + shape6.Area() + shape7.Area() + shape8.Area() + shape9.Area() + shape10.Area()));




            Console.Read();

        }
    }
}
