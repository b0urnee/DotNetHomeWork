using System;

namespace ArrayFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[81];
            int num, sum = 0;
            Console.Write("请输入数组长度：");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());
            int max = a[0], min = a[0];
            for (int i = 0; i < num; i++)
            {
                if (max <= a[i])
                    max = a[i];
                if (min >= a[i])
                    min = a[i];
                sum += a[i];
            }
            for (int i = 0; i < num; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine("\n最大值：{0}", max);
            Console.WriteLine("最小值：{0}", min);
            Console.WriteLine("和：{0}", sum);
            Console.WriteLine("平均值：{0}", sum / num);
            Console.ReadKey();
        }
    }
}
