namespace InformaticCalc
{
    partial class FromDec
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
            ans = new TextBox();
            BaseNum = new TextBox();
            Num = new TextBox();
            ReturnBegin = new Button();
            startWindowText = new TextBox();
            NextStep = new Button();
            SuspendLayout();
            // 
            // ans
            // 
            ans.BackColor = SystemColors.GradientActiveCaption;
            ans.Location = new Point(869, 97);
            ans.Margin = new Padding(3, 4, 3, 4);
            ans.Multiline = true;
            ans.Name = "ans";
            ans.ScrollBars = ScrollBars.Vertical;
            ans.Size = new Size(473, 319);
            ans.TabIndex = 16;
            ans.TextChanged += ans_TextChanged;
            // 
            // BaseNum
            // 
            BaseNum.Location = new Point(305, 515);
            BaseNum.Margin = new Padding(3, 4, 3, 4);
            BaseNum.Name = "BaseNum";
            BaseNum.Size = new Size(169, 27);
            BaseNum.TabIndex = 15;
            // 
            // Num
            // 
            Num.Location = new Point(305, 460);
            Num.Margin = new Padding(3, 4, 3, 4);
            Num.Name = "Num";
            Num.Size = new Size(169, 27);
            Num.TabIndex = 14;
            // 
            // ReturnBegin
            // 
            ReturnBegin.BackColor = SystemColors.HotTrack;
            ReturnBegin.Location = new Point(402, 635);
            ReturnBegin.Margin = new Padding(3, 4, 3, 4);
            ReturnBegin.Name = "ReturnBegin";
            ReturnBegin.Size = new Size(202, 68);
            ReturnBegin.TabIndex = 13;
            ReturnBegin.Text = "вернуться в начало";
            ReturnBegin.UseVisualStyleBackColor = false;
            ReturnBegin.Click += ReturnBegin_Click;
            // 
            // startWindowText
            // 
            startWindowText.BackColor = SystemColors.Info;
            startWindowText.Location = new Point(305, 97);
            startWindowText.Margin = new Padding(3, 4, 3, 4);
            startWindowText.Multiline = true;
            startWindowText.Name = "startWindowText";
            startWindowText.ScrollBars = ScrollBars.Vertical;
            startWindowText.Size = new Size(473, 319);
            startWindowText.TabIndex = 12;
            startWindowText.Text = "Введи в верхнее поле число в десятичной системе, а в нижнее основание системы исчисления, в которую необходимо перевести число";
            // 
            // NextStep
            // 
            NextStep.BackColor = SystemColors.HotTrack;
            NextStep.Location = new Point(947, 635);
            NextStep.Margin = new Padding(3, 4, 3, 4);
            NextStep.Name = "NextStep";
            NextStep.Size = new Size(202, 68);
            NextStep.TabIndex = 11;
            NextStep.Text = "следующий шаг";
            NextStep.UseVisualStyleBackColor = false;
            NextStep.Click += NextStep_Click;
            // 
            // FromDec
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1687, 884);
            Controls.Add(ans);
            Controls.Add(BaseNum);
            Controls.Add(Num);
            Controls.Add(ReturnBegin);
            Controls.Add(startWindowText);
            Controls.Add(NextStep);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FromDec";
            Text = "FromDec";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ans;
        private TextBox BaseNum;
        private TextBox Num;
        private Button ReturnBegin;
        private TextBox startWindowText;
        private Button NextStep;
    }
}