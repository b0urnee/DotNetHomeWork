using System;

namespace console_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            double operand1, operand2;
            string op;
            Console.Write("请输入数字1：");
            operand1 = double.Parse(Console.ReadLine());
            Console.Write("请输入数字2：");
            operand2 = double.Parse(Console.ReadLine());
            Console.Write("请输入操作符：");
            op = Console.ReadLine();
            if (op == "+") Console.WriteLine($"{operand1} {op} {operand2} = {operand1 + operand2}");
            if (op == "-") Console.WriteLine($"{operand1} {op} {operand2} = {operand1 - operand2}");
            if (op == "*") Console.WriteLine($"{operand1} {op} {operand2} = {operand1 * operand2}");
            if (op == "/") Console.WriteLine($"{operand1} {op} {operand2} = {operand1 / operand2}");
        }
    }
}
