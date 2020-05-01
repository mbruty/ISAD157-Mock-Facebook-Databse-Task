namespace FacebookUI
{
    partial class ProfilePicker
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
            this.profilesDGV = new System.Windows.Forms.DataGridView();
            this.viewProfileBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // profilesDGV
            // 
            this.profilesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.profilesDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.profilesDGV.Location = new System.Drawing.Point(12, 12);
            this.profilesDGV.Name = "profilesDGV";
            this.profilesDGV.Size = new System.Drawing.Size(520, 335);
            this.profilesDGV.TabIndex = 0;
            // 
            // viewProfileBtn
            // 
            this.viewProfileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProfileBtn.Location = new System.Drawing.Point(397, 353);
            this.viewProfileBtn.Name = "viewProfileBtn";
            this.viewProfileBtn.Size = new System.Drawing.Size(135, 39);
            this.viewProfileBtn.TabIndex = 6;
            this.viewProfileBtn.Text = "View Profile";
            this.viewProfileBtn.UseVisualStyleBackColor = true;
            this.viewProfileBtn.Click += new System.EventHandler(this.viewProfileBtn_Click);
            // 
            // ProfilePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 399);
            this.Controls.Add(this.viewProfileBtn);
            this.Controls.Add(this.profilesDGV);
            this.Name = "ProfilePicker";
            this.Text = "ProfilePicker";
            ((System.ComponentModel.ISupportInitialize)(this.profilesDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView profilesDGV;
        private System.Windows.Forms.Button viewProfileBtn;
    }
}