namespace Gestion__etudetion
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            button4 = new Button();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 10);
            label1.Name = "label1";
            label1.Size = new Size(220, 15);
            label1.TabIndex = 0;
            label1.Text = "                                       Gestion-etudetion";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(224, 202);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information de etudion";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "TSDI", "TSSR", "TSDM" });
            comboBox1.Location = new Point(64, 113);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(101, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(64, 51);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(101, 23);
            textBox4.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(64, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(101, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(101, 23);
            textBox1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 117);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 3;
            label5.Text = "Félair : ";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 87);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 2;
            label4.Text = "Prénom : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 54);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 1;
            label3.Text = "Nom : ";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 25);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 0;
            label2.Text = "Numéro :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(267, 274);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 7;
            label10.Text = "Somme : ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(267, 315);
            label11.Name = "label11";
            label11.Size = new Size(59, 15);
            label11.TabIndex = 8;
            label11.Text = "Moyeen : ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(267, 351);
            label12.Name = "label12";
            label12.Size = new Size(61, 15);
            label12.TabIndex = 9;
            label12.Text = "Decision : ";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(351, 266);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(83, 25);
            textBox5.TabIndex = 9;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox6.ForeColor = Color.Red;
            textBox6.Location = new Point(351, 343);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(83, 23);
            textBox6.TabIndex = 10;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox7.ForeColor = Color.Red;
            textBox7.Location = new Point(351, 300);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(83, 25);
            textBox7.TabIndex = 11;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(359, 45);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Ajouté";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(359, 74);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Calcule";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(359, 103);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 15;
            button3.Text = "Nouveau";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "liste des notes" });
            listBox1.Location = new Point(3, 14);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(215, 154);
            listBox1.TabIndex = 16;
            // 
            // button4
            // 
            button4.Location = new Point(359, 133);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 17;
            button4.Text = "Fermier";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox1);
            groupBox2.Location = new Point(12, 250);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(224, 172);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 434);
            Controls.Add(groupBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
        private Button button4;
        private ComboBox comboBox1;
        private GroupBox groupBox2;
    }
}
