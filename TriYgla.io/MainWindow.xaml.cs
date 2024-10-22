using System;
using System.Windows;

namespace TriangleApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void E_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(SideA.Text);
                double b = double.Parse(SideB.Text);
                double c = double.Parse(SideC.Text);

                string result;

                if (a + b <= c || a + c <= b || b + c <= a)
                {
                    result = "Сорри, но ты ошибся нулем.";
                }
                else if (a == b && b == c)
                {
                    result = "The triangle is РАВНОСТОРОННИЙ.";
                }
                else if (a == b || b == c || a == c)
                {
                    result = "The triangle is РАВНОБЕДРЕННЫЙ.";
                }
                else
                {
                    result = "The triangle is scalene.";
                }
                ResultWindow resultWindow = new ResultWindow();
                resultWindow.ResultTextBlock.Text = result;
                resultWindow.ShowDialog();
            }
            catch (Exception)
            {
                ResultWindow resultWindow = new ResultWindow();
                resultWindow.ResultTextBlock.Text = "Что-то не так, проверь бро";
                resultWindow.ShowDialog();
            }

        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
