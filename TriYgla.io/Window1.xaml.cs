using System.Windows;

namespace TriangleApp
{
    public partial class ResultWindow : Window
    {
        public ResultWindow()
        {
            InitializeComponent();
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
