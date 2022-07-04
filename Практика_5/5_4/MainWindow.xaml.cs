using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace z4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForAssembly();
            string color;
            try
            {
                IsolatedStorageFileStream Isfs = new IsolatedStorageFileStream("lbl.cfg", FileMode.Open, FileAccess.Read, FileShare.Read);
                StreamReader sr = new StreamReader(Isfs);
                color = sr.ReadLine();
                lbl.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(color));
                lbl.Content = color;
                sr.Close();
            }
            catch
            {
                lbl.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
                lbl.Content = "#00000000";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Данные сохранены.");
        }

        private void cp_SelectedColorChanged_1(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            IsolatedStorageFileStream IsStorage = new IsolatedStorageFileStream("lbl.cfg", FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(IsStorage);
            lbl.Content = cp.SelectedColor.Value;
            lbl.Background = new SolidColorBrush(cp.SelectedColor.Value);
            sw.WriteLine(lbl.Background.ToString());
            sw.Close();
        }
    }
}
