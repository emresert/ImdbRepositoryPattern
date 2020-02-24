namespace ImdbUI
{
    partial class Form2
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblForm2Description = new System.Windows.Forms.Label();
            this.rtbxDescription = new System.Windows.Forms.RichTextBox();
            this.lblForm2Director = new System.Windows.Forms.Label();
            this.lblForm2Writer = new System.Windows.Forms.Label();
            this.rtbxDirectors = new System.Windows.Forms.RichTextBox();
            this.lblForm2Stars = new System.Windows.Forms.Label();
            this.rtbxWriters = new System.Windows.Forms.RichTextBox();
            this.lblForm2MovieName = new System.Windows.Forms.Label();
            this.rtbxStars = new System.Windows.Forms.RichTextBox();
            this.rtbxMovieName = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(575, 395);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 35);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Check and Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(575, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 35);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Check and Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblForm2Description
            // 
            this.lblForm2Description.AutoSize = true;
            this.lblForm2Description.Location = new System.Drawing.Point(109, 279);
            this.lblForm2Description.Name = "lblForm2Description";
            this.lblForm2Description.Size = new System.Drawing.Size(60, 13);
            this.lblForm2Description.TabIndex = 9;
            this.lblForm2Description.Text = "Description";
            // 
            // rtbxDescription
            // 
            this.rtbxDescription.Location = new System.Drawing.Point(214, 245);
            this.rtbxDescription.Name = "rtbxDescription";
            this.rtbxDescription.Size = new System.Drawing.Size(478, 88);
            this.rtbxDescription.TabIndex = 4;
            this.rtbxDescription.Text = "";
            // 
            // lblForm2Director
            // 
            this.lblForm2Director.AutoSize = true;
            this.lblForm2Director.Location = new System.Drawing.Point(109, 193);
            this.lblForm2Director.Name = "lblForm2Director";
            this.lblForm2Director.Size = new System.Drawing.Size(49, 13);
            this.lblForm2Director.TabIndex = 10;
            this.lblForm2Director.Text = "Directors";
            // 
            // lblForm2Writer
            // 
            this.lblForm2Writer.AutoSize = true;
            this.lblForm2Writer.Location = new System.Drawing.Point(109, 139);
            this.lblForm2Writer.Name = "lblForm2Writer";
            this.lblForm2Writer.Size = new System.Drawing.Size(40, 13);
            this.lblForm2Writer.TabIndex = 11;
            this.lblForm2Writer.Text = "Writers";
            // 
            // rtbxDirectors
            // 
            this.rtbxDirectors.Location = new System.Drawing.Point(214, 183);
            this.rtbxDirectors.Name = "rtbxDirectors";
            this.rtbxDirectors.Size = new System.Drawing.Size(478, 28);
            this.rtbxDirectors.TabIndex = 5;
            this.rtbxDirectors.Text = "";
            // 
            // lblForm2Stars
            // 
            this.lblForm2Stars.AutoSize = true;
            this.lblForm2Stars.Location = new System.Drawing.Point(109, 81);
            this.lblForm2Stars.Name = "lblForm2Stars";
            this.lblForm2Stars.Size = new System.Drawing.Size(31, 13);
            this.lblForm2Stars.TabIndex = 12;
            this.lblForm2Stars.Text = "Stars";
            // 
            // rtbxWriters
            // 
            this.rtbxWriters.Location = new System.Drawing.Point(214, 129);
            this.rtbxWriters.Name = "rtbxWriters";
            this.rtbxWriters.Size = new System.Drawing.Size(478, 28);
            this.rtbxWriters.TabIndex = 6;
            this.rtbxWriters.Text = "";
            // 
            // lblForm2MovieName
            // 
            this.lblForm2MovieName.AutoSize = true;
            this.lblForm2MovieName.Location = new System.Drawing.Point(109, 27);
            this.lblForm2MovieName.Name = "lblForm2MovieName";
            this.lblForm2MovieName.Size = new System.Drawing.Size(67, 13);
            this.lblForm2MovieName.TabIndex = 13;
            this.lblForm2MovieName.Text = "Movie Name";
            // 
            // rtbxStars
            // 
            this.rtbxStars.Location = new System.Drawing.Point(214, 75);
            this.rtbxStars.Name = "rtbxStars";
            this.rtbxStars.Size = new System.Drawing.Size(478, 23);
            this.rtbxStars.TabIndex = 7;
            this.rtbxStars.Text = "";
            // 
            // rtbxMovieName
            // 
            this.rtbxMovieName.Location = new System.Drawing.Point(214, 20);
            this.rtbxMovieName.Name = "rtbxMovieName";
            this.rtbxMovieName.Size = new System.Drawing.Size(478, 23);
            this.rtbxMovieName.TabIndex = 8;
            this.rtbxMovieName.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblForm2Description);
            this.Controls.Add(this.rtbxDescription);
            this.Controls.Add(this.lblForm2Director);
            this.Controls.Add(this.lblForm2Writer);
            this.Controls.Add(this.rtbxDirectors);
            this.Controls.Add(this.lblForm2Stars);
            this.Controls.Add(this.rtbxWriters);
            this.Controls.Add(this.lblForm2MovieName);
            this.Controls.Add(this.rtbxStars);
            this.Controls.Add(this.rtbxMovieName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblForm2Description;
        private System.Windows.Forms.RichTextBox rtbxDescription;
        private System.Windows.Forms.Label lblForm2Director;
        private System.Windows.Forms.Label lblForm2Writer;
        private System.Windows.Forms.RichTextBox rtbxDirectors;
        private System.Windows.Forms.Label lblForm2Stars;
        private System.Windows.Forms.RichTextBox rtbxWriters;
        private System.Windows.Forms.Label lblForm2MovieName;
        private System.Windows.Forms.RichTextBox rtbxStars;
        private System.Windows.Forms.RichTextBox rtbxMovieName;
    }
}