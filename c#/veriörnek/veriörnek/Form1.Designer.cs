namespace veriörnek
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
            txt4 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            txt3 = new TextBox();
            txt2 = new TextBox();
            txt1 = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt4);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txt3);
            groupBox1.Controls.Add(txt2);
            groupBox1.Controls.Add(txt1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 228);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txt4
            // 
            txt4.Location = new Point(12, 179);
            txt4.Name = "txt4";
            txt4.Size = new Size(87, 27);
            txt4.TabIndex = 7;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(128, 144);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 64);
            listBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(28, 144);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt3
            // 
            txt3.Location = new Point(124, 101);
            txt3.Name = "txt3";
            txt3.Size = new Size(125, 27);
            txt3.TabIndex = 4;
            // 
            // txt2
            // 
            txt2.Location = new Point(124, 68);
            txt2.Name = "txt2";
            txt2.Size = new Size(125, 27);
            txt2.TabIndex = 3;
            // 
            // txt1
            // 
            txt1.Location = new Point(124, 26);
            txt1.Name = "txt1";
            txt1.Size = new Size(125, 27);
            txt1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1391, 607);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox txt3;
        private TextBox txt2;
        private TextBox txt1;
        private Label label1;
        private TextBox txt4;
        private ListBox listBox1;
    }
}
