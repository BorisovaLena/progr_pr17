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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace pr17.pages
{
    /// <summary>
    /// Логика взаимодействия для PageAuto.xaml
    /// </summary>
    public partial class PageAuto : Page
    {
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        int sec = 10;
        public PageAuto(int index)
        {
            InitializeComponent();
           
            switch (index)
            {
                case 0:
                    break;
                case 1:
                    btnAuto.IsEnabled = false;
                    spNewCode.Visibility = Visibility.Visible;
                    dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
                    dispatcherTimer.Tick += new EventHandler(DisTimer_Tick);
                    dispatcherTimer.Start();
                    break;
                case 2:
                    btnAuto.IsEnabled = false;
                    spNewCode.Visibility = Visibility.Collapsed;
                    WindowCaptcha windowCaptcha = new WindowCaptcha(1);
                    windowCaptcha.Show();
                    break;
                case 3:
                    btnAuto.IsEnabled = false;
                    spNewCode.Visibility = Visibility.Collapsed;
                    WindowCaptcha windowCaptcha2 = new WindowCaptcha(2);
                    windowCaptcha2.Show();
                    break;
            } 
        }
        private void DisTimer_Tick(object sender, EventArgs e)
        {
            sec--;
            tbTimer.Text = "Получить новый код можно будет через "+ sec +" секунд";
            if (sec == 0)
            {
                btnNewCode.Visibility = Visibility.Visible;
                dispatcherTimer.Stop();
            }
           
        }

        private void btnAuto_Click(object sender, RoutedEventArgs e)
        {
            if(tbLogin.Text=="" || tbPassword.Password == "")
            {
                MessageBox.Show("Введите логин и пароль!!!");
            }
            else
            {
                if (tbLogin.Text == "qwert" && tbPassword.Password == "qwert")
                {
                    string str = random();
                    MessageBox.Show(str, "Запомните код");
                    WindowCode windowCode = new WindowCode(str, 1);
                    windowCode.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Логин или пароль введены неправильно!!!");
                }
            }
        }

        public string random()
        {
            Random random = new Random();
            int i1 = random.Next(10);
            int i2 = random.Next(10);
            int i3 = random.Next(10);
            int i4 = random.Next(10);
            int i5 = random.Next(10);
            string str = i1.ToString() + i2.ToString() + i3.ToString() + i4.ToString() + i5.ToString();
            return str;
        }

        private void btnNewCode_Click(object sender, RoutedEventArgs e)
        {
            if (tbLogin.Text == "" || tbPassword.Password == "")
            {
                MessageBox.Show("Введите логин и пароль!!!");
            }
            else
            {
                if (tbLogin.Text == "qwert" && tbPassword.Password == "qwert")
                {
                    string str = random();
                    MessageBox.Show(str, "Запомните код");
                    WindowCode windowCode = new WindowCode(str, 2);
                    windowCode.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Логин или пароль введены неправильно!!!");
                }
            }
        }
    }
}
