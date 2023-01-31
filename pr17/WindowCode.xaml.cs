using System;
using System.Windows;
using System.Windows.Controls;
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
        int index;
        public WindowCode(string str, int index)
        {
            InitializeComponent();
            this.str = str;
            this.index = index;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 10);
            dispatcherTimer.Tick += new EventHandler(DisTimer_Tick);
            dispatcherTimer.Start();
        }

        private void DisTimer_Tick(object sender, EventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new pages.PageAuto(index));
            Close();
        }

        private void tbCode_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbCode.Text.Length == 5)
            {
                if (tbCode.Text == str)
                {
                    dispatcherTimer.Stop();
                    MessageBox.Show("Успех!!!");
                    ClassFrame.mainFrame.Navigate(new pages.PageRez());
                    Close();
                }
                else
                {
                    dispatcherTimer.Stop();
                    MessageBox.Show("Код введен неверно!!!");
                    ClassFrame.mainFrame.Navigate(new pages.PageAuto(index));
                    Close();
                }
            }
        }
    }
}
