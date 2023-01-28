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

namespace pr17.pages
{
    /// <summary>
    /// Логика взаимодействия для PageAuto.xaml
    /// </summary>
    public partial class PageAuto : Page
    {
        public PageAuto()
        {
            InitializeComponent();
        }

        private void btnAuto_Click(object sender, RoutedEventArgs e)
        {
            if (tbLogin.Text == "qwert" && tbPassword.Password == "qwert")
            {
                Random random = new Random();
                int i1 = random.Next(10);
                int i2 = random.Next(10);
                int i3 = random.Next(10);
                int i4 = random.Next(10);
                int i5 = random.Next(10);
                string str = i1.ToString() + i2.ToString() + i3.ToString() + i4.ToString() + i5.ToString();
                MessageBox.Show(str, "Запомните код");
                WindowCode windowCode = new WindowCode(str);
                windowCode.ShowDialog();
            }
            else
            {
                MessageBox.Show("Логин или пароль введены неправильно!!!");
            }
        }
    }
}
