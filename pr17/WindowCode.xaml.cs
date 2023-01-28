using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace pr17
{
    /// <summary>
    /// Логика взаимодействия для WindowCode.xaml
    /// </summary>
    public partial class WindowCode : Window
    {
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        string str;
        public WindowCode(string str)
        {
            InitializeComponent();
            this.str = str;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 10);
            dispatcherTimer.Tick += new EventHandler(DisTimer_Tick);
            dispatcherTimer.Start();
        }

        private void DisTimer_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void tbCode_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(tbCode.Text == str)
            {
                MessageBox.Show("Успех!!!");
                Close();
            }
        }
    }
}
