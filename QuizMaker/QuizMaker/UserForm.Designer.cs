namespace QuizMaker
{
    partial class UserForm
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
            this.lblWelcome1 = new System.Windows.Forms.Label();
            this.lblUserFullname = new System.Windows.Forms.Label();
            this.cbxUserSelectQuizName = new System.Windows.Forms.ComboBox();
            this.cbxUserSelectQuestionType = new System.Windows.Forms.ComboBox();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome1
            // 
            this.lblWelcome1.AutoSize = true;
            this.lblWelcome1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome1.Location = new System.Drawing.Point(29, 35);
            this.lblWelcome1.Name = "lblWelcome1";
            this.lblWelcome1.Size = new System.Drawing.Size(92, 20);
            this.lblWelcome1.TabIndex = 0;
            this.lblWelcome1.Text = "Welcome :";
            // 
            // lblUserFullname
            // 
            this.lblUserFullname.AutoSize = true;
            this.lblUserFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFullname.Location = new System.Drawing.Point(124, 37);
            this.lblUserFullname.Name = "lblUserFullname";
            this.lblUserFullname.Size = new System.Drawing.Size(147, 20);
            this.lblUserFullname.TabIndex = 1;
            this.lblUserFullname.Text = "Filankes Filankesov";
            // 
            // cbxUserSelectQuizName
            // 
            this.cbxUserSelectQuizName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUserSelectQuizName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbxUserSelectQuizName.FormattingEnabled = true;
            this.cbxUserSelectQuizName.Location = new System.Drawing.Point(243, 105);
            this.cbxUserSelectQuizName.Name = "cbxUserSelectQuizName";
            this.cbxUserSelectQuizName.Size = new System.Drawing.Size(342, 24);
            this.cbxUserSelectQuizName.TabIndex = 3;
            this.cbxUserSelectQuizName.Text = "Select Quiz Name";
            // 
            // cbxUserSelectQuestionType
            // 
            this.cbxUserSelectQuestionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUserSelectQuestionType.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbxUserSelectQuestionType.FormattingEnabled = true;
            this.cbxUserSelectQuestionType.Location = new System.Drawing.Point(243, 155);
            this.cbxUserSelectQuestionType.Name = "cbxUserSelectQuestionType";
            this.cbxUserSelectQuestionType.Size = new System.Drawing.Size(342, 24);
            this.cbxUserSelectQuestionType.TabIndex = 4;
            this.cbxUserSelectQuestionType.Text = "Select Question Type";
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.Location = new System.Drawing.Point(677, 35);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(63, 18);
            this.lblLogOut.TabIndex = 5;
            this.lblLogOut.Text = "LogOut";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStartQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartQuiz.Location = new System.Drawing.Point(287, 229);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(203, 54);
            this.btnStartQuiz.TabIndex = 6;
            this.btnStartQuiz.Text = "Start Quiz";
            this.btnStartQuiz.UseVisualStyleBackColor = false;
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(764, 378);
            this.Controls.Add(this.btnStartQuiz);
            this.Controls.Add(this.lblLogOut);
            this.Controls.Add(this.cbxUserSelectQuestionType);
            this.Controls.Add(this.cbxUserSelectQuizName);
            this.Controls.Add(this.lblUserFullname);
            this.Controls.Add(this.lblWelcome1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome1;
        private System.Windows.Forms.Label lblUserFullname;
        private System.Windows.Forms.ComboBox cbxUserSelectQuizName;
        private System.Windows.Forms.ComboBox cbxUserSelectQuestionType;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.Button btnStartQuiz;
    }
}