namespace FacebookUI
{
    partial class FriendsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.friendsBtn = new System.Windows.Forms.Button();
            this.msgBtn = new System.Windows.Forms.Button();
            this.friendsDGV = new System.Windows.Forms.DataGridView();
            this.viewProfileBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.friendsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // friendsBtn
            // 
            this.friendsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendsBtn.Location = new System.Drawing.Point(12, 486);
            this.friendsBtn.Name = "friendsBtn";
            this.friendsBtn.Size = new System.Drawing.Size(160, 39);
            this.friendsBtn.TabIndex = 7;
            this.friendsBtn.Text = "Remove Friend";
            this.friendsBtn.UseVisualStyleBackColor = true;
            this.friendsBtn.Click += new System.EventHandler(this.friendsBtn_Click);
            // 
            // msgBtn
            // 
            this.msgBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgBtn.Location = new System.Drawing.Point(196, 486);
            this.msgBtn.Name = "msgBtn";
            this.msgBtn.Size = new System.Drawing.Size(160, 39);
            this.msgBtn.TabIndex = 8;
            this.msgBtn.Text = "Message";
            this.msgBtn.UseVisualStyleBackColor = true;
            // 
            // friendsDGV
            // 
            this.friendsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.friendsDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.friendsDGV.Location = new System.Drawing.Point(12, 12);
            this.friendsDGV.Name = "friendsDGV";
            this.friendsDGV.Size = new System.Drawing.Size(343, 468);
            this.friendsDGV.TabIndex = 9;
            // 
            // viewProfileBtn
            // 
            this.viewProfileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProfileBtn.Location = new System.Drawing.Point(12, 486);
            this.viewProfileBtn.Name = "viewProfileBtn";
            this.viewProfileBtn.Size = new System.Drawing.Size(160, 39);
            this.viewProfileBtn.TabIndex = 10;
            this.viewProfileBtn.Text = "View Profile";
            this.viewProfileBtn.UseVisualStyleBackColor = true;
            this.viewProfileBtn.Click += new System.EventHandler(this.viewProfileBtn_Click);
            // 
            // FriendsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 537);
            this.Controls.Add(this.viewProfileBtn);
            this.Controls.Add(this.friendsDGV);
            this.Controls.Add(this.msgBtn);
            this.Controls.Add(this.friendsBtn);
            this.Name = "FriendsForm";
            this.Text = "FriendsForm";
            ((System.ComponentModel.ISupportInitialize)(this.friendsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button friendsBtn;
        private System.Windows.Forms.Button msgBtn;
        private System.Windows.Forms.DataGridView friendsDGV;
        private System.Windows.Forms.Button viewProfileBtn;
    }
}