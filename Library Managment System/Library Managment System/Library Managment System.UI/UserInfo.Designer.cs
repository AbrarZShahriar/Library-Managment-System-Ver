namespace Library_Managment_System.UI
{
    partial class UserInfo
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
            this.dobTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addressTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userNameTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bookSelfButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contactoMenuStrip = new System.Windows.Forms.MenuStrip();
            this.contactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label13 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label2 = new System.Windows.Forms.Label();
            this.userIdTxtBox = new System.Windows.Forms.TextBox();
            this.contactoMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dobTxtBox
            // 
            this.dobTxtBox.Location = new System.Drawing.Point(221, 308);
            this.dobTxtBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dobTxtBox.Name = "dobTxtBox";
            this.dobTxtBox.Size = new System.Drawing.Size(199, 22);
            this.dobTxtBox.TabIndex = 29;
            this.dobTxtBox.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(80, 308);
            this.label7.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 29);
            this.label7.TabIndex = 21;
            this.label7.Text = "DOB:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Location = new System.Drawing.Point(221, 267);
            this.addressTxtBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(199, 22);
            this.addressTxtBox.TabIndex = 30;
            this.addressTxtBox.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 265);
            this.label6.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "Address:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(221, 228);
            this.passwordTxtBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(199, 22);
            this.passwordTxtBox.TabIndex = 31;
            this.passwordTxtBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "Password:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(221, 186);
            this.emailTxtBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(199, 22);
            this.emailTxtBox.TabIndex = 32;
            this.emailTxtBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "Email:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // userNameTxtBox
            // 
            this.userNameTxtBox.Location = new System.Drawing.Point(221, 145);
            this.userNameTxtBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.userNameTxtBox.Name = "userNameTxtBox";
            this.userNameTxtBox.Size = new System.Drawing.Size(199, 22);
            this.userNameTxtBox.TabIndex = 33;
            this.userNameTxtBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "User Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bookSelfButton
            // 
            this.bookSelfButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookSelfButton.Location = new System.Drawing.Point(128, 366);
            this.bookSelfButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookSelfButton.Name = "bookSelfButton";
            this.bookSelfButton.Size = new System.Drawing.Size(163, 42);
            this.bookSelfButton.TabIndex = 37;
            this.bookSelfButton.Text = "MyBookSelf";
            this.bookSelfButton.UseVisualStyleBackColor = true;
            this.bookSelfButton.Click += new System.EventHandler(this.bookSelfButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(299, 366);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 42);
            this.button1.TabIndex = 37;
            this.button1.Text = "Browse Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // contactoMenuStrip
            // 
            this.contactoMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contactoMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactoToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.contactoMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.contactoMenuStrip.Name = "contactoMenuStrip";
            this.contactoMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.contactoMenuStrip.Size = new System.Drawing.Size(823, 28);
            this.contactoMenuStrip.TabIndex = 38;
            this.contactoMenuStrip.Text = "menuStrip1";
            this.contactoMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contactoMenuStrip_ItemClicked);
            // 
            // contactoToolStripMenuItem
            // 
            this.contactoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.toolStripSeparator1,
            this.refreshToolStripMenuItem,
            this.signoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contactoToolStripMenuItem.Image = global::Library_Managment_System.UI.Properties.Resources.contact;
            this.contactoToolStripMenuItem.Name = "contactoToolStripMenuItem";
            this.contactoToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.contactoToolStripMenuItem.Text = "Profile";
            this.contactoToolStripMenuItem.Click += new System.EventHandler(this.contactoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
            this.toolStripSeparator3.Click += new System.EventHandler(this.toolStripSeparator3_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::Library_Managment_System.UI.Properties.Resources.bookself;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.editToolStripMenuItem.Text = "MyBookSelf";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Image = global::Library_Managment_System.UI.Properties.Resources.browsebook;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.removeToolStripMenuItem.Text = "Browse Book";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::Library_Managment_System.UI.Properties.Resources.refresh;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // signoutToolStripMenuItem
            // 
            this.signoutToolStripMenuItem.Image = global::Library_Managment_System.UI.Properties.Resources.signout;
            this.signoutToolStripMenuItem.Name = "signoutToolStripMenuItem";
            this.signoutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.signoutToolStripMenuItem.Text = "Signout";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Library_Managment_System.UI.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Image = global::Library_Managment_System.UI.Properties.Resources.help;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(516, 4);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 20);
            this.label13.TabIndex = 39;
            this.label13.Text = "Current Date:";
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(637, 4);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(133, 22);
            this.dateLabel.TabIndex = 40;
            this.dateLabel.Text = "date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "UserId:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // userIdTxtBox
            // 
            this.userIdTxtBox.Location = new System.Drawing.Point(221, 105);
            this.userIdTxtBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.userIdTxtBox.Name = "userIdTxtBox";
            this.userIdTxtBox.ReadOnly = true;
            this.userIdTxtBox.Size = new System.Drawing.Size(199, 22);
            this.userIdTxtBox.TabIndex = 34;
            this.userIdTxtBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 454);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.contactoMenuStrip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bookSelfButton);
            this.Controls.Add(this.dobTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addressTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userNameTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userIdTxtBox);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Userr Information";
            this.Load += new System.EventHandler(this.UserInfo_Load);
            this.contactoMenuStrip.ResumeLayout(false);
            this.contactoMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dobTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addressTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userNameTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bookSelfButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip contactoMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem contactoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripMenuItem signoutToolStripMenuItem;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userIdTxtBox;


    }
}