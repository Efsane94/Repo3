using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaker
{
    public partial class AdminForm : Form
    {
        QuizMakerEntities Db = new QuizMakerEntities();


        public string LabelText
        {
            get
            {
                return this.lblAdminFullName.Text;
            }
            set
            {
                this.lblAdminFullName.Text = value;
            }
        }
       
        public AdminForm()
        {
            InitializeComponent();

        }
        
        private void btnQuestionData_Click(object sender, EventArgs e)
        {
            grpAdminAuthority.Controls.Clear();
            Label labelSelectQuiz = new Label()
            {
                Font = new Font(Font.FontFamily, 11, FontStyle.Bold),
                Width = 200,
                Text = "Select Quiz Name",
                ForeColor = Color.Gray,
                Name = "lblSelectQuizName",
                Location = new Point(30,23)
            };
            ComboBox cbxSelectQuizName = new ComboBox()
            {
                Width = 300,
                Height = 30,
                Location = new Point(30, 50),
                Font = new Font(Font.FontFamily, 11),
                Name = "cbxSelectQuizName"
            };
            foreach (var item in Db.Quizs)
            {
                if (item.User.UserFullName==lblAdminFullName.Text)
                {
                    cbxSelectQuizName.Items.Add(item.QuizName);
                }


            }

            ComboBox cbxSelectQuestionType = new ComboBox()
            {
                Width = 300,
                Height = 30,
                Location = new Point(30, 90),
                Font = new Font(Font.FontFamily, 11),
                Name="cbxSelectQuestionType"
            };
            Label lbl = new Label()
            {
                Font = new Font(Font.FontFamily, 11, FontStyle.Bold),
                Width = 200,
                Text = "Add a Question",
                ForeColor = Color.Gray,
                Name = "lblAddQuiz",
                Location = new Point(30, 130)
            };
            TextBox tbx = new TextBox()
            {
                Width = 480,
                Height = 35,
                Location = new Point(30, 155),
                Name = "tbxAddQuestion",
                Font = new Font(Font.FontFamily, 11)
            };
            TextBox tbxVariantA = new TextBox()
            {
                Width = 200,
                Height = 25,
                Location = new Point(30, 190),
                Name = "tbxVariantA",
                Font = new Font(Font.FontFamily, 11),
                Text="A"
            };
            TextBox tbxVariantB = new TextBox()
            {
                Width = 200,
                Height = 25,
                Location = new Point(250, 190),
                Name = "tbxVariantB",
                Font = new Font(Font.FontFamily, 11),
                Text = "B"
            };
            TextBox tbxVariantC = new TextBox()
            {
                Width = 200,
                Height = 25,
                Location = new Point(30, 220),
                Name = "tbxVariantC",
                Font = new Font(Font.FontFamily, 11),
                Text = "C"
            };
            TextBox tbxVariantD = new TextBox()
            {
                Width = 200,
                Height = 25,
                Location = new Point(250, 220),
                Name = "tbxVariantD",
                Font = new Font(Font.FontFamily, 11),
                Text = "D"
            };
            TextBox tbxRightAnswer = new TextBox()
            {
                Width = 200,
                Height = 25,
                Location = new Point(130, 250),
                Name = "tbxRightAnswer",
                Font = new Font(Font.FontFamily, 11),
                Text = "Right"
            };
            Button btn = new Button()
            {
                Width = 480,
                Height = 50,
                Location = new Point(30, 300),
                Font = new Font(Font.FontFamily, 12, FontStyle.Bold),
                Text = "+ADD",
                BackColor = Color.LightGray,
                Name = "btnAddQuestion",
            };
            

            foreach (var item in Db.QuestionTypes)
            {
                cbxSelectQuestionType.Items.Add(item.TypeName);
                cbxSelectQuestionType.Text = Db.QuestionTypes.Where(question => question.TypeId == 1).First().TypeName;
            }
            grpAdminAuthority.Controls.Add(labelSelectQuiz);
            grpAdminAuthority.Controls.Add(tbxVariantA);
            grpAdminAuthority.Controls.Add(tbxVariantB);
            grpAdminAuthority.Controls.Add(tbxVariantC);
            grpAdminAuthority.Controls.Add(tbxVariantD);
            grpAdminAuthority.Controls.Add(tbxRightAnswer);
            grpAdminAuthority.Controls.Add(lbl);
            grpAdminAuthority.Controls.Add(tbx);
            grpAdminAuthority.Controls.Add(btn);
            grpAdminAuthority.Controls.Add(cbxSelectQuizName);
            grpAdminAuthority.Controls.Add(cbxSelectQuestionType);

            btn.Click += AddQuestion;


        }

        private void AddQuestion(object sender, EventArgs e)
        {
            
            Question question = new Question();
            QuestionQuiz questionQuiz = new QuestionQuiz();
            foreach (var item in grpAdminAuthority.Controls)
            {
                if (item is ComboBox)
                {
                    var cbx = item as ComboBox;
                    if (cbx.Name == "cbxSelectQuizName")
                    {
                        QuizData.SelectQuizId = Db.Quizs.Where(name => name.QuizName == cbx.SelectedItem.ToString()).First().QuizId;
                    }
                    if (cbx.Name == "cbxSelectQuestionType")
                    {
                        QuizData.SelectQuestionTypeId = Db.QuestionTypes.Where(name => name.TypeName == cbx.SelectedItem.ToString()).First().TypeId;
                        question.QuestionTypeId = QuizData.SelectQuestionTypeId;
                    }
                }
                if (item is TextBox)
                {
                    var tbx = item as TextBox;
                    if (tbx.Name == "tbxAddQuestion")
                    {
                        question.QuestionTitle = tbx.Text;
                    }
                    if (tbx.Name == "tbxVariantA")
                    {
                        question.AnswerA = tbx.Text;
                    }
                    if (tbx.Name == "tbxVariantB")
                    {
                        question.AnswerB = tbx.Text;
                    }
                    if (tbx.Name == "tbxVariantC")
                    {
                        question.AnswerC = tbx.Text;
                    }
                    if (tbx.Name == "tbxVariantD")
                    {
                        question.AnswerD = tbx.Text;
                    }
                    if (tbx.Name == "tbxRightAnswer")
                    {
                        question.RightAnswer = tbx.Text;
                    }
                }
            }
            Db.Questions.Add(question);
            Db.SaveChanges();
            questionQuiz.QuestionId = Db.Questions.ToList()[Db.Questions.ToList().Count - 1].QuestionId;
            questionQuiz.QuizId = QuizData.SelectQuizId;
            Db.QuestionQuizs.Add(questionQuiz);
            Db.SaveChanges();

        }

        private void btnQuizData_Click(object sender, EventArgs e)
        {

            grpAdminAuthority.Controls.Clear();
            Label lblAddQz = new Label()
            {
                Location = new Point(10, 30),
                Width = 80,
                Font = new Font(Font.FontFamily, 11),
                ForeColor = Color.CornflowerBlue,
                Text = "Add Quiz"
            };

            Label lblShowAllQuiz = new Label()
            {
                Location = new Point(110, 30),
                Width = 130,
                Font = new Font(Font.FontFamily, 11),
                ForeColor = Color.CornflowerBlue,
                Text = "Show All Quizes"
            };
            


            Label lblShowMyQuiz = new Label()
            {
                Location = new Point(245, 30),
                Width = 150,
                Font = new Font(Font.FontFamily, 11),
                ForeColor = Color.CornflowerBlue,
                Text = "Show My Quizes"
            };

            TextBox tbx = new TextBox()
            {
                Width = 480,
                Height = 35,
                Location = new Point(30, 120),
                Name = "tbxAddQuiz",
                Font = new Font(Font.FontFamily, 11)
            };
            Label lbl = new Label()
            {
                Font = new Font(Font.FontFamily, 11, FontStyle.Bold),
                Width = 200,
                Text = "Add a Quiz Name",
                ForeColor = Color.Gray,
                Name = "lblAddQuiz",
                Location = new Point(30, 100)
            };
            Button btn = new Button()
            {
                Width = 480,
                Height = 50,
                Location = new Point(30, 160),
                Font = new Font(Font.FontFamily, 12, FontStyle.Bold),
                Text = "+ADD",
                BackColor = Color.LightGray,
                Name = "btnAddQuiz",

            };
            btn.Click += AddQuiz;
            grpAdminAuthority.Controls.Add(lblAddQz);
            grpAdminAuthority.Controls.Add(lblShowAllQuiz);
            grpAdminAuthority.Controls.Add(lblShowMyQuiz);
            grpAdminAuthority.Controls.Add(tbx);
            grpAdminAuthority.Controls.Add(lbl);
            grpAdminAuthority.Controls.Add(btn);
        }

        
        private void AdminForm_Load(object sender, EventArgs e)
        {

            Label lblAddQz = new Label()
            {
                Location = new Point(10, 30),
                Width = 80,
                Font = new Font(Font.FontFamily, 11),
                ForeColor = Color.CornflowerBlue,
                Text = "Add Quiz"
            };

            Label lblShowAllQuiz = new Label()
            {
                Location = new Point(110, 30),
                Width = 130,
                Font = new Font(Font.FontFamily, 11),
                ForeColor = Color.CornflowerBlue,
                Text = "Show All Quizes"
            };
            

            Label lblShowMyQuiz = new Label()
            {
                Location = new Point(245, 30),
                Width = 150,
                Font = new Font(Font.FontFamily, 11),
                ForeColor = Color.CornflowerBlue,
                Text = "Show My Quizes"
            };

            TextBox tbx = new TextBox()
            {
                Width = 480,
                Height = 35,
                Location = new Point(30, 120),
                Name = "tbxAddQuiz",
                Font = new Font(Font.FontFamily, 11)
            };
            Label lbl = new Label()
            {
                Font = new Font(Font.FontFamily, 11, FontStyle.Bold),
                Width = 200,
                Text = "Add a Quiz Name",
                ForeColor = Color.Gray,
                Name = "lblAddQuiz",
                Location = new Point(30, 100)
            };
            Button btn = new Button()
            {
                Width = 480,
                Height = 50,
                Location = new Point(30, 160),
                Font = new Font(Font.FontFamily, 12, FontStyle.Bold),
                Text = "+ADD",
                BackColor = Color.LightGray,
                Name = "btnAddQuiz",

            };
            btn.Click += AddQuiz;
            grpAdminAuthority.Controls.Add(lblAddQz);
            grpAdminAuthority.Controls.Add(lblShowAllQuiz);
            grpAdminAuthority.Controls.Add(lblShowMyQuiz);
            grpAdminAuthority.Controls.Add(tbx);
            grpAdminAuthority.Controls.Add(lbl);
            grpAdminAuthority.Controls.Add(btn);
        }
        
        private void AddQuiz(object sender, EventArgs e)
        {
            
            foreach (var item in grpAdminAuthority.Controls)
            {
                if(item is TextBox)
                {
                    var tbx = item as TextBox;

                    Quiz quiz = new Quiz()
                    {
                        UserId = Db.Users.Where(userName => userName.UserFullName == lblAdminFullName.Text).First().UserId,
                        QuizName = tbx.Text
                    };
                    Db.Quizs.Add(quiz);
                    Db.SaveChanges();
                }
            }
            
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            UserStatu userStatus = new UserStatu()
            {
                UserId = Db.Users.Where(userName => userName.UserFullName == lblAdminFullName.Text).First().UserId,
                StatusType = Convert.ToBoolean(0)
            };
            QuizData.EndDate = DateTime.Now;
            Db.UserStatus.Add(userStatus);
            Db.SaveChanges();
            this.Hide();
        }

    }
}
