using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Server
{
    public class Timer
    {
        private int time;
        Thread timer;
        public Timer()
        {
            time = 0;
            timer = new Thread(new ThreadStart(StartTimer));
            timer.Start();
        }

        public void StartTimer()
        {
            while(true)
            {
                time += 20;
                Thread.Sleep(1000); //1 second = 1 minute
                if (time >= 24 * 60 - 20)
                    time = 0;
            }
        }

        public int AnswerTimer()
        {
            return time;
        }
    }
}
