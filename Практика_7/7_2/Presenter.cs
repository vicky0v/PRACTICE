using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace z2
{
    class Presenter
    {

        private readonly Model model;
        private readonly MainWindow view;

        public Presenter(MainWindow mainWin)
        {
            model = new Model();
            view = mainWin;
            view.Equal += AreEqual;

        }

        void AreEqual(object sender, EventArgs e)
        {
            try
            {
                model.label1 = Convert.ToString(view.lbl1.Content);
                double a = Convert.ToDouble(view.tb1.Text);
                double b = Convert.ToDouble(view.tb2.Text);
                view.tb3.Text = model.Equal(a, b).ToString();
                view.lbl2.Content = "=".ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
