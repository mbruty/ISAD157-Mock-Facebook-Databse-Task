namespace FacebookUI.Forms
{
    partial class CreateProfile
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
            this.profileBox = new System.Windows.Forms.GroupBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.homeTxtBox = new System.Windows.Forms.TextBox();
            this.genderCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.currCityTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.relationshipCombo = new System.Windows.Forms.ComboBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.maxInputLbl = new System.Windows.Forms.Label();
            this.profileBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // profileBox
            // 
            this.profileBox.Controls.Add(this.maxInputLbl);
            this.profileBox.Controls.Add(this.submitBtn);
            this.profileBox.Controls.Add(this.label5);
            this.profileBox.Controls.Add(this.relationshipCombo);
            this.profileBox.Controls.Add(this.label4);
            this.profileBox.Controls.Add(this.currCityTxtBox);
            this.profileBox.Controls.Add(this.label3);
            this.profileBox.Controls.Add(this.homeTxtBox);
            this.profileBox.Controls.Add(this.label2);
            this.profileBox.Controls.Add(this.genderCombo);
            this.profileBox.Controls.Add(this.label1);
            this.profileBox.Controls.Add(this.nameTxtBox);
            this.profileBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBox.Location = new System.Drawing.Point(12, 12);
            this.profileBox.Name = "profileBox";
            this.profileBox.Size = new System.Drawing.Size(282, 385);
            this.profileBox.TabIndex = 0;
            this.profileBox.TabStop = false;
            this.profileBox.Text = "Profile";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(6, 66);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(267, 29);
            this.nameTxtBox.TabIndex = 0;
            this.nameTxtBox.TextChanged += new System.EventHandler(this.checkTxtBoxSize);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Home Town";
            // 
            // homeTxtBox
            // 
            this.homeTxtBox.Location = new System.Drawing.Point(6, 187);
            this.homeTxtBox.Name = "homeTxtBox";
            this.homeTxtBox.Size = new System.Drawing.Size(267, 29);
            this.homeTxtBox.TabIndex = 4;
            this.homeTxtBox.TextChanged += new System.EventHandler(this.checkTxtBoxSize);
            // 
            // genderCombo
            // 
            this.genderCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCombo.FormattingEnabled = true;
            this.genderCombo.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Unspecified"});
            this.genderCombo.Location = new System.Drawing.Point(6, 125);
            this.genderCombo.Name = "genderCombo";
            this.genderCombo.Size = new System.Drawing.Size(267, 32);
            this.genderCombo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Current City";
            // 
            // currCityTxtBox
            // 
            this.currCityTxtBox.Location = new System.Drawing.Point(6, 246);
            this.currCityTxtBox.Name = "currCityTxtBox";
            this.currCityTxtBox.Size = new System.Drawing.Size(267, 29);
            this.currCityTxtBox.TabIndex = 6;
            this.currCityTxtBox.TextChanged += new System.EventHandler(this.checkTxtBoxSize);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Relationship Status";
            // 
            // relationshipCombo
            // 
            this.relationshipCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.relationshipCombo.FormattingEnabled = true;
            this.relationshipCombo.Items.AddRange(new object[] {
            "Single",
            "Engaged",
            "Married",
            "It\'s Complicated"});
            this.relationshipCombo.Location = new System.Drawing.Point(6, 305);
            this.relationshipCombo.Name = "relationshipCombo";
            this.relationshipCombo.Size = new System.Drawing.Size(267, 32);
            this.relationshipCombo.TabIndex = 8;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(193, 343);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(80, 32);
            this.submitBtn.TabIndex = 10;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // maxInputLbl
            // 
            this.maxInputLbl.AutoSize = true;
            this.maxInputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxInputLbl.ForeColor = System.Drawing.Color.Maroon;
            this.maxInputLbl.Location = new System.Drawing.Point(89, 48);
            this.maxInputLbl.Name = "maxInputLbl";
            this.maxInputLbl.Size = new System.Drawing.Size(184, 12);
            this.maxInputLbl.TabIndex = 27;
            this.maxInputLbl.Text = "Maximum input for text box is 25 characters";
            // 
            // CreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 410);
            this.Controls.Add(this.profileBox);
            this.Name = "CreateProfile";
            this.Text = "CreateProfile";
            this.profileBox.ResumeLayout(false);
            this.profileBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox profileBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox relationshipCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox currCityTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox homeTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox genderCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label maxInputLbl;
    }
}