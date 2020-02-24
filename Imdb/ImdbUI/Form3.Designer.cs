namespace ImdbUI
{
    partial class Form3
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
            this.lblBornDate = new System.Windows.Forms.Label();
            this.lblNameSurnameInfo = new System.Windows.Forms.Label();
            this.pcxImageInfo = new System.Windows.Forms.PictureBox();
            this.lbxNameSurname = new System.Windows.Forms.ListBox();
            this.rtbxInfo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcxImageInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBornDate
            // 
            this.lblBornDate.AutoSize = true;
            this.lblBornDate.Location = new System.Drawing.Point(243, 90);
            this.lblBornDate.Name = "lblBornDate";
            this.lblBornDate.Size = new System.Drawing.Size(0, 13);
            this.lblBornDate.TabIndex = 9;
            // 
            // lblNameSurnameInfo
            // 
            this.lblNameSurnameInfo.AutoSize = true;
            this.lblNameSurnameInfo.Location = new System.Drawing.Point(243, 62);
            this.lblNameSurnameInfo.Name = "lblNameSurnameInfo";
            this.lblNameSurnameInfo.Size = new System.Drawing.Size(0, 13);
            this.lblNameSurnameInfo.TabIndex = 8;
            // 
            // pcxImageInfo
            // 
            this.pcxImageInfo.Location = new System.Drawing.Point(135, 1);
            this.pcxImageInfo.Name = "pcxImageInfo";
            this.pcxImageInfo.Size = new System.Drawing.Size(100, 108);
            this.pcxImageInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcxImageInfo.TabIndex = 7;
            this.pcxImageInfo.TabStop = false;
            // 
            // lbxNameSurname
            // 
            this.lbxNameSurname.FormattingEnabled = true;
            this.lbxNameSurname.Location = new System.Drawing.Point(2, 1);
            this.lbxNameSurname.Name = "lbxNameSurname";
            this.lbxNameSurname.Size = new System.Drawing.Size(127, 108);
            this.lbxNameSurname.TabIndex = 6;
            this.lbxNameSurname.SelectedIndexChanged += new System.EventHandler(this.lbxNameSurname_SelectedIndexChanged);
            // 
            // rtbxInfo
            // 
            this.rtbxInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbxInfo.Location = new System.Drawing.Point(0, 115);
            this.rtbxInfo.Name = "rtbxInfo";
            this.rtbxInfo.Size = new System.Drawing.Size(800, 335);
            this.rtbxInfo.TabIndex = 5;
            this.rtbxInfo.Text = "";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBornDate);
            this.Controls.Add(this.lblNameSurnameInfo);
            this.Controls.Add(this.pcxImageInfo);
            this.Controls.Add(this.lbxNameSurname);
            this.Controls.Add(this.rtbxInfo);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcxImageInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBornDate;
        private System.Windows.Forms.Label lblNameSurnameInfo;
        private System.Windows.Forms.PictureBox pcxImageInfo;
        private System.Windows.Forms.ListBox lbxNameSurname;
        private System.Windows.Forms.RichTextBox rtbxInfo;
    }
}