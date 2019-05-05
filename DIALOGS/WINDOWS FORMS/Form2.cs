using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIALOGS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(textBox1.Text);
                if (i >= 10 && i <= 300)
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                }
            }
            catch
            {
                textBox1.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double k = int.Parse(textBox1.Text) * 0.01;
            int nw = Convert.ToInt32(818*k);
            int nh = Convert.ToInt32(497 * k);
            Owner.Size = new Size (nw,nh);
            int nw1 = Convert.ToInt32(221*k);
            int nh1 = Convert.ToInt32(23*k);
            Owner.Controls["button1"].Size = new Size(nw1, nh1);
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    button1_Click(sender, e);
                else if (e.KeyChar == (char)Keys.Escape)
                    button3_Click(sender,e);
                return;
            }

            e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double k = int.Parse(textBox1.Text) * 0.01;
            int nw = Convert.ToInt32(818 * k);
            int nh = Convert.ToInt32(497 * k);
            Owner.Size = new Size(nw, nh);
            int nw1 = Convert.ToInt32(221 * k);
            int nh1 = Convert.ToInt32(23 * k);
            Owner.Controls["button1"].Size = new Size(nw1, nh1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
