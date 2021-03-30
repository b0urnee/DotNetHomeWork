using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    class Factory
    {
        public static Shape CreateFunction(string name)
        {
            switch (name)
            {
                case "1": return new Square();
                case "2": return new Rectangle();
                case "3": return new Triangle();
                default:
                    Console.WriteLine("系统找不到您选择的形状！");
                    Console.ReadKey();
                    return null;
            }
        }
    }
}
