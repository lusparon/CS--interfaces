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

namespace SYNC10WPF
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public bool isClicked = false;
        public Window1()
        {
            InitializeComponent();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            isClicked = !isClicked;
            if (isClicked)
                button1.Content = "Возобновить синхронизацию";
            else
            {
                button1.Content = "Остановить синхронизацию";
                for (var i = 1; i <= 7; i++)
                    (FindName("textBox" + i) as TextBox).Text = (Owner.FindName("textBox" + i) as TextBox).Text;
            }
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                button1_Click(sender, e);
            if (e.Key == Key.Escape)
                Close();
        }
    }
}
