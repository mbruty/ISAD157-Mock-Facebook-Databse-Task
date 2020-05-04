namespace FacebookUI
{
    partial class ProfileForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uniAddBtn = new System.Windows.Forms.Button();
            this.workplaceAddBtn = new System.Windows.Forms.Button();
            this.viewFrndRqBtn = new System.Windows.Forms.Button();
            this.unReadMsgsTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.viewMessagesBtn = new System.Windows.Forms.Button();
            this.friendRequestsTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.uniDGV = new System.Windows.Forms.DataGridView();
            this.messageBtn = new System.Windows.Forms.Button();
            this.addFriendBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.workplaceDGV = new System.Windows.Forms.DataGridView();
            this.removeFriendBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.relationshipLbl = new System.Windows.Forms.Label();
            this.genderLbl = new System.Windows.Forms.Label();
            this.friendsBtn = new System.Windows.Forms.Button();
            this.numFriendsTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.relationshipTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.currentCityTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.homeTownTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.genderTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dbConnectedPic = new System.Windows.Forms.PictureBox();
            this.maxInputLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uniDGV)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workplaceDGV)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbConnectedPic)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Controls.Add(this.searchTxtBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1085, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(984, 29);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(95, 29);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.AcceptsReturn = true;
            this.searchTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxtBox.Location = new System.Drawing.Point(6, 29);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(972, 29);
            this.searchTxtBox.TabIndex = 0;
            this.searchTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTxtBox_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uniAddBtn);
            this.groupBox2.Controls.Add(this.workplaceAddBtn);
            this.groupBox2.Controls.Add(this.viewFrndRqBtn);
            this.groupBox2.Controls.Add(this.unReadMsgsTxt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.viewMessagesBtn);
            this.groupBox2.Controls.Add(this.friendRequestsTxt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.saveChangesBtn);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.messageBtn);
            this.groupBox2.Controls.Add(this.addFriendBtn);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.removeFriendBtn);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1126, 552);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profile";
            // 
            // uniAddBtn
            // 
            this.uniAddBtn.Location = new System.Drawing.Point(1095, 370);
            this.uniAddBtn.Name = "uniAddBtn";
            this.uniAddBtn.Size = new System.Drawing.Size(25, 31);
            this.uniAddBtn.TabIndex = 32;
            this.uniAddBtn.Text = "+";
            this.uniAddBtn.UseVisualStyleBackColor = true;
            this.uniAddBtn.Click += new System.EventHandler(this.uniAddBtn_Click);
            // 
            // workplaceAddBtn
            // 
            this.workplaceAddBtn.Location = new System.Drawing.Point(1095, 128);
            this.workplaceAddBtn.Name = "workplaceAddBtn";
            this.workplaceAddBtn.Size = new System.Drawing.Size(25, 31);
            this.workplaceAddBtn.TabIndex = 31;
            this.workplaceAddBtn.Text = "+";
            this.workplaceAddBtn.UseVisualStyleBackColor = true;
            this.workplaceAddBtn.Click += new System.EventHandler(this.workplaceAddBtn_Click);
            // 
            // viewFrndRqBtn
            // 
            this.viewFrndRqBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewFrndRqBtn.Location = new System.Drawing.Point(919, 34);
            this.viewFrndRqBtn.Name = "viewFrndRqBtn";
            this.viewFrndRqBtn.Size = new System.Drawing.Size(201, 39);
            this.viewFrndRqBtn.TabIndex = 30;
            this.viewFrndRqBtn.Text = "View FriendRequests";
            this.viewFrndRqBtn.UseVisualStyleBackColor = true;
            this.viewFrndRqBtn.Click += new System.EventHandler(this.viewFrndRqBtn_Click);
            // 
            // unReadMsgsTxt
            // 
            this.unReadMsgsTxt.Location = new System.Drawing.Point(186, 44);
            this.unReadMsgsTxt.Name = "unReadMsgsTxt";
            this.unReadMsgsTxt.ReadOnly = true;
            this.unReadMsgsTxt.Size = new System.Drawing.Size(78, 29);
            this.unReadMsgsTxt.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(680, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 24);
            this.label9.TabIndex = 29;
            this.label9.Text = "Friend Requests";
            // 
            // viewMessagesBtn
            // 
            this.viewMessagesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMessagesBtn.Location = new System.Drawing.Point(270, 37);
            this.viewMessagesBtn.Name = "viewMessagesBtn";
            this.viewMessagesBtn.Size = new System.Drawing.Size(155, 39);
            this.viewMessagesBtn.TabIndex = 27;
            this.viewMessagesBtn.Text = "View Messages";
            this.viewMessagesBtn.UseVisualStyleBackColor = true;
            this.viewMessagesBtn.Click += new System.EventHandler(this.viewMessagesBtn_Click);
            // 
            // friendRequestsTxt
            // 
            this.friendRequestsTxt.Location = new System.Drawing.Point(835, 38);
            this.friendRequestsTxt.Name = "friendRequestsTxt";
            this.friendRequestsTxt.ReadOnly = true;
            this.friendRequestsTxt.Size = new System.Drawing.Size(78, 29);
            this.friendRequestsTxt.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 24);
            this.label8.TabIndex = 26;
            this.label8.Text = "Un-Read Messges";
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesBtn.Location = new System.Drawing.Point(6, 105);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(160, 39);
            this.saveChangesBtn.TabIndex = 5;
            this.saveChangesBtn.Text = "Save Changes";
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.uniDGV);
            this.groupBox5.Location = new System.Drawing.Point(434, 342);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(655, 204);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "University Information";
            // 
            // uniDGV
            // 
            this.uniDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uniDGV.Location = new System.Drawing.Point(6, 28);
            this.uniDGV.Name = "uniDGV";
            this.uniDGV.Size = new System.Drawing.Size(643, 164);
            this.uniDGV.TabIndex = 1;
            this.uniDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.uniDGV_DataBindingComplete);
            // 
            // messageBtn
            // 
            this.messageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageBtn.Location = new System.Drawing.Point(309, 105);
            this.messageBtn.Name = "messageBtn";
            this.messageBtn.Size = new System.Drawing.Size(105, 39);
            this.messageBtn.TabIndex = 4;
            this.messageBtn.Text = "Message";
            this.messageBtn.UseVisualStyleBackColor = true;
            this.messageBtn.Click += new System.EventHandler(this.messageBtn_Click);
            // 
            // addFriendBtn
            // 
            this.addFriendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFriendBtn.Location = new System.Drawing.Point(6, 105);
            this.addFriendBtn.Name = "addFriendBtn";
            this.addFriendBtn.Size = new System.Drawing.Size(160, 39);
            this.addFriendBtn.TabIndex = 2;
            this.addFriendBtn.Text = "Add Friend";
            this.addFriendBtn.UseVisualStyleBackColor = true;
            this.addFriendBtn.Click += new System.EventHandler(this.addFriendBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.workplaceDGV);
            this.groupBox4.Location = new System.Drawing.Point(434, 100);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(655, 231);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Workplace Information";
            // 
            // workplaceDGV
            // 
            this.workplaceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workplaceDGV.Location = new System.Drawing.Point(6, 28);
            this.workplaceDGV.Name = "workplaceDGV";
            this.workplaceDGV.Size = new System.Drawing.Size(643, 197);
            this.workplaceDGV.TabIndex = 0;
            this.workplaceDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.workplaceDGV_DataBindingComplete);
            // 
            // removeFriendBtn
            // 
            this.removeFriendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeFriendBtn.Location = new System.Drawing.Point(6, 105);
            this.removeFriendBtn.Name = "removeFriendBtn";
            this.removeFriendBtn.Size = new System.Drawing.Size(160, 39);
            this.removeFriendBtn.TabIndex = 3;
            this.removeFriendBtn.Text = "Remove Friend";
            this.removeFriendBtn.UseVisualStyleBackColor = true;
            this.removeFriendBtn.Click += new System.EventHandler(this.removeFriendBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.maxInputLbl);
            this.groupBox3.Controls.Add(this.relationshipLbl);
            this.groupBox3.Controls.Add(this.genderLbl);
            this.groupBox3.Controls.Add(this.friendsBtn);
            this.groupBox3.Controls.Add(this.numFriendsTxtBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.relationshipTxtBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.currentCityTxtBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.homeTownTxtBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.genderTxtBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lastNameTxtBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.firstNameTxtBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(408, 396);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "User Information";
            // 
            // relationshipLbl
            // 
            this.relationshipLbl.AutoSize = true;
            this.relationshipLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relationshipLbl.ForeColor = System.Drawing.Color.Maroon;
            this.relationshipLbl.Location = new System.Drawing.Point(43, 265);
            this.relationshipLbl.Name = "relationshipLbl";
            this.relationshipLbl.Size = new System.Drawing.Size(325, 12);
            this.relationshipLbl.TabIndex = 25;
            this.relationshipLbl.Text = "*Relationship Status can only be | Single | Engaged | Married | It\'s Complicated " +
    "|";
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLbl.ForeColor = System.Drawing.Color.Maroon;
            this.genderLbl.Location = new System.Drawing.Point(158, 145);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(210, 12);
            this.genderLbl.TabIndex = 24;
            this.genderLbl.Text = "*Gender can only be | Female | Male | Unspecified |";
            // 
            // friendsBtn
            // 
            this.friendsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendsBtn.Location = new System.Drawing.Point(14, 345);
            this.friendsBtn.Name = "friendsBtn";
            this.friendsBtn.Size = new System.Drawing.Size(160, 39);
            this.friendsBtn.TabIndex = 6;
            this.friendsBtn.Text = "Show Friends";
            this.friendsBtn.UseVisualStyleBackColor = true;
            this.friendsBtn.Click += new System.EventHandler(this.friendsBtn_Click);
            // 
            // numFriendsTxtBox
            // 
            this.numFriendsTxtBox.Location = new System.Drawing.Point(180, 280);
            this.numFriendsTxtBox.Name = "numFriendsTxtBox";
            this.numFriendsTxtBox.ReadOnly = true;
            this.numFriendsTxtBox.Size = new System.Drawing.Size(188, 29);
            this.numFriendsTxtBox.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Number of Friends";
            // 
            // relationshipTxtBox
            // 
            this.relationshipTxtBox.Location = new System.Drawing.Point(180, 233);
            this.relationshipTxtBox.Name = "relationshipTxtBox";
            this.relationshipTxtBox.ReadOnly = true;
            this.relationshipTxtBox.Size = new System.Drawing.Size(188, 29);
            this.relationshipTxtBox.TabIndex = 21;
            this.relationshipTxtBox.TextChanged += new System.EventHandler(this.relationshipTxtBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Relationship Status";
            // 
            // currentCityTxtBox
            // 
            this.currentCityTxtBox.Location = new System.Drawing.Point(180, 198);
            this.currentCityTxtBox.Name = "currentCityTxtBox";
            this.currentCityTxtBox.ReadOnly = true;
            this.currentCityTxtBox.Size = new System.Drawing.Size(188, 29);
            this.currentCityTxtBox.TabIndex = 19;
            this.currentCityTxtBox.TextChanged += new System.EventHandler(this.checkTxtBoxSize);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Current City";
            // 
            // homeTownTxtBox
            // 
            this.homeTownTxtBox.Location = new System.Drawing.Point(180, 162);
            this.homeTownTxtBox.Name = "homeTownTxtBox";
            this.homeTownTxtBox.ReadOnly = true;
            this.homeTownTxtBox.Size = new System.Drawing.Size(188, 29);
            this.homeTownTxtBox.TabIndex = 17;
            this.homeTownTxtBox.TextChanged += new System.EventHandler(this.checkTxtBoxSize);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Home Town";
            // 
            // genderTxtBox
            // 
            this.genderTxtBox.Location = new System.Drawing.Point(180, 113);
            this.genderTxtBox.Name = "genderTxtBox";
            this.genderTxtBox.ReadOnly = true;
            this.genderTxtBox.Size = new System.Drawing.Size(188, 29);
            this.genderTxtBox.TabIndex = 15;
            this.genderTxtBox.TextChanged += new System.EventHandler(this.genderTxtBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Gender";
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.Location = new System.Drawing.Point(180, 78);
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.ReadOnly = true;
            this.lastNameTxtBox.Size = new System.Drawing.Size(188, 29);
            this.lastNameTxtBox.TabIndex = 13;
            this.lastNameTxtBox.TextChanged += new System.EventHandler(this.checkTxtBoxSize);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Last Name";
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.Location = new System.Drawing.Point(180, 44);
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.ReadOnly = true;
            this.firstNameTxtBox.Size = new System.Drawing.Size(188, 29);
            this.firstNameTxtBox.TabIndex = 11;
            this.firstNameTxtBox.TextChanged += new System.EventHandler(this.checkTxtBoxSize);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "First Name";
            // 
            // dbConnectedPic
            // 
            this.dbConnectedPic.Image = global::FacebookUI.Properties.Resources.baseline_cached_black_18dp;
            this.dbConnectedPic.Location = new System.Drawing.Point(1107, 12);
            this.dbConnectedPic.Name = "dbConnectedPic";
            this.dbConnectedPic.Size = new System.Drawing.Size(35, 33);
            this.dbConnectedPic.TabIndex = 2;
            this.dbConnectedPic.TabStop = false;
            // 
            // maxInputLbl
            // 
            this.maxInputLbl.AutoSize = true;
            this.maxInputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxInputLbl.ForeColor = System.Drawing.Color.Maroon;
            this.maxInputLbl.Location = new System.Drawing.Point(178, 25);
            this.maxInputLbl.Name = "maxInputLbl";
            this.maxInputLbl.Size = new System.Drawing.Size(184, 12);
            this.maxInputLbl.TabIndex = 26;
            this.maxInputLbl.Text = "Maximum input for text box is 25 characters";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 666);
            this.Controls.Add(this.dbConnectedPic);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProfileForm_FormClosing);
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uniDGV)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workplaceDGV)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbConnectedPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView workplaceDGV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox relationshipTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox currentCityTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox homeTownTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox genderTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button addFriendBtn;
        private System.Windows.Forms.Button removeFriendBtn;
        private System.Windows.Forms.Button messageBtn;
        private System.Windows.Forms.PictureBox dbConnectedPic;
        private System.Windows.Forms.DataGridView uniDGV;
        private System.Windows.Forms.Button saveChangesBtn;
        private System.Windows.Forms.Button friendsBtn;
        private System.Windows.Forms.TextBox numFriendsTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.Label relationshipLbl;
        private System.Windows.Forms.Button viewFrndRqBtn;
        private System.Windows.Forms.TextBox unReadMsgsTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button viewMessagesBtn;
        private System.Windows.Forms.TextBox friendRequestsTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button uniAddBtn;
        private System.Windows.Forms.Button workplaceAddBtn;
        private System.Windows.Forms.Label maxInputLbl;
    }
}