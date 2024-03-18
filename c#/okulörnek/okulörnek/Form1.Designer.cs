namespace okulörnek
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
            label3 = new Label();
            txt_o3 = new TextBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txt_o2 = new TextBox();
            txt_o1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_o3);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txt_o2);
            groupBox1.Controls.Add(txt_o1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(252, 223);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "hesap makinesi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 177);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 10;
            label3.Text = "sonuç";
            // 
            // txt_o3
            // 
            txt_o3.Location = new Point(82, 174);
            txt_o3.Name = "txt_o3";
            txt_o3.Size = new Size(125, 27);
            txt_o3.TabIndex = 9;
            // 
            // button5
            // 
            button5.Location = new Point(202, 112);
            button5.Name = "button5";
            button5.Size = new Size(43, 31);
            button5.TabIndex = 8;
            button5.Text = "%";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(153, 112);
            button4.Name = "button4";
            button4.Size = new Size(43, 31);
            button4.TabIndex = 7;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(104, 112);
            button3.Name = "button3";
            button3.Size = new Size(43, 31);
            button3.TabIndex = 6;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(55, 112);
            button2.Name = "button2";
            button2.Size = new Size(43, 31);
            button2.TabIndex = 5;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 112);
            button1.Name = "button1";
            button1.Size = new Size(43, 31);
            button1.TabIndex = 4;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_o2
            // 
            txt_o2.Location = new Point(82, 71);
            txt_o2.Name = "txt_o2";
            txt_o2.Size = new Size(125, 27);
            txt_o2.TabIndex = 3;
            // 
            // txt_o1
            // 
            txt_o1.Location = new Point(82, 34);
            txt_o1.Name = "txt_o1";
            txt_o1.Size = new Size(125, 27);
            txt_o1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 70);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 1;
            label2.Text = "2.sayı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 33);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "1.sayı";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 512);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private TextBox txt_o3;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txt_o2;
        private TextBox txt_o1;
        private Label label2;
        private Label label1;
    }
}
