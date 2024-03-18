namespace ifelse
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
            label2 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            txt_o3 = new Label();
            textBox3 = new TextBox();
            txt_o2 = new TextBox();
            txt_o1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 49);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "sayi1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 95);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "sayi2";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txt_o3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(txt_o2);
            groupBox1.Controls.Add(txt_o1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(147, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 278);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            button1.Location = new Point(156, 156);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "tıkla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_o3
            // 
            txt_o3.AutoSize = true;
            txt_o3.Location = new Point(34, 204);
            txt_o3.Name = "txt_o3";
            txt_o3.Size = new Size(47, 20);
            txt_o3.TabIndex = 5;
            txt_o3.Text = "sonuç";
            txt_o3.Click += label3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(138, 210);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // txt_o2
            // 
            txt_o2.Location = new Point(176, 95);
            txt_o2.Name = "txt_o2";
            txt_o2.Size = new Size(125, 27);
            txt_o2.TabIndex = 3;
            // 
            // txt_o1
            // 
            txt_o1.Location = new Point(176, 55);
            txt_o1.Name = "txt_o1";
            txt_o1.Size = new Size(125, 27);
            txt_o1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label txt_o3;
        private TextBox textBox3;
        private TextBox txt_o2;
        private TextBox txt_o1;
        private Button button1;
    }
}
