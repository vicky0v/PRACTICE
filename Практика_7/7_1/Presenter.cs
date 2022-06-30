using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Presenter
    {
        private Model model = null;
        private MainWindow mainWin = null;

        void timer_Tick(object sender, System.EventArgs e)
        {
            mainWin.tb1.Text = model.nowTime;
        }
        public Presenter(MainWindow mainWin)
        {
            this.mainWin = mainWin;
            this.model = new Model();

            this.mainWin.Start += new EventHandler(mwStart);
            this.mainWin.Stop += new EventHandler(mwStop);
            this.mainWin.Reset += new EventHandler(mwReset);

            model.dispatcherTimer.Tick += timer_Tick;
        }

        void mwStart(object sender, System.EventArgs e)
        {
            model.StartTimer();
        }
        void mwStop(object sender, System.EventArgs e)
        {
            model.StopTimer();
        }
        void mwReset(object sender, System.EventArgs e)
        {
            model.ResetTimer();
        }


    }
}
