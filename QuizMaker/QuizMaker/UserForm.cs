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
    public partial class UserForm : Form
    {
        QuizMakerEntities Db = new QuizMakerEntities();
       
        public List<Question> questionList { get; set; }
        public string LabelText
        {
            get
            {
                return this.lblUserFullname.Text;
            }
            set
            {
                this.lblUserFullname.Text = value;
            }
        }
        public UserForm()
        {
            InitializeComponent();
            

        }

        

        private void lblLogOut_Click(object sender, EventArgs e)
        {

            UserStatu userStatus = new UserStatu()
            {
                UserId = Db.Users.Where(userName => userName.UserFullName == lblUserFullname.Text).First().UserId,
                StatusType = Convert.ToBoolean(0)
            };
            Db.UserStatus.Add(userStatus);
            Db.SaveChanges();
            this.Hide();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            foreach (var item in Db.Quizs)
            {
                cbxUserSelectQuizName.Items.Add(item.QuizName);
                cbxUserSelectQuizName.ForeColor = Color.Black;
            }
            foreach (var item in Db.QuestionTypes)
            {
                cbxUserSelectQuestionType.Items.Add(item.TypeName);
                cbxUserSelectQuestionType.ForeColor = Color.Black;
                
            }
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
           
            foreach (var item in Controls)
            {
                if(item is ComboBox)
                {
                    var cbx = item as ComboBox;
                    if(cbx.Name== "cbxUserSelectQuizName")
                    {
                        //MessageBox.Show(Db.Quizs.Where(quiz => quiz.QuizName == cbx.SelectedItem.ToString()).First().QuizId.ToString());
                        QuizData.QuizNameId = Db.Quizs.Where(quizNameId => quizNameId.QuizName == cbx.SelectedItem.ToString()).First().QuizId;
                      
                    }
                    if(cbx.Name== "cbxUserSelectQuestionType")
                    {
                        QuizData.QuestionTypeId = Db.QuestionTypes.Where(type => type.TypeName == cbx.SelectedItem.ToString()).First().TypeId;
                    }
                   
                }
                
            }
            var list = new List<Question>();
            list = Db.Questions.ToList();
            foreach (var item in list)
            {
                if (item.QuestionTypeId == QuizData.QuestionTypeId)
                {
                    questionList.Add(item);
                }
            }
            
            QuizForm quiz = new QuizForm();
            quiz.Show();

        }
    }
}
