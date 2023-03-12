namespace WinFormsApp1
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            label5 = new Label();
            comboBox1 = new ComboBox();
            button3 = new Button();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            button4 = new Button();
            textBox3 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label6 = new Label();
            label7 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            listBox2 = new ListBox();
            button5 = new Button();
            dateTimePicker1 = new DateTimePicker();
            listBox3 = new ListBox();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            groupBox1 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 79);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(125, 30);
            button1.TabIndex = 0;
            button1.Text = "Label Deneme";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(36, 18);
            label1.TabIndex = 1;
            label1.Text = "AD: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(63, 18);
            label2.TabIndex = 2;
            label2.Text = "SOYAD:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(82, 32);
            label3.Name = "label3";
            label3.Size = new Size(24, 18);
            label3.TabIndex = 3;
            label3.Text = "00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(82, 52);
            label4.Name = "label4";
            label4.Size = new Size(24, 18);
            label4.TabIndex = 4;
            label4.Text = "00";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(174, 22);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 25);
            textBox1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(174, 60);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(150, 39);
            button2.TabIndex = 6;
            button2.Text = "Textbox Deneme";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(300, 22);
            label5.Name = "label5";
            label5.Size = new Size(24, 18);
            label5.TabIndex = 7;
            label5.Text = "00";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ahmet", "Mehmet", "Ayşe", "Fatma" });
            comboBox1.Location = new Point(12, 218);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 26);
            comboBox1.TabIndex = 8;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(12, 252);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(153, 42);
            button3.TabIndex = 9;
            button3.Text = "Combobox Deneme";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(12, 185);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 25);
            textBox2.TabIndex = 10;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Kırklareli", "Babaeski", "Manisa" });
            listBox1.Location = new Point(174, 106);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 104);
            listBox1.TabIndex = 11;
            // 
            // button4
            // 
            button4.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(174, 247);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(131, 44);
            button4.TabIndex = 12;
            button4.Text = "Listbox Deneme";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(174, 217);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 25);
            textBox3.TabIndex = 13;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(428, 27);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 14;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(366, 32);
            label6.Name = "label6";
            label6.Size = new Size(33, 18);
            label6.TabIndex = 15;
            label6.Text = "TC:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(366, 65);
            label7.Name = "label7";
            label7.Size = new Size(56, 18);
            label7.TabIndex = 17;
            label7.Text = "TARİH:";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(428, 60);
            maskedTextBox2.Mask = "00/00/0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(125, 27);
            maskedTextBox2.TabIndex = 16;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(575, 5);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(184, 104);
            listBox2.TabIndex = 18;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // button5
            // 
            button5.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(765, 19);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(131, 44);
            button5.TabIndex = 19;
            button5.Text = "M.TEXT Deneme";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(425, 152);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 20;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 20;
            listBox3.Location = new Point(428, 185);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(184, 104);
            listBox3.TabIndex = 21;
            // 
            // button6
            // 
            button6.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(618, 191);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(131, 44);
            button6.TabIndex = 22;
            button6.Text = "D.T.Picker Deneme";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dd;
            pictureBox1.Location = new Point(12, 323);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 30);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(13, 26);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(77, 24);
            checkBox1.TabIndex = 24;
            checkBox1.Text = "Ketçap";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(12, 373);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Soslar";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(13, 86);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(76, 24);
            checkBox3.TabIndex = 26;
            checkBox3.Text = "Hardal";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(13, 56);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(91, 24);
            checkBox2.TabIndex = 26;
            checkBox2.Text = "Mayonez";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(23, 25);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(68, 24);
            radioButton1.TabIndex = 26;
            radioButton1.TabStop = true;
            radioButton1.Text = "Kadın";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(23, 55);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(65, 24);
            radioButton2.TabIndex = 27;
            radioButton2.TabStop = true;
            radioButton2.Text = "Erkek";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 128);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(radioButton2);
            panel1.Location = new Point(286, 373);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 28;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(620, 364);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(125, 120);
            richTextBox1.TabIndex = 29;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(986, 520);
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button6);
            Controls.Add(listBox3);
            Controls.Add(dateTimePicker1);
            Controls.Add(button5);
            Controls.Add(listBox2);
            Controls.Add(label7);
            Controls.Add(maskedTextBox2);
            Controls.Add(label6);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(listBox1);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "İlk Kod";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Button button2;
        private Label label5;
        private ComboBox comboBox1;
        private Button button3;
        private TextBox textBox2;
        private ListBox listBox1;
        private Button button4;
        private TextBox textBox3;
        private MaskedTextBox maskedTextBox1;
        private Label label6;
        private Label label7;
        private MaskedTextBox maskedTextBox2;
        private ListBox listBox2;
        private Button button5;
        private DateTimePicker dateTimePicker1;
        private ListBox listBox3;
        private Button button6;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Panel panel1;
        private RichTextBox richTextBox1;
    }
}