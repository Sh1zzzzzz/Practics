namespace Задание_11
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Fx = new System.Windows.Forms.GroupBox();
            this.exp = new System.Windows.Forms.RadioButton();
            this.ch = new System.Windows.Forms.RadioButton();
            this.sh = new System.Windows.Forms.RadioButton();
            this.Fx.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Расчёт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите Х:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 35);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 130);
            this.textBox2.TabIndex = 3;
            // 
            // Fx
            // 
            this.Fx.Controls.Add(this.exp);
            this.Fx.Controls.Add(this.ch);
            this.Fx.Controls.Add(this.sh);
            this.Fx.Location = new System.Drawing.Point(191, 9);
            this.Fx.Name = "Fx";
            this.Fx.Size = new System.Drawing.Size(72, 126);
            this.Fx.TabIndex = 4;
            this.Fx.TabStop = false;
            this.Fx.Text = "F(x)";
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(6, 83);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(61, 26);
            this.exp.TabIndex = 7;
            this.exp.TabStop = true;
            this.exp.Text = "exp";
            this.exp.UseVisualStyleBackColor = true;
            // 
            // ch
            // 
            this.ch.Location = new System.Drawing.Point(6, 51);
            this.ch.Name = "ch";
            this.ch.Size = new System.Drawing.Size(61, 26);
            this.ch.TabIndex = 6;
            this.ch.TabStop = true;
            this.ch.Text = "ch";
            this.ch.UseVisualStyleBackColor = true;
            this.ch.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // sh
            // 
            this.sh.Location = new System.Drawing.Point(6, 19);
            this.sh.Name = "sh";
            this.sh.Size = new System.Drawing.Size(61, 26);
            this.sh.TabIndex = 5;
            this.sh.TabStop = true;
            this.sh.Text = "sh";
            this.sh.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 178);
            this.Controls.Add(this.Fx);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Задание 11";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Fx.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RadioButton ch;
        private System.Windows.Forms.RadioButton exp;
        private System.Windows.Forms.GroupBox Fx;
        private System.Windows.Forms.RadioButton sh;

        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Button button1;

        #endregion
    }
}