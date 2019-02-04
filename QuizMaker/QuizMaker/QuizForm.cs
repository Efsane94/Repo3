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
    public partial class QuizForm : Form
    {
        QuizMakerEntities Db = new QuizMakerEntities();
        UserForm userForm = new UserForm();
        int count = 1;


        public QuizForm()
        {
            InitializeComponent();
            
           
        }

       

        private void Leave(object sender, EventArgs e)
        {
            var rdBtn = sender as RadioButton;
            rdBtn.BackColor = Color.LightGray;
        }

        private void Move(object sender, MouseEventArgs e)
        {
            var rdBtn = sender as RadioButton;
            rdBtn.BackColor = Color.DarkGray;
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {

            lblQuestionTitle.Text = userForm.questionList.ElementAt(0).QuestionTitle;
            rdBtnVariantA.Text = userForm.questionList.ElementAt(0).AnswerA;
            rdBtnVariantB.Text = userForm.questionList.ElementAt(0).AnswerB;
            rdBtnVariantC.Text = userForm.questionList.ElementAt(0).AnswerC;
            rdBtnVariantD.Text = userForm.questionList.ElementAt(0).AnswerD;
            lblQuizName.Text = Db.Quizs.Where(id => id.QuizId == QuizData.QuizNameId).First().QuizName + " : " + Db.QuestionTypes.Where(id => id.TypeId == QuizData.QuestionTypeId).First().TypeName + "  level";

            ;


        }
        

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            foreach (var item in userForm.questionList)
            {
                MessageBox.Show(item.QuestionId.ToString());
            }

            //lblQuestionTitle.Text = questionList.ElementAt(count).QuestionTitle;
            //rdBtnVariantA.Text = questionList.ElementAt(count).AnswerA;
            //rdBtnVariantB.Text = questionList.ElementAt(count).AnswerB;
            //rdBtnVariantC.Text = questionList.ElementAt(count).AnswerC;
            //rdBtnVariantD.Text = questionList.ElementAt(count).AnswerD;
            //count++;
        }
    }
}
