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
    public partial class LoginForm : Form
    {
        
        QuizMakerEntities Db = new QuizMakerEntities();
        User activeUser;
        public LoginForm()
        {
            InitializeComponent();


        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbxEmail.Text;
            string password = tbxPassword.Text;
            
            if (Db.Users.Any(user => user.UserEmail == email))
            {
                if (Db.Users.Any(pass => pass.UserPassword == password))
                {
                    if (Db.Users.Where(user => user.UserEmail == email).First().UserTypeId==1)
                    {
                        activeUser = Db.Users.Where(user => user.UserEmail == email).First();
                        var adminForm = new AdminForm();
                        adminForm.LabelText = activeUser.UserFullName;
                        adminForm.Show();
                    }
                    else
                    {
                        activeUser = Db.Users.Where(user => user.UserEmail == email).First();
                        UserForm userForm = new UserForm();
                        userForm.LabelText = activeUser.UserFullName;
                        userForm.Show();
                    }


                    UserLog userLog = new UserLog()
                    {
                        UserId = activeUser.UserId,
                        BeginDate = DateTime.Now,
                        EndDate = DateTime.Now
                    };

                    UserStatu userStatus = new UserStatu()
                    {
                        UserId = activeUser.UserId,
                        StatusType = Convert.ToBoolean(1)
                    };

                    Db.UserLogs.Add(userLog);
                    Db.UserStatus.Add(userStatus);
                    Db.SaveChanges();

                }
                else
                {
                    MessageBox.Show("Incorrect Password","Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
