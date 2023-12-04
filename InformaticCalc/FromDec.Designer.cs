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
            ans.Location = new Point(760, 71);
            ans.Multiline = true;
            ans.Name = "ans";
            ans.ScrollBars = ScrollBars.Vertical;
            ans.Size = new Size(414, 240);
            ans.TabIndex = 16;
            // 
            // BaseNum
            // 
            BaseNum.Location = new Point(267, 386);
            BaseNum.Name = "BaseNum";
            BaseNum.Size = new Size(148, 23);
            BaseNum.TabIndex = 15;
            // 
            // Num
            // 
            Num.Location = new Point(267, 343);
            Num.Name = "Num";
            Num.Size = new Size(148, 23);
            Num.TabIndex = 14;
            // 
            // ReturnBegin
            // 
            ReturnBegin.BackColor = SystemColors.HotTrack;
            ReturnBegin.Location = new Point(352, 476);
            ReturnBegin.Name = "ReturnBegin";
            ReturnBegin.Size = new Size(177, 51);
            ReturnBegin.TabIndex = 13;
            ReturnBegin.Text = "вернуться в начало";
            ReturnBegin.UseVisualStyleBackColor = false;
            ReturnBegin.Click += ReturnBegin_Click;
            // 
            // startWindowText
            // 
            startWindowText.BackColor = SystemColors.Info;
            startWindowText.Location = new Point(267, 71);
            startWindowText.Multiline = true;
            startWindowText.Name = "startWindowText";
            startWindowText.ScrollBars = ScrollBars.Vertical;
            startWindowText.Size = new Size(414, 240);
            startWindowText.TabIndex = 12;
            startWindowText.Text = "Введи в верхнее поле число в десятичной системе, а в нижнее основание системы исчисления, в которую необходимо перевести число";
            // 
            // NextStep
            // 
            NextStep.BackColor = SystemColors.HotTrack;
            NextStep.Location = new Point(829, 476);
            NextStep.Name = "NextStep";
            NextStep.Size = new Size(177, 51);
            NextStep.TabIndex = 11;
            NextStep.Text = "следующий шаг";
            NextStep.UseVisualStyleBackColor = false;
            NextStep.Click += NextStep_Click;
            // 
            // FromDec
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1476, 663);
            Controls.Add(ans);
            Controls.Add(BaseNum);
            Controls.Add(Num);
            Controls.Add(ReturnBegin);
            Controls.Add(startWindowText);
            Controls.Add(NextStep);
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