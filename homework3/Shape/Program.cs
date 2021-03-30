using System;

namespace Shape
{
    
    //抽象类
    abstract class Shape
    {
        //面积
        public abstract double Area();

        //初始化数据
        public abstract void Initialization();
    }

    class Rectangle : Shape
    {
        double width;
        double height;
        public Rectangle()
        {
            Initialization();
        }

        public override double Area()
        {
            return width * height;
        }

        public override void Initialization()
        {
            while (true)
            {
                Console.WriteLine("请选择输入长方形的长：");
                string widthStr = Console.ReadLine();
                Console.WriteLine("请选择输入长方形的宽：");
                string heightStr = Console.ReadLine();
                if (!double.TryParse(widthStr, out width) || !double.TryParse(heightStr, out height))
                {
                    Console.Write("输入数据出现非法字符");
                    continue;
                }
                break;
            }
        }
    }

    class Square : Shape
    {
        double width;
        public Square()
        {
            Initialization();
        }

        public override double Area()
        {
            return width * width;
        }

        public override void Initialization()
        {
            while (true)
            {
                Console.WriteLine("请输入正方形的边长：");
                string widthStr = Console.ReadLine();
                if (!double.TryParse(widthStr, out width))
                {
                    Console.WriteLine("输入数据出现非法字符");
                    continue;
                }
                break;
            }
        }
    }

    class Triangle:Shape
    {
        double side1, side2, side3;//用三边表示便于判断是否合法
        public Triangle()
        {
            Initialization();
        }
        
        public override double Area()
        {
            double t = (side1 + side2 + side3) / 2;
            return Math.Sqrt(t * (t - side1) * (t - side2) * (t - side3));
        }

        public override void Initialization()
        {
            while (true)
            {
                Console.Write("请输入三角形第1个边长：");
                string side1Str = Console.ReadLine();
                Console.Write("请输入三角形第2个边长：");
                string side2Str = Console.ReadLine();
                Console.Write("请输入三角形第3个边长：");
                string side3Str = Console.ReadLine();
                if (!double.TryParse(side1Str, out side1) || !double.TryParse(side2Str, out side2)
                || !double.TryParse(side3Str, out side3)||side1+side2<=side3||side2+side3<=side1||side1+side3<=side2)
                {
                    Console.WriteLine("您输入的数据出现非法字符或不符合三边规则，请重新输入！");
                    continue;
                }
                break;
        }
    }
}