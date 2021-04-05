using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock c = new Clock();
            Thread th1 = new Thread(c.getTime);
            Thread th2 = new Thread(c.getAlarm);
            th1.Start();
            th2.Start();
            //每过1秒嘀嗒一次，5秒响铃一次

            Console.ReadKey();
        }
    }
}
