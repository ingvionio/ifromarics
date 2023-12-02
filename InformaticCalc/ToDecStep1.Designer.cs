namespace InformaticCalc
{
    partial class Answer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            startWindowText = new TextBox();
            NextStep = new Button();
            ReturnBegin = new Button();
            Num = new TextBox();
            BaseNum = new TextBox();
            ans = new TextBox();
            SuspendLayout();
            // 
            // startWindowText
            // 
            startWindowText.BackColor = SystemColors.Info;
            startWindowText.Location = new Point(206, 55);
            startWindowText.Multiline = true;
            startWindowText.Name = "startWindowText";
            startWindowText.ScrollBars = ScrollBars.Vertical;
            startWindowText.Size = new Size(414, 208);
            startWindowText.TabIndex = 6;
            startWindowText.Text = "Введи в верхнее поле число, а в нижнее основание системы исчисления этого числа";
            startWindowText.TextChanged += startWindowText_TextChanged;
            // 
            // NextStep
            // 
            NextStep.BackColor = SystemColors.HotTrack;
            NextStep.Location = new Point(768, 460);
            NextStep.Name = "NextStep";
            NextStep.Size = new Size(177, 51);
            NextStep.TabIndex = 5;
            NextStep.Text = "следующий шаг";
            NextStep.UseVisualStyleBackColor = false;
            NextStep.Click += button3_Click;
            // 
            // ReturnBegin
            // 
            ReturnBegin.BackColor = SystemColors.HotTrack;
            ReturnBegin.Location = new Point(291, 460);
            ReturnBegin.Name = "ReturnBegin";
            ReturnBegin.Size = new Size(177, 51);
            ReturnBegin.TabIndex = 7;
            ReturnBegin.Text = "вернуться в начало";
            ReturnBegin.UseVisualStyleBackColor = false;
            ReturnBegin.Click += button1_Click;
            // 
            // Num
            // 
            Num.Location = new Point(716, 55);
            Num.Name = "Num";
            Num.Size = new Size(148, 23);
            Num.TabIndex = 8;
            Num.TextChanged += Num_TextChanged;
            // 
            // BaseNum
            // 
            BaseNum.Location = new Point(716, 98);
            BaseNum.Name = "BaseNum";
            BaseNum.Size = new Size(148, 23);
            BaseNum.TabIndex = 9;
            BaseNum.TextChanged += BaseNum_TextChanged;
            // 
            // ans
            // 
            ans.BackColor = SystemColors.GradientActiveCaption;
            ans.Location = new Point(716, 142);
            ans.Multiline = true;
            ans.Name = "ans";
            ans.ScrollBars = ScrollBars.Vertical;
            ans.Size = new Size(414, 208);
            ans.TabIndex = 10;
            ans.TextChanged += textBox1_TextChanged;
            // 
            // Answer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1481, 670);
            Controls.Add(ans);
            Controls.Add(BaseNum);
            Controls.Add(Num);
            Controls.Add(ReturnBegin);
            Controls.Add(startWindowText);
            Controls.Add(NextStep);
            Name = "Answer";
            Text = "translete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox startWindowText;
        private Button NextStep;
        private Button ReturnBegin;
        private TextBox Num;
        private TextBox BaseNum;
        private TextBox ans;
    }
}