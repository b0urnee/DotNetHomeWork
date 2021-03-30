using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    class main
    {
        static void Main(string[] args)
        {
            //输入
            Console.WriteLine("请选择您要计算的形状，如下：");
            Console.WriteLine("1、正方形 2、长方形 3、三角形");
            string name = Console.ReadLine();
            Shape shape = Factory.CreateFunction(name);
            if (shape != null)
            {
                Console.WriteLine("面积为：{0}\r\n周长为：{1}", shape.Area());
            }
            Console.Write("系统找不到指定的形状，按任意键结束……");
            Console.ReadKey();
        }
    }
}
