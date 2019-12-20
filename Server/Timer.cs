using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Server
{
    public class Timer
    {
        private int time;
        public int Time
        {
            get { return time; }
        }
        private int iteration;
        public int Iteration
        {
            get { return iteration; }
            set { iteration = value; }
        }
        Thread timer;
        public Timer()
        {
            iteration = 20;
            time = 0;
            timer = new Thread(new ThreadStart(StartTimer));
            timer.Start();
        }

        public void StartTimer()
        {
            while(true)
            {
                time += iteration;
                Thread.Sleep(1000);
                if (time >= 24 * 60 - iteration)
                    time = 0;
            }
        }

        public int AnswerTimer()
        {
            return time;
        }
    }
}
