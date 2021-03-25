using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_02
{
    public delegate void EventHandler(object sender, EventArgs e);
    public class EventArgs
    {
        public int Hour { get; set; }       
        public int Minute { get; set; }     
        public int Second { get; set; }     
    }
    public class Clock
    {
        public event EventHandler Tick;
        public event EventHandler Alarm;
        private int hour, minute, second, aHour, aMinute, aSecond;
        public Clock(int hour, int minute)  //构造函数设置时间
        {
            if (hour < 60 && minute < 60)
            {
                this.hour = hour;
                this.minute = minute;
                this.second = 0;
            }
            else
                this.hour = this.minute = this.second = 0;
        }
        public void SetClock(int hour, int minute)  //设置闹钟时间
        {
            aHour = hour;
            aMinute = minute;
        }
        public void Run()
        {
            while (true)
            {
                if (this.second < 59) this.second++;
                else
                {
                    this.second = 0;
                    this.minute++;
                    if (this.minute == 60)
                    {
                        this.minute = 0;
                        this.hour = (this.hour + 1) % 24;
                    }
                }
                EventArgs CurrentTime = new EventArgs() { Hour = hour, Minute = minute, Second = second };
                if (this.hour == this.aHour && this.minute == this.aMinute && this.second == this.aSecond)
                {
                    Alarm(this, CurrentTime);
                }
                else
                {
                    Tick(this, CurrentTime);
                }
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
    public class MyClock
    {
        public Clock myClock;
        void Tick(object sender, EventArgs args)
        {
            Console.WriteLine("Tick!：[" + args.Hour + ":" + args.Minute + ":" + args.Second + "]");
        }
        void Alarm(object sender, EventArgs args)
        {
            Console.WriteLine("Alarm!：[" + args.Hour + ":" + args.Minute + ":" + args.Second + "]");
        }
        public MyClock(int hour, int minute)
        {
            myClock = new Clock(hour, minute);
            myClock.Tick += Tick;
            myClock.Alarm += Alarm;
        }

    }
    class Test
    {
        static void Main()
        {
            MyClock myClock = new MyClock(0, 00);   //设置时间
            myClock.myClock.SetClock(0, 01);     //设置闹钟；
            myClock.myClock.Run();
        }
        
    }
}