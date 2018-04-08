namespace Library_Managment_System.UI
{
    partial class SearchBook
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
            this.components = new System.ComponentModel.Container();
            this.label13 = new System.Windows.Forms.Label();
            this.contactoMenuStrip = new System.Windows.Forms.MenuStrip();
            this.contactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvShowBook = new System.Windows.Forms.DataGridView();
            this.borrowButton = new System.Windows.Forms.Button();
            this.borrowDateTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dueBackTextBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.noOfDaysTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contactoMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(807, 6);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 20);
            this.label13.TabIndex = 41;
            this.label13.Text = "Current Date:";
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
            this.contactoMenuStrip.Size = new System.Drawing.Size(1165, 28);
            this.contactoMenuStrip.TabIndex = 40;
            this.contactoMenuStrip.Text = "menuStrip1";
            this.contactoMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contactoMenuStrip_ItemClicked);
            // 
            // contactoToolStripMenuItem
            // 
            this.contactoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.signoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contactoToolStripMenuItem.Image = global::Library_Managment_System.UI.Properties.Resources.contact;
            this.contactoToolStripMenuItem.Name = "contactoToolStripMenuItem";
            this.contactoToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.contactoToolStripMenuItem.Text = "Profile";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::Library_Managment_System.UI.Properties.Resources.bookself;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.editToolStripMenuItem.Text = "MyBookSelf";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.myBookSelfToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Image = global::Library_Managment_System.UI.Properties.Resources.browsebook;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.removeToolStripMenuItem.Text = "Browse Book";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::Library_Managment_System.UI.Properties.Resources.refresh;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // signoutToolStripMenuItem
            // 
            this.signoutToolStripMenuItem.Image = global::Library_Managment_System.UI.Properties.Resources.signout;
            this.signoutToolStripMenuItem.Name = "signoutToolStripMenuItem";
            this.signoutToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.signoutToolStripMenuItem.Text = "Signout";
            this.signoutToolStripMenuItem.Click += new System.EventHandler(this.signoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Library_Managment_System.UI.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
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
            // dgvShowBook
            // 
            this.dgvShowBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvShowBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowBook.Location = new System.Drawing.Point(3, 94);
            this.dgvShowBook.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvShowBook.Name = "dgvShowBook";
            this.dgvShowBook.Size = new System.Drawing.Size(1160, 265);
            this.dgvShowBook.TabIndex = 42;
            // 
            // borrowButton
            // 
            this.borrowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowButton.Location = new System.Drawing.Point(941, 378);
            this.borrowButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(101, 36);
            this.borrowButton.TabIndex = 43;
            this.borrowButton.Text = "Borrow";
            this.borrowButton.UseVisualStyleBackColor = true;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // borrowDateTextBox
            // 
            this.borrowDateTextBox.Location = new System.Drawing.Point(207, 380);
            this.borrowDateTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.borrowDateTextBox.Multiline = true;
            this.borrowDateTextBox.Name = "borrowDateTextBox";
            this.borrowDateTextBox.Size = new System.Drawing.Size(145, 31);
            this.borrowDateTextBox.TabIndex = 44;
            this.borrowDateTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 384);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 41;
            this.label1.Text = "Borrow Date: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(620, 384);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 28);
            this.label2.TabIndex = 41;
            this.label2.Text = "DateDueBack:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dueBackTextBox
            // 
            this.dueBackTextBox.Location = new System.Drawing.Point(773, 380);
            this.dueBackTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dueBackTextBox.Multiline = true;
            this.dueBackTextBox.Name = "dueBackTextBox";
            this.dueBackTextBox.ReadOnly = true;
            this.dueBackTextBox.Size = new System.Drawing.Size(145, 31);
            this.dueBackTextBox.TabIndex = 44;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(125, 44);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(272, 22);
            this.textBox3.TabIndex = 45;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(759, 44);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(272, 22);
            this.textBox4.TabIndex = 45;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Library_Managment_System.UI.Properties.Resources.catagory_books;
            this.pictureBox2.Location = new System.Drawing.Point(708, 41);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Catagory");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Managment_System.UI.Properties.Resources.search_512;
            this.pictureBox1.Location = new System.Drawing.Point(76, 41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Search");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.searchhOver);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(924, 10);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(36, 17);
            this.dateLabel.TabIndex = 47;
            this.dateLabel.Text = "date";
            this.dateLabel.Click += new System.EventHandler(this.dateLabel_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // noOfDaysTextBox
            // 
            this.noOfDaysTextBox.Location = new System.Drawing.Point(544, 380);
            this.noOfDaysTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.noOfDaysTextBox.Multiline = true;
            this.noOfDaysTextBox.Name = "noOfDaysTextBox";
            this.noOfDaysTextBox.Size = new System.Drawing.Size(65, 31);
            this.noOfDaysTextBox.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(379, 384);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 23);
            this.label3.TabIndex = 41;
            this.label3.Text = "Numbr Of Days:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1011, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Time:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(1076, 10);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(34, 17);
            this.timeLabel.TabIndex = 47;
            this.timeLabel.Text = "time";
            this.timeLabel.Click += new System.EventHandler(this.dateLabel_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // SearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 444);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dueBackTextBox);
            this.Controls.Add(this.noOfDaysTextBox);
            this.Controls.Add(this.borrowDateTextBox);
            this.Controls.Add(this.borrowButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvShowBook);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.contactoMenuStrip);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "SearchBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browse Book";
            this.Load += new System.EventHandler(this.BrowseBook_Load);
            this.contactoMenuStrip.ResumeLayout(false);
            this.contactoMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MenuStrip contactoMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem contactoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvShowBook;
        private System.Windows.Forms.Button borrowButton;
        private System.Windows.Forms.TextBox borrowDateTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dueBackTextBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem signoutToolStripMenuItem;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox noOfDaysTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}