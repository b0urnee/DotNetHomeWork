using System;

namespace PrintPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= num;)
            {
                if (num % i == 0)
                {
                    Console.Write(i + " ");
                    num /= i;
                }
                else i++;
            }
        }
    }
}
