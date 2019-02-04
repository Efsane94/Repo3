namespace QuizMaker
{
    partial class QuizForm
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
            this.lblQuestionWord = new System.Windows.Forms.Label();
            this.lblQuestionNum = new System.Windows.Forms.Label();
            this.lblOf = new System.Windows.Forms.Label();
            this.lblQuestionCount = new System.Windows.Forms.Label();
            this.rdBtnVariantA = new System.Windows.Forms.RadioButton();
            this.lblVariantA = new System.Windows.Forms.Label();
            this.lblVariantB = new System.Windows.Forms.Label();
            this.rdBtnVariantB = new System.Windows.Forms.RadioButton();
            this.lblVariantC = new System.Windows.Forms.Label();
            this.rdBtnVariantC = new System.Windows.Forms.RadioButton();
            this.lblVariantD = new System.Windows.Forms.Label();
            this.rdBtnVariantD = new System.Windows.Forms.RadioButton();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.lblQuizName = new System.Windows.Forms.Label();
            this.lblQuestionTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestionWord
            // 
            this.lblQuestionWord.AutoSize = true;
            this.lblQuestionWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionWord.Location = new System.Drawing.Point(21, 58);
            this.lblQuestionWord.Name = "lblQuestionWord";
            this.lblQuestionWord.Size = new System.Drawing.Size(76, 18);
            this.lblQuestionWord.TabIndex = 0;
            this.lblQuestionWord.Text = "Question";
            // 
            // lblQuestionNum
            // 
            this.lblQuestionNum.AutoSize = true;
            this.lblQuestionNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNum.Location = new System.Drawing.Point(103, 58);
            this.lblQuestionNum.Name = "lblQuestionNum";
            this.lblQuestionNum.Size = new System.Drawing.Size(30, 18);
            this.lblQuestionNum.TabIndex = 1;
            this.lblQuestionNum.Text = "No";
            // 
            // lblOf
            // 
            this.lblOf.AutoSize = true;
            this.lblOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOf.Location = new System.Drawing.Point(139, 58);
            this.lblOf.Name = "lblOf";
            this.lblOf.Size = new System.Drawing.Size(23, 18);
            this.lblOf.TabIndex = 2;
            this.lblOf.Text = "of";
            // 
            // lblQuestionCount
            // 
            this.lblQuestionCount.AutoSize = true;
            this.lblQuestionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionCount.Location = new System.Drawing.Point(168, 58);
            this.lblQuestionCount.Name = "lblQuestionCount";
            this.lblQuestionCount.Size = new System.Drawing.Size(43, 18);
            this.lblQuestionCount.TabIndex = 3;
            this.lblQuestionCount.Text = "Num";
            // 
            // rdBtnVariantA
            // 
            this.rdBtnVariantA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rdBtnVariantA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnVariantA.Location = new System.Drawing.Point(56, 126);
            this.rdBtnVariantA.MaximumSize = new System.Drawing.Size(800, 50);
            this.rdBtnVariantA.Name = "rdBtnVariantA";
            this.rdBtnVariantA.Size = new System.Drawing.Size(800, 35);
            this.rdBtnVariantA.TabIndex = 4;
            this.rdBtnVariantA.TabStop = true;
            this.rdBtnVariantA.Text = "Variant A";
            this.rdBtnVariantA.UseVisualStyleBackColor = false;
            this.rdBtnVariantA.CheckedChanged += new System.EventHandler(this.Leave);
            this.rdBtnVariantA.MouseLeave += new System.EventHandler(this.Leave);
            this.rdBtnVariantA.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move);
            // 
            // lblVariantA
            // 
            this.lblVariantA.AutoSize = true;
            this.lblVariantA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariantA.ForeColor = System.Drawing.Color.Gray;
            this.lblVariantA.Location = new System.Drawing.Point(20, 131);
            this.lblVariantA.Name = "lblVariantA";
            this.lblVariantA.Size = new System.Drawing.Size(30, 24);
            this.lblVariantA.TabIndex = 5;
            this.lblVariantA.Text = "A.";
            // 
            // lblVariantB
            // 
            this.lblVariantB.AutoSize = true;
            this.lblVariantB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariantB.ForeColor = System.Drawing.Color.Gray;
            this.lblVariantB.Location = new System.Drawing.Point(20, 182);
            this.lblVariantB.Name = "lblVariantB";
            this.lblVariantB.Size = new System.Drawing.Size(29, 24);
            this.lblVariantB.TabIndex = 7;
            this.lblVariantB.Text = "B.";
            // 
            // rdBtnVariantB
            // 
            this.rdBtnVariantB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rdBtnVariantB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnVariantB.Location = new System.Drawing.Point(56, 177);
            this.rdBtnVariantB.MaximumSize = new System.Drawing.Size(800, 50);
            this.rdBtnVariantB.Name = "rdBtnVariantB";
            this.rdBtnVariantB.Size = new System.Drawing.Size(800, 35);
            this.rdBtnVariantB.TabIndex = 6;
            this.rdBtnVariantB.TabStop = true;
            this.rdBtnVariantB.Text = "Variant B";
            this.rdBtnVariantB.UseVisualStyleBackColor = false;
            this.rdBtnVariantB.MouseLeave += new System.EventHandler(this.Leave);
            this.rdBtnVariantB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move);
            // 
            // lblVariantC
            // 
            this.lblVariantC.AutoSize = true;
            this.lblVariantC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariantC.ForeColor = System.Drawing.Color.Gray;
            this.lblVariantC.Location = new System.Drawing.Point(20, 232);
            this.lblVariantC.Name = "lblVariantC";
            this.lblVariantC.Size = new System.Drawing.Size(30, 24);
            this.lblVariantC.TabIndex = 9;
            this.lblVariantC.Text = "C.";
            // 
            // rdBtnVariantC
            // 
            this.rdBtnVariantC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rdBtnVariantC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnVariantC.Location = new System.Drawing.Point(56, 227);
            this.rdBtnVariantC.MaximumSize = new System.Drawing.Size(800, 50);
            this.rdBtnVariantC.Name = "rdBtnVariantC";
            this.rdBtnVariantC.Size = new System.Drawing.Size(800, 35);
            this.rdBtnVariantC.TabIndex = 8;
            this.rdBtnVariantC.TabStop = true;
            this.rdBtnVariantC.Text = "Variant C";
            this.rdBtnVariantC.UseVisualStyleBackColor = false;
            this.rdBtnVariantC.MouseLeave += new System.EventHandler(this.Leave);
            this.rdBtnVariantC.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move);
            // 
            // lblVariantD
            // 
            this.lblVariantD.AutoSize = true;
            this.lblVariantD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariantD.ForeColor = System.Drawing.Color.Gray;
            this.lblVariantD.Location = new System.Drawing.Point(20, 283);
            this.lblVariantD.Name = "lblVariantD";
            this.lblVariantD.Size = new System.Drawing.Size(30, 24);
            this.lblVariantD.TabIndex = 11;
            this.lblVariantD.Text = "D.";
            // 
            // rdBtnVariantD
            // 
            this.rdBtnVariantD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rdBtnVariantD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnVariantD.Location = new System.Drawing.Point(56, 278);
            this.rdBtnVariantD.MaximumSize = new System.Drawing.Size(800, 50);
            this.rdBtnVariantD.Name = "rdBtnVariantD";
            this.rdBtnVariantD.Size = new System.Drawing.Size(800, 35);
            this.rdBtnVariantD.TabIndex = 10;
            this.rdBtnVariantD.TabStop = true;
            this.rdBtnVariantD.Text = "Variant D";
            this.rdBtnVariantD.UseVisualStyleBackColor = false;
            this.rdBtnVariantD.MouseLeave += new System.EventHandler(this.Leave);
            this.rdBtnVariantD.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQuestion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNextQuestion.Location = new System.Drawing.Point(713, 352);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(143, 41);
            this.btnNextQuestion.TabIndex = 12;
            this.btnNextQuestion.Text = "Next";
            this.btnNextQuestion.UseVisualStyleBackColor = false;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // lblQuizName
            // 
            this.lblQuizName.AutoSize = true;
            this.lblQuizName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizName.Location = new System.Drawing.Point(15, 20);
            this.lblQuizName.Name = "lblQuizName";
            this.lblQuizName.Size = new System.Drawing.Size(96, 20);
            this.lblQuizName.TabIndex = 13;
            this.lblQuizName.Text = "Quiz Name";
            // 
            // lblQuestionTitle
            // 
            this.lblQuestionTitle.AutoSize = true;
            this.lblQuestionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionTitle.Location = new System.Drawing.Point(62, 96);
            this.lblQuestionTitle.Name = "lblQuestionTitle";
            this.lblQuestionTitle.Size = new System.Drawing.Size(120, 20);
            this.lblQuestionTitle.TabIndex = 14;
            this.lblQuestionTitle.Text = "Question Title";
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(954, 450);
            this.Controls.Add(this.lblQuestionTitle);
            this.Controls.Add(this.lblQuizName);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.lblVariantD);
            this.Controls.Add(this.rdBtnVariantD);
            this.Controls.Add(this.lblVariantC);
            this.Controls.Add(this.rdBtnVariantC);
            this.Controls.Add(this.lblVariantB);
            this.Controls.Add(this.rdBtnVariantB);
            this.Controls.Add(this.lblVariantA);
            this.Controls.Add(this.rdBtnVariantA);
            this.Controls.Add(this.lblQuestionCount);
            this.Controls.Add(this.lblOf);
            this.Controls.Add(this.lblQuestionNum);
            this.Controls.Add(this.lblQuestionWord);
            this.Name = "QuizForm";
            this.Text = "QuizForm";
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestionWord;
        private System.Windows.Forms.Label lblQuestionNum;
        private System.Windows.Forms.Label lblOf;
        private System.Windows.Forms.Label lblQuestionCount;
        private System.Windows.Forms.RadioButton rdBtnVariantA;
        private System.Windows.Forms.Label lblVariantA;
        private System.Windows.Forms.Label lblVariantB;
        private System.Windows.Forms.RadioButton rdBtnVariantB;
        private System.Windows.Forms.Label lblVariantC;
        private System.Windows.Forms.RadioButton rdBtnVariantC;
        private System.Windows.Forms.Label lblVariantD;
        private System.Windows.Forms.RadioButton rdBtnVariantD;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Label lblQuizName;
        private System.Windows.Forms.Label lblQuestionTitle;
    }
}