﻿namespace InformaticCalc
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            startWindowText = new TextBox();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Location = new Point(392, 421);
            button1.Name = "button1";
            button1.Size = new Size(175, 51);
            button1.TabIndex = 0;
            button1.Text = "вычитание";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Location = new Point(607, 421);
            button2.Name = "button2";
            button2.Size = new Size(175, 51);
            button2.TabIndex = 1;
            button2.Text = "умножение";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.Location = new Point(812, 421);
            button3.Name = "button3";
            button3.Size = new Size(175, 51);
            button3.TabIndex = 2;
            button3.Text = "перевод в десятичную";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HotTrack;
            button4.Location = new Point(179, 421);
            button4.Name = "button4";
            button4.Size = new Size(175, 51);
            button4.TabIndex = 3;
            button4.Text = "сложение";
            button4.UseVisualStyleBackColor = false;
            // 
            // startWindowText
            // 
            startWindowText.BackColor = SystemColors.Info;
            startWindowText.Location = new Point(179, 12);
            startWindowText.Multiline = true;
            startWindowText.Name = "startWindowText";
            startWindowText.ScrollBars = ScrollBars.Vertical;
            startWindowText.Size = new Size(1011, 373);
            startWindowText.TabIndex = 4;
            startWindowText.Text = "Здравствуй";
            startWindowText.TextChanged += textBox1_TextChanged;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.HotTrack;
            button5.Location = new Point(1015, 421);
            button5.Name = "button5";
            button5.Size = new Size(175, 51);
            button5.TabIndex = 5;
            button5.Text = "перевод из десятичной";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1394, 635);
            Controls.Add(button5);
            Controls.Add(startWindowText);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox startWindowText;
        private Button button5;
    }
}