namespace döngüler
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
            groupBox1 = new GroupBox();
            o1 = new Button();
            groupBox2 = new GroupBox();
            button1 = new Button();
            txt_02 = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            label2 = new Label();
            sayi_1 = new TextBox();
            sayi_2 = new TextBox();
            label3 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(o1);
            groupBox1.Location = new Point(21, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // o1
            // 
            o1.Location = new Point(72, 58);
            o1.Name = "o1";
            o1.Size = new Size(94, 29);
            o1.TabIndex = 0;
            o1.Text = "for";
            o1.UseVisualStyleBackColor = true;
            o1.Click += o1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(txt_02);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(21, 200);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // button1
            // 
            button1.Location = new Point(105, 87);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_02
            // 
            txt_02.Location = new Point(93, 43);
            txt_02.Name = "txt_02";
            txt_02.Size = new Size(125, 27);
            txt_02.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 43);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "sayı gir";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(sayi_2);
            groupBox3.Controls.Add(sayi_1);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(419, 31);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(314, 197);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 47);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 0;
            label2.Text = "sayi1";
            // 
            // sayi_1
            // 
            sayi_1.Location = new Point(130, 50);
            sayi_1.Name = "sayi_1";
            sayi_1.Size = new Size(125, 27);
            sayi_1.TabIndex = 1;
            // 
            // sayi_2
            // 
            sayi_2.Location = new Point(139, 109);
            sayi_2.Name = "sayi_2";
            sayi_2.Size = new Size(125, 27);
            sayi_2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 106);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 3;
            label3.Text = "sayi2";
            // 
            // button2
            // 
            button2.Location = new Point(141, 161);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "toplam";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button o1;
        private GroupBox groupBox2;
        private Label label1;
        private Button button1;
        private TextBox txt_02;
        private GroupBox groupBox3;
        private Button button2;
        private Label label3;
        private TextBox sayi_2;
        private TextBox sayi_1;
        private Label label2;
    }
}
