using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace z1
{
    class Model
    {
        public DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public Stopwatch stopwatch = new Stopwatch();


        private void TimerF(object sender, System.EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                TimeSpan ts = stopwatch.Elapsed;
                nowTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            }
        }
        public Model()
        {
            dispatcherTimer.Tick += new EventHandler(TimerF);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);
        }

        public void StartTimer()
        {
            stopwatch.Start();
            dispatcherTimer.Start();
        }
        public void StopTimer()
        {
            if (stopwatch.IsRunning)
                stopwatch.Stop();
        }

        public string nowTime = string.Empty;
        public void ResetTimer()
        {
            stopwatch.Reset();
            nowTime = "00:00:00";
        }
    }
}
