namespace Library_Managment_System.UI
{
    partial class MyBookSelf
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
            this.dgvBookSelf = new System.Windows.Forms.DataGridView();
            this.UsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.returnButton = new System.Windows.Forms.Button();
            this.returndatetxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookSelf)).BeginInit();
            this.contactoMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBookSelf
            // 
            this.dgvBookSelf.BackgroundColor = System.Drawing.Color.White;
            this.dgvBookSelf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookSelf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsId});
            this.dgvBookSelf.Location = new System.Drawing.Point(3, 69);
            this.dgvBookSelf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBookSelf.Name = "dgvBookSelf";
            this.dgvBookSelf.Size = new System.Drawing.Size(957, 289);
            this.dgvBookSelf.TabIndex = 0;
            this.dgvBookSelf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookSelf_CellContentClick);
            // 
            // UsId
            // 
            this.UsId.DataPropertyName = "UserId";
            this.UsId.HeaderText = "UserId";
            this.UsId.Name = "UsId";
            this.UsId.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(596, 5);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 20);
            this.label13.TabIndex = 41;
            this.label13.Text = "Current Date";
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
            this.contactoMenuStrip.Size = new System.Drawing.Size(963, 28);
            this.contactoMenuStrip.TabIndex = 40;
            this.contactoMenuStrip.Text = "menuStrip1";
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
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(167, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::Library_Managment_System.UI.Properties.Resources.bookself;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.editToolStripMenuItem.Text = "MyBookSelf";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Image = global::Library_Managment_System.UI.Properties.Resources.browsebook;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.removeToolStripMenuItem.Text = "Browse Book";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.searchBookToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
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
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Library_Managment_System.UI.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Image = global::Library_Managment_System.UI.Properties.Resources.help;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(711, 5);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(83, 22);
            this.dateLabel.TabIndex = 48;
            this.dateLabel.Text = "date";
            this.dateLabel.Click += new System.EventHandler(this.dateLabel_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(871, 5);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(34, 17);
            this.timeLabel.TabIndex = 50;
            this.timeLabel.Text = "time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(805, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Time:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Location = new System.Drawing.Point(79, 379);
            this.returnButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(100, 34);
            this.returnButton.TabIndex = 51;
            this.returnButton.Text = "Return";
            this.returnButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // returndatetxtBox
            // 
            this.returndatetxtBox.Location = new System.Drawing.Point(215, 385);
            this.returndatetxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.returndatetxtBox.Name = "returndatetxtBox";
            this.returndatetxtBox.Size = new System.Drawing.Size(132, 22);
            this.returndatetxtBox.TabIndex = 52;
            this.returndatetxtBox.Tag = "";
            // 
            // MyBookSelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 428);
            this.Controls.Add(this.returndatetxtBox);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.contactoMenuStrip);
            this.Controls.Add(this.dgvBookSelf);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MyBookSelf";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Self";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MyBookSelf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookSelf)).EndInit();
            this.contactoMenuStrip.ResumeLayout(false);
            this.contactoMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookSelf;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MenuStrip contactoMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem contactoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signoutToolStripMenuItem;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsId;
        private System.Windows.Forms.TextBox returndatetxtBox;
    }
}