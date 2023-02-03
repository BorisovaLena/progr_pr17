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

namespace pr17
{
    /// <summary>
    /// Логика взаимодействия для WindowCaptcha.xaml
    /// </summary>
    public partial class WindowCaptcha : Window
    {
        public WindowCaptcha()
        {
            InitializeComponent();

            Random random = new Random();
            Line l1 = new Line()
            {
                X1 = random.Next(201),
                Y1 = random.Next(101),
                X2 = random.Next(201),
                Y2 = random.Next(101),
                Stroke = Brushes.Black
            };
            can.Children.Add(l1);

            Line l2 = new Line()
            {
                X1 = random.Next(201),
                Y1 = random.Next(101),
                X2 = random.Next(201),
                Y2 = random.Next(101),
                Stroke = Brushes.Black
            };
            can.Children.Add(l2);

            Line l3 = new Line()
            {
                X1 = random.Next(201),
                Y1 = random.Next(101),
                X2 = random.Next(201),
                Y2 = random.Next(101),
                Stroke = Brushes.Black
            };
            can.Children.Add(l3);

            Line l4 = new Line()
            {
                X1 = random.Next(201),
                Y1 = random.Next(101),
                X2 = random.Next(201),
                Y2 = random.Next(101),
                Stroke = Brushes.Black
            };
            can.Children.Add(l4);

            Line l5 = new Line()
            {
                X1 = random.Next(201),
                Y1 = random.Next(101),
                X2 = random.Next(201),
                Y2 = random.Next(101),
                Stroke = Brushes.Black
            };
            can.Children.Add(l5);

            char[] chars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9','a', 'b', 'c', 'd', 'e', 'f', 'g', 'h','i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            int position;
            TextBlock txt1 = new TextBlock()
            {
                Text = chars[random.Next(36)].ToString(),
                FontSize = 30,
                Margin = new Thickness(20),
                
            };
            can.Children.Add(txt1);

            TextBlock txt7 = new TextBlock()
            {
                Text = chars[random.Next(36)].ToString(),
                FontSize = 30,
                Margin = new Thickness(35,20,20,20)
            };
            can.Children.Add(txt7);

            TextBlock txt2 = new TextBlock()
            {
                Text = chars[random.Next(36)].ToString(),
                FontSize = 30,
                Margin = new Thickness(50, 20, 20, 20)
            };
            can.Children.Add(txt2);

            TextBlock txt3 = new TextBlock()
            {
                Text = chars[random.Next(36)].ToString(),
                FontSize = 30,
                Margin = new Thickness(65, 20, 20, 20)
            };
            can.Children.Add(txt3);

            TextBlock txt4 = new TextBlock()
            {
                Text = chars[random.Next(36)].ToString(),
                FontSize = 30,
                Margin = new Thickness(80, 20, 20, 20)
            };
            can.Children.Add(txt4);

            TextBlock txt5 = new TextBlock()
            {
                Text = chars[random.Next(36)].ToString(),
                FontSize = 30,
                Margin = new Thickness(95, 20, 20, 20)
            };
            can.Children.Add(txt5);

            TextBlock txt6 = new TextBlock()
            {
                Text = chars[random.Next(36)].ToString(),
                FontSize = 30,
                Margin = new Thickness(110, 20, 20, 20)
            };
            can.Children.Add(txt6);
        }
    }
}
