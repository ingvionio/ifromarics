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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADD));
            Num2 = new TextBox();
            Num1 = new TextBox();
            startWindowText = new TextBox();
            BaseNum = new TextBox();
            ReturnBegin = new Button();
            NextStep = new Button();
            carry = new Label();
            ans1 = new Label();
            ans2 = new Label();
            plus = new Label();
            answer = new Label();
            label2 = new Label();
            car = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // Num2
            // 
            Num2.Location = new Point(30, 406);
            Num2.Name = "Num2";
            Num2.Size = new Size(148, 23);
            Num2.TabIndex = 19;
            // 
            // Num1
            // 
            Num1.Location = new Point(30, 332);
            Num1.Name = "Num1";
            Num1.Size = new Size(148, 23);
            Num1.TabIndex = 18;
            // 
            // startWindowText
            // 
            startWindowText.BackColor = SystemColors.Info;
            startWindowText.Location = new Point(30, 33);
            startWindowText.Multiline = true;
            startWindowText.Name = "startWindowText";
            startWindowText.ScrollBars = ScrollBars.Vertical;
            startWindowText.Size = new Size(414, 259);
            startWindowText.TabIndex = 17;
            startWindowText.Text = resources.GetString("startWindowText.Text");
            startWindowText.TextChanged += startWindowText_TextChanged;
            // 
            // BaseNum
            // 
            BaseNum.Location = new Point(260, 332);
            BaseNum.Name = "BaseNum";
            BaseNum.Size = new Size(148, 23);
            BaseNum.TabIndex = 21;
            // 
            // ReturnBegin
            // 
            ReturnBegin.BackColor = SystemColors.HotTrack;
            ReturnBegin.Location = new Point(267, 406);
            ReturnBegin.Name = "ReturnBegin";
            ReturnBegin.Size = new Size(177, 51);
            ReturnBegin.TabIndex = 23;
            ReturnBegin.Text = "вернуться в начало";
            ReturnBegin.UseVisualStyleBackColor = false;
            ReturnBegin.Click += ReturnBegin_Click;
            // 
            // NextStep
            // 
            NextStep.BackColor = SystemColors.HotTrack;
            NextStep.Location = new Point(744, 406);
            NextStep.Name = "NextStep";
            NextStep.Size = new Size(177, 51);
            NextStep.TabIndex = 22;
            NextStep.Text = "следующий шаг";
            NextStep.UseVisualStyleBackColor = false;
            NextStep.Click += NextStep_Click;
            // 
            // carry
            // 
            carry.AutoSize = true;
            carry.Location = new Point(847, 105);
            carry.Name = "carry";
            carry.Size = new Size(0, 15);
            carry.TabIndex = 27;
            // 
            // ans1
            // 
            ans1.AutoSize = true;
            ans1.Location = new Point(594, 90);
            ans1.Name = "ans1";
            ans1.Size = new Size(50, 15);
            ans1.TabIndex = 24;
            ans1.Text = "число 1";
            // 
            // ans2
            // 
            ans2.AutoSize = true;
            ans2.Location = new Point(594, 120);
            ans2.Name = "ans2";
            ans2.Size = new Size(50, 15);
            ans2.TabIndex = 25;
            ans2.Text = "число 2";
            ans2.TextAlign = ContentAlignment.TopRight;
            // 
            // plus
            // 
            plus.AutoSize = true;
            plus.Location = new Point(594, 105);
            plus.Name = "plus";
            plus.Size = new Size(15, 15);
            plus.TabIndex = 26;
            plus.Text = "+";
            // 
            // answer
            // 
            answer.AutoSize = true;
            answer.Location = new Point(594, 150);
            answer.Name = "answer";
            answer.Size = new Size(60, 15);
            answer.TabIndex = 28;
            answer.Text = "результат";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(594, 135);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 29;
            label2.Text = "=";
            // 
            // car
            // 
            car.AutoSize = true;
            car.Location = new Point(642, 226);
            car.Name = "car";
            car.Size = new Size(13, 15);
            car.TabIndex = 30;
            car.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(584, 226);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 31;
            label1.Text = "остаток:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(584, 150);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 32;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 314);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 33;
            label4.Text = "первое число";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 388);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 34;
            label5.Text = "второе число";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(260, 314);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 35;
            label6.Text = "основание СС";
            // 
            // ADD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 467);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(car);
            Controls.Add(label2);
            Controls.Add(answer);
            Controls.Add(carry);
            Controls.Add(plus);
            Controls.Add(ans2);
            Controls.Add(ans1);
            Controls.Add(ReturnBegin);
            Controls.Add(NextStep);
            Controls.Add(BaseNum);
            Controls.Add(Num2);
            Controls.Add(Num1);
            Controls.Add(startWindowText);
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
        private Label carry;
        private Label ans1;
        private Label ans2;
        private Label plus;
        private Label answer;
        private Label label2;
        private Label car;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}