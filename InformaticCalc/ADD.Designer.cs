namespace InformaticCalc
{
    partial class ADD
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
            Num2 = new TextBox();
            Num1 = new TextBox();
            startWindowText = new TextBox();
            BaseNum = new TextBox();
            ReturnBegin = new Button();
            NextStep = new Button();
            number1 = new Label();
            number2 = new Label();
            plus = new Label();
            SuspendLayout();
            // 
            // Num2
            // 
            Num2.Location = new Point(34, 497);
            Num2.Margin = new Padding(3, 4, 3, 4);
            Num2.Name = "Num2";
            Num2.Size = new Size(169, 27);
            Num2.TabIndex = 19;
            // 
            // Num1
            // 
            Num1.Location = new Point(34, 443);
            Num1.Margin = new Padding(3, 4, 3, 4);
            Num1.Name = "Num1";
            Num1.Size = new Size(169, 27);
            Num1.TabIndex = 18;
            // 
            // startWindowText
            // 
            startWindowText.BackColor = SystemColors.Info;
            startWindowText.Location = new Point(34, 80);
            startWindowText.Margin = new Padding(3, 4, 3, 4);
            startWindowText.Multiline = true;
            startWindowText.Name = "startWindowText";
            startWindowText.ScrollBars = ScrollBars.Vertical;
            startWindowText.Size = new Size(473, 319);
            startWindowText.TabIndex = 17;
            startWindowText.Text = "Введи два числа и систему этих чисел\r\n";
            startWindowText.TextChanged += startWindowText_TextChanged;
            // 
            // BaseNum
            // 
            BaseNum.Location = new Point(297, 443);
            BaseNum.Margin = new Padding(3, 4, 3, 4);
            BaseNum.Name = "BaseNum";
            BaseNum.Size = new Size(169, 27);
            BaseNum.TabIndex = 21;
            // 
            // ReturnBegin
            // 
            ReturnBegin.BackColor = SystemColors.HotTrack;
            ReturnBegin.Location = new Point(305, 542);
            ReturnBegin.Margin = new Padding(3, 4, 3, 4);
            ReturnBegin.Name = "ReturnBegin";
            ReturnBegin.Size = new Size(202, 68);
            ReturnBegin.TabIndex = 23;
            ReturnBegin.Text = "вернуться в начало";
            ReturnBegin.UseVisualStyleBackColor = false;
            // 
            // NextStep
            // 
            NextStep.BackColor = SystemColors.HotTrack;
            NextStep.Location = new Point(850, 542);
            NextStep.Margin = new Padding(3, 4, 3, 4);
            NextStep.Name = "NextStep";
            NextStep.Size = new Size(202, 68);
            NextStep.TabIndex = 22;
            NextStep.Text = "следующий шаг";
            NextStep.UseVisualStyleBackColor = false;
            NextStep.Click += NextStep_Click;
            // 
            // number1
            // 
            number1.AutoSize = true;
            number1.Location = new Point(679, 97);
            number1.Name = "number1";
            number1.Size = new Size(50, 20);
            number1.TabIndex = 24;
            number1.Text = "label1";
            // 
            // number2
            // 
            number2.AutoSize = true;
            number2.Location = new Point(679, 181);
            number2.Name = "number2";
            number2.Size = new Size(50, 20);
            number2.TabIndex = 25;
            number2.Text = "label2";
            // 
            // plus
            // 
            plus.AutoSize = true;
            plus.Location = new Point(679, 140);
            plus.Name = "plus";
            plus.Size = new Size(19, 20);
            plus.TabIndex = 26;
            plus.Text = "+";
            // 
            // ADD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1375, 623);
            Controls.Add(plus);
            Controls.Add(number2);
            Controls.Add(number1);
            Controls.Add(ReturnBegin);
            Controls.Add(NextStep);
            Controls.Add(BaseNum);
            Controls.Add(Num2);
            Controls.Add(Num1);
            Controls.Add(startWindowText);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ADD";
            Text = "ADD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Num2;
        private TextBox Num1;
        private TextBox startWindowText;
        private TextBox BaseNum;
        private Button ReturnBegin;
        private Button NextStep;
        private Label number1;
        private Label number2;
        private Label plus;
    }
}