namespace QuizMaker
{
    partial class AdminForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblAdminFullName = new System.Windows.Forms.Label();
            this.grpAdminAuthority = new System.Windows.Forms.GroupBox();
            this.btnQuizData = new System.Windows.Forms.Button();
            this.btnQuestionData = new System.Windows.Forms.Button();
            this.btnTester = new System.Windows.Forms.Button();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 14);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(81, 16);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome :";
            // 
            // lblAdminFullName
            // 
            this.lblAdminFullName.AutoSize = true;
            this.lblAdminFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminFullName.Location = new System.Drawing.Point(99, 14);
            this.lblAdminFullName.Name = "lblAdminFullName";
            this.lblAdminFullName.Size = new System.Drawing.Size(128, 16);
            this.lblAdminFullName.TabIndex = 1;
            this.lblAdminFullName.Text = "Filankes Filankesov";
            // 
            // grpAdminAuthority
            // 
            this.grpAdminAuthority.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpAdminAuthority.Location = new System.Drawing.Point(75, 74);
            this.grpAdminAuthority.Name = "grpAdminAuthority";
            this.grpAdminAuthority.Size = new System.Drawing.Size(551, 459);
            this.grpAdminAuthority.TabIndex = 2;
            this.grpAdminAuthority.TabStop = false;
            // 
            // btnQuizData
            // 
            this.btnQuizData.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnQuizData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuizData.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuizData.Location = new System.Drawing.Point(75, 33);
            this.btnQuizData.Name = "btnQuizData";
            this.btnQuizData.Size = new System.Drawing.Size(187, 49);
            this.btnQuizData.TabIndex = 3;
            this.btnQuizData.Text = "Quiz";
            this.btnQuizData.UseVisualStyleBackColor = false;
            this.btnQuizData.Click += new System.EventHandler(this.btnQuizData_Click);
            // 
            // btnQuestionData
            // 
            this.btnQuestionData.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnQuestionData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestionData.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuestionData.Location = new System.Drawing.Point(258, 33);
            this.btnQuestionData.Name = "btnQuestionData";
            this.btnQuestionData.Size = new System.Drawing.Size(187, 49);
            this.btnQuestionData.TabIndex = 4;
            this.btnQuestionData.Text = "Question";
            this.btnQuestionData.UseVisualStyleBackColor = false;
            this.btnQuestionData.Click += new System.EventHandler(this.btnQuestionData_Click);
            // 
            // btnTester
            // 
            this.btnTester.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTester.ForeColor = System.Drawing.Color.Transparent;
            this.btnTester.Location = new System.Drawing.Point(439, 33);
            this.btnTester.Name = "btnTester";
            this.btnTester.Size = new System.Drawing.Size(187, 49);
            this.btnTester.TabIndex = 5;
            this.btnTester.Text = "Testers";
            this.btnTester.UseVisualStyleBackColor = false;
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.Location = new System.Drawing.Point(658, 488);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(63, 18);
            this.lblLogOut.TabIndex = 6;
            this.lblLogOut.Text = "LogOut";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(733, 545);
            this.Controls.Add(this.lblLogOut);
            this.Controls.Add(this.btnTester);
            this.Controls.Add(this.btnQuestionData);
            this.Controls.Add(this.btnQuizData);
            this.Controls.Add(this.grpAdminAuthority);
            this.Controls.Add(this.lblAdminFullName);
            this.Controls.Add(this.lblWelcome);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblAdminFullName;
        private System.Windows.Forms.GroupBox grpAdminAuthority;
        private System.Windows.Forms.Button btnQuizData;
        private System.Windows.Forms.Button btnQuestionData;
        private System.Windows.Forms.Button btnTester;
        private System.Windows.Forms.Label lblLogOut;
    }
}