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
            for(int n =0;n<5;n++)
            {
                SolidColorBrush Brush = new SolidColorBrush(Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256)));
                Line l1 = new Line()
                {
                    X1 = random.Next(301),
                    Y1 = random.Next(101),
                    X2 = random.Next(301),
                    Y2 = random.Next(101),
                    Stroke = Brush
                };
                can.Children.Add(l1);
            }

            char[] chars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int kolSinb = random.Next(7,10);

            int margin = 25;
            for(int n=0; n< kolSinb; n++)
            {
                int position = random.Next(3);
                char c1 = chars[random.Next(36)];
                switch (position)
                {
                    case 0:
                        TextBlock txt1 = new TextBlock()
                        {
                            Text = c1.ToString(),
                            FontSize = 30,
                            Margin = new Thickness(margin, random.Next(65), 0, 0),
                            FontStyle = FontStyles.Italic
                        };
                        can.Children.Add(txt1);
                        margin += 25;
                        break;
                    case 1:
                        TextBlock txt2 = new TextBlock()
                        {
                            Text = c1.ToString(),
                            FontSize = 30,
                            Margin = new Thickness(margin, random.Next(65), 0, 0),
                            FontWeight = FontWeights.Bold
                        };
                        can.Children.Add(txt2);
                        margin += 25;
                        break;
                    case 2:
                        TextBlock txt3 = new TextBlock()
                        {
                            Text = c1.ToString(),
                            FontSize = 30,
                            Margin = new Thickness(margin, random.Next(65), 0, 0),
                            FontStyle = FontStyles.Italic,
                            FontWeight = FontWeights.Bold
                        };
                        can.Children.Add(txt3);
                        margin += 25;
                        break;
                }
                str += c1.ToString();
            }

            //char c5 = chars[random.Next(36)];
            //TextBlock txt4 = new TextBlock()
            //{
            //    Text = c5.ToString(),
            //    FontSize = 30,
            //    Margin = new Thickness(100, random.Next(65), 0, 0)
            //};
            //can.Children.Add(txt4);

            //char c6 = chars[random.Next(36)];
            //TextBlock txt5 = new TextBlock()
            //{
            //    Text = c6.ToString(),
            //    FontSize = 30,
            //    Margin = new Thickness(120, random.Next(65), 0, 0)
            //};
            //can.Children.Add(txt5);

            //char c7 = chars[random.Next(36)];
            //TextBlock txt6 = new TextBlock()
            //{
            //    Text = c7.ToString(),
            //    FontSize = 30,
            //    Margin = new Thickness(140, random.Next(65), 0, 0)
            //};
            //can.Children.Add(txt6);


        }

        private void tbText_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbText.Text.Length == str.Length)
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
