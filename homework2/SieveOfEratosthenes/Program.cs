using System;

namespace SieveOfEratosthenes
{
    class Program
    {
        /*用“埃氏筛法”求2~ 100以内的素数。
          2~ 100以内的数，先去掉2的倍数，再去掉3的倍数，
          再去掉4的倍数，以此类推...最后剩下的就是素数*/
        static void Main(string[] args)
        {
            int[] num = new int[101];   //用i表示数，数组元素标志是否是素数
            for (int i = 0; i <= 100; i++)
                num[i] = 1;
            for(int i=2;i*i<=100;i++)    //将素数的倍数标记为0
                if(num[i]==1)
                {
                    for (int j = 2; i * j <= 100; j++)
                        num[i * j] = 0;
                }
            Console.WriteLine("2~100的素数为：");
            for (int i = 2; i <= 100; i++)
                if (num[i] == 1)
                    Console.Write($"{i} ");
        }
    }
}
