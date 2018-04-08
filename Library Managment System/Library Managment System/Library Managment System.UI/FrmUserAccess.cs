using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Managment_System.UI
{
    public partial class FrmUserAccess : Form
    {
        public FrmUserAccess()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmUserAccessForm_Load(object sender, EventArgs e)
        {

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
             new UserRegistration().ShowDialog();
             

             
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userId, userPassword;
            string adminName = "Admin";
            string adminPass = "Admin";
            userId=UserIdBox.Text;
            userPassword=userPasswordBox.Text;
            

            if (userId == adminName && userPassword == adminPass)
            {
                new AdminSite().ShowDialog();
            }
            else
            {
               
                    new UserInfo(userId, userPassword).ShowDialog();
                
               

            }

        }


    }
}
