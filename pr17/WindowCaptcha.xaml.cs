using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace pr17
{
    /// <summary>
    /// Логика взаимодействия для WindowCaptcha.xaml
    /// </summary>
    public partial class WindowCaptcha : Window
    {
        string str = "";
        int i;
        public WindowCaptcha(int i)
        {
            InitializeComponent();
            this.i = i;
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

            char[] chars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int position;
            char c1 = chars[random.Next(36)];
            TextBlock txt1 = new TextBlock()
            {
                Text = c1.ToString(),
                FontSize = 30,
                Margin = new Thickness(20),

            };
            can.Children.Add(txt1);

            char c2 = chars[random.Next(36)];
            TextBlock txt7 = new TextBlock()
            {
                Text = c2.ToString(),
                FontSize = 30,
                Margin = new Thickness(35, 20, 20, 20)
            };
            can.Children.Add(txt7);

            char c3 = chars[random.Next(36)];
            TextBlock txt2 = new TextBlock()
            {
                Text = c3.ToString(),
                FontSize = 30,
                Margin = new Thickness(50, 20, 20, 20)
            };
            can.Children.Add(txt2);

            char c4 = chars[random.Next(36)];
            TextBlock txt3 = new TextBlock()
            {
                Text = c4.ToString(),
                FontSize = 30,
                Margin = new Thickness(65, 20, 20, 20)
            };
            can.Children.Add(txt3);

            char c5 = chars[random.Next(36)];
            TextBlock txt4 = new TextBlock()
            {
                Text = c5.ToString(),
                FontSize = 30,
                Margin = new Thickness(80, 20, 20, 20)
            };
            can.Children.Add(txt4);

            char c6 = chars[random.Next(36)];
            TextBlock txt5 = new TextBlock()
            {
                Text = c6.ToString(),
                FontSize = 30,
                Margin = new Thickness(95, 20, 20, 20)
            };
            can.Children.Add(txt5);

            char c7 = chars[random.Next(36)];
            TextBlock txt6 = new TextBlock()
            {
                Text = c7.ToString(),
                FontSize = 30,
                Margin = new Thickness(110, 20, 20, 20)
            };
            can.Children.Add(txt6);

            str = c1.ToString() + c2.ToString() + c3.ToString() + c4.ToString() + c5.ToString() + c6.ToString() + c7.ToString();
        }

        private void tbText_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbText.Text.Length == 7)
            {
                if (tbText.Text == str)
                {
                    MessageBox.Show("Успех!!!");
                    ClassFrame.mainFrame.Navigate(new pages.PageRez());
                    Close();
                }
                else
                {
                    if (i == 1)
                    {
                        MessageBox.Show("Попробуйте еще раз!!!");
                        ClassFrame.mainFrame.Navigate(new pages.PageAuto(3));
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Неудачный вход!!!");
                        Close();
                    }
                }
            }

        }
    }
}
