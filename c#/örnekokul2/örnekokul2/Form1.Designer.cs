namespace örnekokul2
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
            txt_o3 = new TextBox();
            button1 = new Button();
            txt_o2 = new TextBox();
            txt_o1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            groupBox3 = new GroupBox();
            button3 = new Button();
            label3 = new Label();
            txt_03 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_o3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txt_o2);
            groupBox1.Controls.Add(txt_o1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-2, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 188);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txt_o3
            // 
            txt_o3.Location = new Point(75, 144);
            txt_o3.Name = "txt_o3";
            txt_o3.Size = new Size(125, 27);
            txt_o3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(92, 109);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "tıkla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_o2
            // 
            txt_o2.Location = new Point(75, 76);
            txt_o2.Name = "txt_o2";
            txt_o2.Size = new Size(125, 27);
            txt_o2.TabIndex = 3;
            // 
            // txt_o1
            // 
            txt_o1.Location = new Point(75, 34);
            txt_o1.Name = "txt_o1";
            txt_o1.Size = new Size(125, 27);
            txt_o1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 79);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "sayı2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 34);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "sayı1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(-2, 221);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(246, 188);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // button2
            // 
            button2.Location = new Point(61, 61);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "tıkla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txt_03);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(button3);
            groupBox3.Location = new Point(274, 25);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(272, 175);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // button3
            // 
            button3.Location = new Point(89, 96);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 0;
            button3.Text = "tıkla";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 52);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 1;
            label3.Text = "tahmin";
            // 
            // txt_03
            // 
            txt_03.Location = new Point(102, 51);
            txt_03.Name = "txt_03";
            txt_03.Size = new Size(125, 27);
            txt_03.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 549);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_o3;
        private Button button1;
        private TextBox txt_o2;
        private TextBox txt_o1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button button2;
        private GroupBox groupBox3;
        private TextBox txt_03;
        private Label label3;
        private Button button3;
    }
}
