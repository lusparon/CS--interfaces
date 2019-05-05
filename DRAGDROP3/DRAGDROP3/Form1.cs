using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRAGDROP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                DoDragDrop(sender, DragDropEffects.Move);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            //Label src = e.Data.GetData(typeof(Label)) as Label;
            //src.Location = PointToClient(new Point(e.X, e.Y));
        }

        private void Label5_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void Label1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(Label)) == sender)
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Label5_DragDrop(object sender, DragEventArgs e)
        {
            Label src = e.Data.GetData(typeof(Label)) as Label;
            Label trg = sender as Label;//this
            trg.Text = trg.Text + src.Text;
        }

        private void Clear1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char ind = (sender as ToolStripMenuItem).Name[5];
            if (ind == '1')
                label5.Text = "";
            else if (ind == '2')
                label6.Text = "";
            else if (ind == '3')
                label7.Text = "";
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
