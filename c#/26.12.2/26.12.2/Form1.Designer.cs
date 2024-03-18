namespace _26._12._2
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
            list1 = new ListBox();
            bas = new Button();
            txt = new TextBox();
            txt2 = new TextBox();
            txt3 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            snc = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(snc);
            groupBox1.Controls.Add(list1);
            groupBox1.Controls.Add(bas);
            groupBox1.Controls.Add(txt);
            groupBox1.Controls.Add(txt2);
            groupBox1.Controls.Add(txt3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 302);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "örnek1";
            // 
            // list1
            // 
            list1.FormattingEnabled = true;
            list1.Location = new Point(12, 193);
            list1.Name = "list1";
            list1.Size = new Size(97, 64);
            list1.TabIndex = 4;
            // 
            // bas
            // 
            bas.Location = new Point(75, 158);
            bas.Name = "bas";
            bas.Size = new Size(94, 29);
            bas.TabIndex = 1;
            bas.Text = "button1";
            bas.UseVisualStyleBackColor = true;
            bas.Click += bas_Click;
            // 
            // txt
            // 
            txt.Location = new Point(54, 26);
            txt.Name = "txt";
            txt.Size = new Size(125, 27);
            txt.TabIndex = 1;
            // 
            // txt2
            // 
            txt2.Location = new Point(60, 77);
            txt2.Name = "txt2";
            txt2.Size = new Size(125, 27);
            txt2.TabIndex = 2;
            // 
            // txt3
            // 
            txt3.Location = new Point(60, 125);
            txt3.Name = "txt3";
            txt3.Size = new Size(125, 27);
            txt3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 132);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 3;
            label3.Text = "deger";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 84);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 2;
            label2.Text = "sayi2";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 1;
            label1.Text = "sayi1";
            label1.Click += label1_Click;
            // 
            // snc
            // 
            snc.Location = new Point(115, 249);
            snc.Name = "snc";
            snc.Size = new Size(125, 27);
            snc.TabIndex = 5;
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

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txt;
        private TextBox txt2;
        private TextBox txt3;
        private Label label3;
        private Label label2;
        private ListBox list1;
        private Button bas;
        private TextBox snc;
    }
}
