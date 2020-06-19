namespace FTools
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.formSkin1 = new FlatUI.FormSkin();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flatTextBox6 = new FlatUI.FlatTextBox();
            this.flatTextBox5 = new FlatUI.FlatTextBox();
            this.flatTextBox3 = new FlatUI.FlatTextBox();
            this.flatTextBox2 = new FlatUI.FlatTextBox();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.flatButton2 = new FlatUI.FlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flatTextBox1 = new FlatUI.FlatTextBox();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.flatButton1 = new FlatUI.FlatButton();
            this.flatClose1 = new FlatUI.FlatClose();
            this.flatMini1 = new FlatUI.FlatMini();
            this.flatButton3 = new FlatUI.FlatButton();
            this.formSkin1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.panel2);
            this.formSkin1.Controls.Add(this.panel1);
            this.formSkin1.Controls.Add(this.flatClose1);
            this.formSkin1.Controls.Add(this.flatMini1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.Black;
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(670, 425);
            this.formSkin1.TabIndex = 1;
            this.formSkin1.Text = "Block Strike Black Screen Bypass";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.flatButton3);
            this.panel2.Controls.Add(this.flatTextBox6);
            this.panel2.Controls.Add(this.flatTextBox5);
            this.panel2.Controls.Add(this.flatTextBox3);
            this.panel2.Controls.Add(this.flatTextBox2);
            this.panel2.Controls.Add(this.flatLabel2);
            this.panel2.Controls.Add(this.flatButton2);
            this.panel2.Location = new System.Drawing.Point(12, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(646, 191);
            this.panel2.TabIndex = 6;
            // 
            // flatTextBox6
            // 
            this.flatTextBox6.AllowDrop = true;
            this.flatTextBox6.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox6.FocusOnHover = false;
            this.flatTextBox6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTextBox6.Location = new System.Drawing.Point(8, 143);
            this.flatTextBox6.MaxLength = 32767;
            this.flatTextBox6.Multiline = false;
            this.flatTextBox6.Name = "flatTextBox6";
            this.flatTextBox6.ReadOnly = true;
            this.flatTextBox6.Size = new System.Drawing.Size(112, 29);
            this.flatTextBox6.TabIndex = 8;
            this.flatTextBox6.Text = "Your dll:";
            this.flatTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox6.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox6.UseSystemPasswordChar = false;
            // 
            // flatTextBox5
            // 
            this.flatTextBox5.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox5.FocusOnHover = false;
            this.flatTextBox5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTextBox5.Location = new System.Drawing.Point(8, 108);
            this.flatTextBox5.MaxLength = 32767;
            this.flatTextBox5.Multiline = false;
            this.flatTextBox5.Name = "flatTextBox5";
            this.flatTextBox5.ReadOnly = true;
            this.flatTextBox5.Size = new System.Drawing.Size(112, 29);
            this.flatTextBox5.TabIndex = 7;
            this.flatTextBox5.Text = "Original dll:";
            this.flatTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox5.UseSystemPasswordChar = false;
            // 
            // flatTextBox3
            // 
            this.flatTextBox3.AllowDrop = true;
            this.flatTextBox3.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox3.FocusOnHover = false;
            this.flatTextBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTextBox3.Location = new System.Drawing.Point(117, 143);
            this.flatTextBox3.MaxLength = 32767;
            this.flatTextBox3.Multiline = false;
            this.flatTextBox3.Name = "flatTextBox3";
            this.flatTextBox3.ReadOnly = true;
            this.flatTextBox3.Size = new System.Drawing.Size(374, 29);
            this.flatTextBox3.TabIndex = 5;
            this.flatTextBox3.Text = "Drag and drop";
            this.flatTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox3.UseSystemPasswordChar = false;
            this.flatTextBox3.DragDrop += new System.Windows.Forms.DragEventHandler(this.flatTextBox3_DragDrop);
            this.flatTextBox3.DragEnter += new System.Windows.Forms.DragEventHandler(this.flatTextBox3_DragEnter);
            // 
            // flatTextBox2
            // 
            this.flatTextBox2.AllowDrop = true;
            this.flatTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox2.FocusOnHover = false;
            this.flatTextBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTextBox2.Location = new System.Drawing.Point(117, 108);
            this.flatTextBox2.MaxLength = 32767;
            this.flatTextBox2.Multiline = false;
            this.flatTextBox2.Name = "flatTextBox2";
            this.flatTextBox2.ReadOnly = true;
            this.flatTextBox2.Size = new System.Drawing.Size(374, 29);
            this.flatTextBox2.TabIndex = 3;
            this.flatTextBox2.Text = "Drag and drop";
            this.flatTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox2.UseSystemPasswordChar = false;
            this.flatTextBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.flatTextBox2_DragDrop);
            this.flatTextBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.flatTextBox2_DragEnter);
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(114, 19);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(378, 47);
            this.flatLabel2.TabIndex = 4;
            this.flatLabel2.Text = "Bypass for All Version";
            this.flatLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.Black;
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton2.Location = new System.Drawing.Point(497, 108);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Rounded = false;
            this.flatButton2.Size = new System.Drawing.Size(137, 29);
            this.flatButton2.TabIndex = 2;
            this.flatButton2.Text = "Add Byte";
            this.flatButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton2.Click += new System.EventHandler(this.flatButton2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.flatTextBox1);
            this.panel1.Controls.Add(this.flatLabel1);
            this.panel1.Controls.Add(this.flatButton1);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 157);
            this.panel1.TabIndex = 5;
            // 
            // flatTextBox1
            // 
            this.flatTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox1.FocusOnHover = false;
            this.flatTextBox1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.flatTextBox1.Location = new System.Drawing.Point(7, 86);
            this.flatTextBox1.MaxLength = 32767;
            this.flatTextBox1.Multiline = false;
            this.flatTextBox1.Name = "flatTextBox1";
            this.flatTextBox1.ReadOnly = false;
            this.flatTextBox1.Size = new System.Drawing.Size(518, 35);
            this.flatTextBox1.TabIndex = 3;
            this.flatTextBox1.Text = "Key";
            this.flatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox1.UseSystemPasswordChar = false;
            // 
            // flatLabel1
            // 
            this.flatLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(114, 23);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(383, 46);
            this.flatLabel1.TabIndex = 4;
            this.flatLabel1.Text = "Bypass for 3.0.0 - 5.0.0";
            this.flatLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.Black;
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(531, 86);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(106, 35);
            this.flatButton1.TabIndex = 2;
            this.flatButton1.Text = "Open";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(640, 12);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 1;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(603, 12);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 0;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatButton3
            // 
            this.flatButton3.BackColor = System.Drawing.Color.Transparent;
            this.flatButton3.BaseColor = System.Drawing.Color.Black;
            this.flatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.flatButton3.Location = new System.Drawing.Point(497, 143);
            this.flatButton3.Name = "flatButton3";
            this.flatButton3.Rounded = false;
            this.flatButton3.Size = new System.Drawing.Size(137, 29);
            this.flatButton3.TabIndex = 10;
            this.flatButton3.Text = "Calculate";
            this.flatButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton3.Click += new System.EventHandler(this.flatButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 425);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.formSkin1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private FlatUI.FormSkin formSkin1;
        private System.Windows.Forms.Panel panel1;
        private FlatUI.FlatTextBox flatTextBox1;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatButton flatButton1;
        private FlatUI.FlatClose flatClose1;
        private FlatUI.FlatMini flatMini1;
        private System.Windows.Forms.Panel panel2;
        private FlatUI.FlatTextBox flatTextBox6;
        private FlatUI.FlatTextBox flatTextBox5;
        private FlatUI.FlatTextBox flatTextBox3;
        private FlatUI.FlatTextBox flatTextBox2;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatButton flatButton2;
        private FlatUI.FlatButton flatButton3;
    }
}

