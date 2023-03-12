namespace LoginPanel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 130);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 0;
            label1.Text = "T.C NO:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(110, 130);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(201, 34);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 179);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 2;
            label2.Text = "SİFRE:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 179);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 34);
            textBox1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(585, 112);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(334, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(279, 33);
            label3.TabIndex = 8;
            label3.Text = "Online Ders Giris Paneli";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Location = new Point(0, 330);
            panel2.Name = "panel2";
            panel2.Size = new Size(585, 40);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(177, 219);
            button1.Name = "button1";
            button1.Size = new Size(134, 35);
            button1.TabIndex = 6;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(317, 181);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(186, 32);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Sifremi Unuttum";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 370);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Kullanıcı Giriş Paneli";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private TextBox textBox1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private Panel panel2;
        private Button button1;
        private CheckBox checkBox1;
    }
}