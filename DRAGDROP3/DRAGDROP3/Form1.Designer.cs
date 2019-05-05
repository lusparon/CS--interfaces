namespace DRAGDROP3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.commandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clear1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clear2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clear3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 0;
            this.label1.Tag = "";
            this.label1.Text = "A";
            this.label1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Label1_DragEnter);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseDown);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 1;
            this.label2.Tag = "";
            this.label2.Text = "C";
            this.label2.DragEnter += new System.Windows.Forms.DragEventHandler(this.Label1_DragEnter);
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseDown);
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 2;
            this.label3.Tag = "";
            this.label3.Text = "T";
            this.label3.DragEnter += new System.Windows.Forms.DragEventHandler(this.Label1_DragEnter);
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseDown);
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 17);
            this.label4.TabIndex = 3;
            this.label4.Tag = "";
            this.label4.Text = "G";
            this.label4.DragEnter += new System.Windows.Forms.DragEventHandler(this.Label1_DragEnter);
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseDown);
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(81, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(440, 23);
            this.label5.TabIndex = 4;
            this.label5.Tag = "";
            this.label5.DragDrop += new System.Windows.Forms.DragEventHandler(this.Label5_DragDrop);
            this.label5.DragEnter += new System.Windows.Forms.DragEventHandler(this.Label5_DragEnter);
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseDown);
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(81, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(440, 23);
            this.label6.TabIndex = 5;
            this.label6.Tag = "";
            this.label6.DragDrop += new System.Windows.Forms.DragEventHandler(this.Label5_DragDrop);
            this.label6.DragEnter += new System.Windows.Forms.DragEventHandler(this.Label5_DragEnter);
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseDown);
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(81, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(440, 23);
            this.label7.TabIndex = 6;
            this.label7.Tag = "";
            this.label7.DragDrop += new System.Windows.Forms.DragEventHandler(this.Label5_DragDrop);
            this.label7.DragEnter += new System.Windows.Forms.DragEventHandler(this.Label5_DragEnter);
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "Command";
            // 
            // commandToolStripMenuItem
            // 
            this.commandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clear1ToolStripMenuItem,
            this.clear2ToolStripMenuItem,
            this.clear3ToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.commandToolStripMenuItem.Name = "commandToolStripMenuItem";
            this.commandToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.commandToolStripMenuItem.Text = "Command";
            // 
            // clear1ToolStripMenuItem
            // 
            this.clear1ToolStripMenuItem.Name = "clear1ToolStripMenuItem";
            this.clear1ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.clear1ToolStripMenuItem.Text = "Clear1";
            this.clear1ToolStripMenuItem.Click += new System.EventHandler(this.Clear1ToolStripMenuItem_Click);
            // 
            // clear2ToolStripMenuItem
            // 
            this.clear2ToolStripMenuItem.Name = "clear2ToolStripMenuItem";
            this.clear2ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.clear2ToolStripMenuItem.Text = "Clear2";
            this.clear2ToolStripMenuItem.Click += new System.EventHandler(this.Clear1ToolStripMenuItem_Click);
            // 
            // clear3ToolStripMenuItem
            // 
            this.clear3ToolStripMenuItem.Name = "clear3ToolStripMenuItem";
            this.clear3ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.clear3ToolStripMenuItem.Text = "Clear3";
            this.clear3ToolStripMenuItem.Click += new System.EventHandler(this.Clear1ToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 437);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem commandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clear1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clear2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clear3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

