using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Clock
{
    public delegate void EventHandler(object sender, Time t);
    public class Time
    {
        public int hour { get; set; }
        public int minute { get; set; }
        public int second { get; set; }
        
        public Time(int h, int m, int s)
        {
            this.hour = h;
            this.minute = m;
            this.second = s;
        }
    }
    public class alarmClock
    {
        public event EventHandler Tick;
        public event EventHandler Alarm;
        public void AlarmTrigger(Time t)
        {
            Tick(this, t);
            Alarm(this, t);
        }
    }

    class Clock
    {
        public alarmClock a = new alarmClock();
        public int hour = 0;
        public int minute = 0;
        public int second = 0;
        public Clock()//为事件添加处理方法必须放在构造函数中
        {
            a.Tick += TickEvent;
            a.Alarm += AlarmEvent;
        }


        void TickEvent(object sender, Time t)
        {
            Console.WriteLine("当前时间为：" + t.hour + ":" + t.minute + ":" + t.second);
        }
        void AlarmEvent(object sender, Time t)
        {
            Console.WriteLine("时间到了！");
        }
        public void getTime()
        {
            while (true)
            {
                var currentTime = System.DateTime.Now;

                hour = currentTime.Hour;
                minute = currentTime.Minute;
                second = currentTime.Second;

                TickEvent(this, new Time(hour, minute, second));
                Console.WriteLine("嘀嗒");
                Thread.Sleep(1000);
                Console.Clear();
            }

        }
        public void getAlarm()
        {
            while (true)
            {
                Console.WriteLine("响铃！！");
                Thread.Sleep(1000 * 5);
            }
        }
    }
}
