﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library_Managment_System.Entity;

namespace Library_Managment_System.UI
{
    public partial class UserInfo : Form
    {

        string userId, password;
        public UserInfo(string userIds,string passwords)
        {
            this.userId = userIds;
            this.password = passwords;
            
           
            InitializeComponent();
            
           
        }
        private void toolStripSeparator3_Click(object sender, EventArgs e)
        {

        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            //DateTime now = DateTime.Now;
            //string date =string.Format("{0}.{1}.{2}", now.Year, now.Month, now.Day);
            string date = DateTime.Now.ToLongDateString();
            dateLabel.Text = date;
            //User user=new User();
            LibraryDBDataContext cntx = new LibraryDBDataContext(Library_Managment_System.UI.Properties.Settings.Default.librarydbConnectionString);

            var q = from a in cntx.Users// where user.UserId.Contains("1232")
                    select a;

            try
            {
                User user = q.Where(obj => obj.UserId == this.userId && obj.Password == this.password).First();// int.Parse(idTextBox.Text)).First();
                                                                                                               //titleTxtBox.Text = user.Title;
                userIdTxtBox.Text = user.UserId;
                userNameTxtBox.Text = user.UserName; ;
                emailTxtBox.Text = user.Email;
                passwordTxtBox.Text = user.Password;
                addressTxtBox.Text = user.Address;
                dobTxtBox.Text = user.DOB;
            }
           catch { MessageBox.Show("Wrong login info"); Close(); }


        }

        private void contactoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contactoMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bookSelfButton_Click(object sender, EventArgs e)
        {

            new MyBookSelf(userIdTxtBox.Text).ShowDialog();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            new SearchBook(userIdTxtBox.Text).ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
