namespace tekmiçiftmiders
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
            txt_o1 = new TextBox();
            button1 = new Button();
            sayi = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_o1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(sayi);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 240);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txt_o1
            // 
            txt_o1.Location = new Point(174, 87);
            txt_o1.Name = "txt_o1";
            txt_o1.Size = new Size(125, 27);
            txt_o1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(147, 138);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "tek mi çift mi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sayi
            // 
            sayi.AutoSize = true;
            sayi.Location = new Point(42, 84);
            sayi.Name = "sayi";
            sayi.Size = new Size(34, 20);
            sayi.TabIndex = 0;
            sayi.Text = "sayı";
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
        private TextBox txt_o1;
        private Button button1;
        private Label sayi;
    }
}
