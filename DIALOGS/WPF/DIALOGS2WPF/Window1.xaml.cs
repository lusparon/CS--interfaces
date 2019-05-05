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
using System.Text.RegularExpressions;

namespace DIALOGS2WPF
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var p = Double.Parse(textBox1.Text);
                Owner.Height = 300 * (p / 100);
                Owner.Width = 600 * (p / 100);
                (Owner.FindName("button1") as Button).Height = 40 * (p / 100);
                (Owner.FindName("button1") as Button).Width = 200 * (p / 100);
            }
            catch (InvalidCastException ex)
            {
                ex.ToString();
            }
        }

        private void textBox1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                if (Convert.ToInt32(textBox1.Text) < 10 || Convert.ToInt32(textBox1.Text) > 300)
                {
                    button1.IsEnabled = false;
                    button2.IsEnabled = false;
                }
                else if (button1 != null)
                {
                    button1.IsEnabled = true;
                    button2.IsEnabled = true;
                }
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var p = Double.Parse(textBox1.Text);
                Owner.Height = 300 * (p / 100);
                Owner.Width = 600 * (p / 100);
                (Owner.FindName("button1") as Button).Height = 40 * (p / 100);
                (Owner.FindName("button1") as Button).Width = 200 * (p / 100);
            }
            catch (InvalidCastException ex)
            {
                ex.ToString();
            }
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                Close();
            if (e.Key == Key.Enter)
                button1_Click(sender, e);
        }
    }
}
