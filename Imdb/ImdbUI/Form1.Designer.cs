namespace ImdbUI
{
    partial class Form1
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
            this.lbMovieLink = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStarBio = new System.Windows.Forms.Button();
            this.btnWriterInfo = new System.Windows.Forms.Button();
            this.btnDirectorBio = new System.Windows.Forms.Button();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblStarsName = new System.Windows.Forms.Label();
            this.lblDirectors = new System.Windows.Forms.Label();
            this.lblWritersName = new System.Windows.Forms.Label();
            this.lblWriters = new System.Windows.Forms.Label();
            this.lblDirectorsName = new System.Windows.Forms.Label();
            this.lblStars = new System.Windows.Forms.Label();
            this.lblRateValue = new System.Windows.Forms.Label();
            this.gbDescription = new System.Windows.Forms.GroupBox();
            this.pbMovieImage = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.gbxInformation = new System.Windows.Forms.GroupBox();
            this.btnForSearch = new System.Windows.Forms.Button();
            this.txbMovieName = new System.Windows.Forms.TextBox();
            this.lbMovieInfo = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.gbDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovieImage)).BeginInit();
            this.gbxInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMovieLink
            // 
            this.lbMovieLink.FormattingEnabled = true;
            this.lbMovieLink.Location = new System.Drawing.Point(307, 147);
            this.lbMovieLink.Name = "lbMovieLink";
            this.lbMovieLink.Size = new System.Drawing.Size(209, 290);
            this.lbMovieLink.TabIndex = 12;
            this.lbMovieLink.SelectedIndexChanged += new System.EventHandler(this.lbMovieLink_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStarBio);
            this.groupBox1.Controls.Add(this.btnWriterInfo);
            this.groupBox1.Controls.Add(this.btnDirectorBio);
            this.groupBox1.Controls.Add(this.btnForm2);
            this.groupBox1.Controls.Add(this.lblRate);
            this.groupBox1.Controls.Add(this.lblStarsName);
            this.groupBox1.Controls.Add(this.lblDirectors);
            this.groupBox1.Controls.Add(this.lblWritersName);
            this.groupBox1.Controls.Add(this.lblWriters);
            this.groupBox1.Controls.Add(this.lblDirectorsName);
            this.groupBox1.Controls.Add(this.lblStars);
            this.groupBox1.Controls.Add(this.lblRateValue);
            this.groupBox1.Location = new System.Drawing.Point(522, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 296);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movie Cast and Rate";
            // 
            // btnStarBio
            // 
            this.btnStarBio.Location = new System.Drawing.Point(188, 266);
            this.btnStarBio.Name = "btnStarBio";
            this.btnStarBio.Size = new System.Drawing.Size(83, 23);
            this.btnStarBio.TabIndex = 12;
            this.btnStarBio.Text = "Star Bio";
            this.btnStarBio.UseVisualStyleBackColor = true;
            this.btnStarBio.Click += new System.EventHandler(this.btnStarBio_Click);
            // 
            // btnWriterInfo
            // 
            this.btnWriterInfo.Location = new System.Drawing.Point(96, 266);
            this.btnWriterInfo.Name = "btnWriterInfo";
            this.btnWriterInfo.Size = new System.Drawing.Size(85, 23);
            this.btnWriterInfo.TabIndex = 11;
            this.btnWriterInfo.Text = "Writer Info";
            this.btnWriterInfo.UseVisualStyleBackColor = true;
            this.btnWriterInfo.Click += new System.EventHandler(this.btnWriterInfo_Click);
            // 
            // btnDirectorBio
            // 
            this.btnDirectorBio.Location = new System.Drawing.Point(6, 266);
            this.btnDirectorBio.Name = "btnDirectorBio";
            this.btnDirectorBio.Size = new System.Drawing.Size(86, 23);
            this.btnDirectorBio.TabIndex = 10;
            this.btnDirectorBio.Text = "Director Bio";
            this.btnDirectorBio.UseVisualStyleBackColor = true;
            this.btnDirectorBio.Click += new System.EventHandler(this.btnDirectorBio_Click);
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(316, 267);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(92, 23);
            this.btnForm2.TabIndex = 9;
            this.btnForm2.Text = "Database Form";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(9, 25);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(68, 13);
            this.lblRate.TabIndex = 6;
            this.lblRate.Text = "Movie Rate :";
            // 
            // lblStarsName
            // 
            this.lblStarsName.AutoSize = true;
            this.lblStarsName.Location = new System.Drawing.Point(80, 192);
            this.lblStarsName.Name = "lblStarsName";
            this.lblStarsName.Size = new System.Drawing.Size(0, 13);
            this.lblStarsName.TabIndex = 7;
            // 
            // lblDirectors
            // 
            this.lblDirectors.AutoSize = true;
            this.lblDirectors.Location = new System.Drawing.Point(9, 63);
            this.lblDirectors.Name = "lblDirectors";
            this.lblDirectors.Size = new System.Drawing.Size(55, 13);
            this.lblDirectors.TabIndex = 6;
            this.lblDirectors.Text = "Directors :";
            // 
            // lblWritersName
            // 
            this.lblWritersName.AutoSize = true;
            this.lblWritersName.Location = new System.Drawing.Point(80, 126);
            this.lblWritersName.Name = "lblWritersName";
            this.lblWritersName.Size = new System.Drawing.Size(0, 13);
            this.lblWritersName.TabIndex = 7;
            // 
            // lblWriters
            // 
            this.lblWriters.AutoSize = true;
            this.lblWriters.Location = new System.Drawing.Point(9, 126);
            this.lblWriters.Name = "lblWriters";
            this.lblWriters.Size = new System.Drawing.Size(46, 13);
            this.lblWriters.TabIndex = 6;
            this.lblWriters.Text = "Writers :";
            // 
            // lblDirectorsName
            // 
            this.lblDirectorsName.AutoSize = true;
            this.lblDirectorsName.Location = new System.Drawing.Point(80, 63);
            this.lblDirectorsName.Name = "lblDirectorsName";
            this.lblDirectorsName.Size = new System.Drawing.Size(0, 13);
            this.lblDirectorsName.TabIndex = 7;
            // 
            // lblStars
            // 
            this.lblStars.AutoSize = true;
            this.lblStars.Location = new System.Drawing.Point(9, 192);
            this.lblStars.Name = "lblStars";
            this.lblStars.Size = new System.Drawing.Size(40, 13);
            this.lblStars.TabIndex = 6;
            this.lblStars.Text = "Starts :";
            // 
            // lblRateValue
            // 
            this.lblRateValue.AutoSize = true;
            this.lblRateValue.Location = new System.Drawing.Point(80, 25);
            this.lblRateValue.Name = "lblRateValue";
            this.lblRateValue.Size = new System.Drawing.Size(0, 13);
            this.lblRateValue.TabIndex = 7;
            // 
            // gbDescription
            // 
            this.gbDescription.Controls.Add(this.pbMovieImage);
            this.gbDescription.Controls.Add(this.lblDescription);
            this.gbDescription.Location = new System.Drawing.Point(307, 14);
            this.gbDescription.Name = "gbDescription";
            this.gbDescription.Size = new System.Drawing.Size(629, 121);
            this.gbDescription.TabIndex = 11;
            this.gbDescription.TabStop = false;
            this.gbDescription.Text = "Movie Description";
            // 
            // pbMovieImage
            // 
            this.pbMovieImage.Location = new System.Drawing.Point(573, 65);
            this.pbMovieImage.Name = "pbMovieImage";
            this.pbMovieImage.Size = new System.Drawing.Size(50, 50);
            this.pbMovieImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMovieImage.TabIndex = 1;
            this.pbMovieImage.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(9, 19);
            this.lblDescription.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 13);
            this.lblDescription.TabIndex = 0;
            // 
            // gbxInformation
            // 
            this.gbxInformation.Controls.Add(this.btnForSearch);
            this.gbxInformation.Controls.Add(this.txbMovieName);
            this.gbxInformation.Location = new System.Drawing.Point(4, 14);
            this.gbxInformation.Name = "gbxInformation";
            this.gbxInformation.Size = new System.Drawing.Size(292, 121);
            this.gbxInformation.TabIndex = 10;
            this.gbxInformation.TabStop = false;
            this.gbxInformation.Text = "Movie Information";
            // 
            // btnForSearch
            // 
            this.btnForSearch.Location = new System.Drawing.Point(102, 66);
            this.btnForSearch.Name = "btnForSearch";
            this.btnForSearch.Size = new System.Drawing.Size(75, 23);
            this.btnForSearch.TabIndex = 3;
            this.btnForSearch.Text = "Search";
            this.btnForSearch.UseVisualStyleBackColor = true;
            this.btnForSearch.Click += new System.EventHandler(this.btnForSearch_Click);
            // 
            // txbMovieName
            // 
            this.txbMovieName.Location = new System.Drawing.Point(74, 33);
            this.txbMovieName.Name = "txbMovieName";
            this.txbMovieName.Size = new System.Drawing.Size(135, 20);
            this.txbMovieName.TabIndex = 0;
            // 
            // lbMovieInfo
            // 
            this.lbMovieInfo.FormattingEnabled = true;
            this.lbMovieInfo.Location = new System.Drawing.Point(4, 148);
            this.lbMovieInfo.Name = "lbMovieInfo";
            this.lbMovieInfo.Size = new System.Drawing.Size(292, 290);
            this.lbMovieInfo.TabIndex = 9;
            this.lbMovieInfo.SelectedIndexChanged += new System.EventHandler(this.lbMovieInfo_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 450);
            this.Controls.Add(this.lbMovieLink);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDescription);
            this.Controls.Add(this.gbxInformation);
            this.Controls.Add(this.lbMovieInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDescription.ResumeLayout(false);
            this.gbDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovieImage)).EndInit();
            this.gbxInformation.ResumeLayout(false);
            this.gbxInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbMovieLink;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStarBio;
        private System.Windows.Forms.Button btnWriterInfo;
        private System.Windows.Forms.Button btnDirectorBio;
        private System.Windows.Forms.Button btnForm2;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblStarsName;
        private System.Windows.Forms.Label lblDirectors;
        private System.Windows.Forms.Label lblWritersName;
        private System.Windows.Forms.Label lblWriters;
        private System.Windows.Forms.Label lblDirectorsName;
        private System.Windows.Forms.Label lblStars;
        private System.Windows.Forms.Label lblRateValue;
        private System.Windows.Forms.GroupBox gbDescription;
        private System.Windows.Forms.PictureBox pbMovieImage;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.GroupBox gbxInformation;
        private System.Windows.Forms.Button btnForSearch;
        private System.Windows.Forms.TextBox txbMovieName;
        private System.Windows.Forms.ListBox lbMovieInfo;
    }
}

