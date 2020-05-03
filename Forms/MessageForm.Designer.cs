namespace FacebookUI
{
    partial class MessageForm
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
        protected void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.messageDGV = new System.Windows.Forms.DataGridView();
            this.msgTxtBox = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.charLbl = new System.Windows.Forms.Label();
            this.toTxtBox = new System.Windows.Forms.TextBox();
            this.msgLbl = new System.Windows.Forms.Label();
            this.multiMsgBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.messageDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // messageDGV
            // 
            this.messageDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.messageDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.messageDGV.Location = new System.Drawing.Point(12, 92);
            this.messageDGV.Name = "messageDGV";
            this.messageDGV.Size = new System.Drawing.Size(1329, 580);
            this.messageDGV.TabIndex = 0;
            this.messageDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.messageDGV_DataBindingComplete);
            // 
            // msgTxtBox
            // 
            this.msgTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgTxtBox.Location = new System.Drawing.Point(12, 678);
            this.msgTxtBox.Name = "msgTxtBox";
            this.msgTxtBox.Size = new System.Drawing.Size(1329, 29);
            this.msgTxtBox.TabIndex = 1;
            this.msgTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.msgTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.msgTxtBox_KeyDown);
            // 
            // sendBtn
            // 
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.Location = new System.Drawing.Point(1247, 713);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(94, 39);
            this.sendBtn.TabIndex = 5;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // charLbl
            // 
            this.charLbl.AutoSize = true;
            this.charLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.charLbl.Location = new System.Drawing.Point(1184, 710);
            this.charLbl.Name = "charLbl";
            this.charLbl.Size = new System.Drawing.Size(57, 20);
            this.charLbl.TabIndex = 6;
            this.charLbl.Text = "0 / 255";
            // 
            // toTxtBox
            // 
            this.toTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toTxtBox.Location = new System.Drawing.Point(12, 57);
            this.toTxtBox.Name = "toTxtBox";
            this.toTxtBox.ReadOnly = true;
            this.toTxtBox.Size = new System.Drawing.Size(1329, 29);
            this.toTxtBox.TabIndex = 7;
            // 
            // msgLbl
            // 
            this.msgLbl.AutoSize = true;
            this.msgLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLbl.Location = new System.Drawing.Point(12, 27);
            this.msgLbl.Name = "msgLbl";
            this.msgLbl.Size = new System.Drawing.Size(112, 24);
            this.msgLbl.TabIndex = 11;
            this.msgLbl.Text = "Messaging: ";
            // 
            // multiMsgBtn
            // 
            this.multiMsgBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiMsgBtn.Location = new System.Drawing.Point(1061, 12);
            this.multiMsgBtn.Name = "multiMsgBtn";
            this.multiMsgBtn.Size = new System.Drawing.Size(280, 39);
            this.multiMsgBtn.TabIndex = 12;
            this.multiMsgBtn.Text = "Message Multiple People";
            this.multiMsgBtn.UseVisualStyleBackColor = true;
            this.multiMsgBtn.Click += new System.EventHandler(this.multiMsgBtn_Click);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 760);
            this.Controls.Add(this.multiMsgBtn);
            this.Controls.Add(this.msgLbl);
            this.Controls.Add(this.toTxtBox);
            this.Controls.Add(this.charLbl);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.msgTxtBox);
            this.Controls.Add(this.messageDGV);
            this.Name = "MessageForm";
            this.Text = "MessageForm";
            ((System.ComponentModel.ISupportInitialize)(this.messageDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.DataGridView messageDGV;
        protected System.Windows.Forms.TextBox msgTxtBox;
        protected System.Windows.Forms.Button sendBtn;
        protected System.Windows.Forms.Label charLbl;
        protected System.Windows.Forms.TextBox toTxtBox;
        protected System.Windows.Forms.Label msgLbl;
        protected System.Windows.Forms.Button multiMsgBtn;
    }
}