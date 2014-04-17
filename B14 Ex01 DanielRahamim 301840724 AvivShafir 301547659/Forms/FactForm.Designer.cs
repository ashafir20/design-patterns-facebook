namespace B14_Ex01_Daniel_301840724_Aviv_301547659.Forms
{
    partial class FactForm
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label birthdayLabel1;
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelFacts = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.birthdayLabel2 = new System.Windows.Forms.Label();
            this.firstNameLabel1 = new System.Windows.Forms.Label();
            this.imageLargePictureBox = new System.Windows.Forms.PictureBox();
            this.lastNameLabel1 = new System.Windows.Forms.Label();
            this.buttonGetBirthdayFact = new System.Windows.Forms.Button();
            this.textBoxFact = new System.Windows.Forms.TextBox();
            this.buttonPostFact = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            birthdayLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            firstNameLabel.Location = new System.Drawing.Point(20, 77);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(106, 24);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            lastNameLabel.Location = new System.Drawing.Point(20, 126);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(104, 24);
            lastNameLabel.TabIndex = 8;
            lastNameLabel.Text = "Last Name:";
            // 
            // birthdayLabel1
            // 
            birthdayLabel1.AutoSize = true;
            birthdayLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            birthdayLabel1.Location = new System.Drawing.Point(20, 21);
            birthdayLabel1.Name = "birthdayLabel1";
            birthdayLabel1.Size = new System.Drawing.Size(82, 24);
            birthdayLabel1.TabIndex = 10;
            birthdayLabel1.Text = "Birthday:";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.DataSource = this.userBindingSource;
            this.listBoxFriends.DisplayMember = "Name";
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(12, 104);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(156, 355);
            this.listBoxFriends.TabIndex = 0;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // labelFacts
            // 
            this.labelFacts.AutoSize = true;
            this.labelFacts.Font = new System.Drawing.Font("Blade Runner Movie Font", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacts.Location = new System.Drawing.Point(165, 31);
            this.labelFacts.Name = "labelFacts";
            this.labelFacts.Size = new System.Drawing.Size(530, 29);
            this.labelFacts.TabIndex = 1;
            this.labelFacts.Text = "The Super Turbo Facts Generator";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(birthdayLabel1);
            this.panel1.Controls.Add(this.birthdayLabel2);
            this.panel1.Controls.Add(firstNameLabel);
            this.panel1.Controls.Add(this.firstNameLabel1);
            this.panel1.Controls.Add(this.imageLargePictureBox);
            this.panel1.Controls.Add(lastNameLabel);
            this.panel1.Controls.Add(this.lastNameLabel1);
            this.panel1.Location = new System.Drawing.Point(185, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 184);
            this.panel1.TabIndex = 2;
            // 
            // birthdayLabel2
            // 
            this.birthdayLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.birthdayLabel2.Location = new System.Drawing.Point(132, 21);
            this.birthdayLabel2.Name = "birthdayLabel2";
            this.birthdayLabel2.Size = new System.Drawing.Size(100, 23);
            this.birthdayLabel2.TabIndex = 11;
            this.birthdayLabel2.Text = "label1";
            // 
            // firstNameLabel1
            // 
            this.firstNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "FirstName", true));
            this.firstNameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.firstNameLabel1.Location = new System.Drawing.Point(132, 77);
            this.firstNameLabel1.Name = "firstNameLabel1";
            this.firstNameLabel1.Size = new System.Drawing.Size(100, 23);
            this.firstNameLabel1.TabIndex = 5;
            this.firstNameLabel1.Text = "label1";
            // 
            // imageLargePictureBox
            // 
            this.imageLargePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageLarge", true));
            this.imageLargePictureBox.Location = new System.Drawing.Point(287, 18);
            this.imageLargePictureBox.Name = "imageLargePictureBox";
            this.imageLargePictureBox.Size = new System.Drawing.Size(155, 147);
            this.imageLargePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageLargePictureBox.TabIndex = 7;
            this.imageLargePictureBox.TabStop = false;
            // 
            // lastNameLabel1
            // 
            this.lastNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "LastName", true));
            this.lastNameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lastNameLabel1.Location = new System.Drawing.Point(132, 126);
            this.lastNameLabel1.Name = "lastNameLabel1";
            this.lastNameLabel1.Size = new System.Drawing.Size(100, 23);
            this.lastNameLabel1.TabIndex = 9;
            this.lastNameLabel1.Text = "label1";
            // 
            // buttonGetBirthdayFact
            // 
            this.buttonGetBirthdayFact.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetBirthdayFact.Location = new System.Drawing.Point(261, 303);
            this.buttonGetBirthdayFact.Name = "buttonGetBirthdayFact";
            this.buttonGetBirthdayFact.Size = new System.Drawing.Size(277, 40);
            this.buttonGetBirthdayFact.TabIndex = 3;
            this.buttonGetBirthdayFact.Text = "Get Birthday Date Fact";
            this.buttonGetBirthdayFact.UseVisualStyleBackColor = true;
            this.buttonGetBirthdayFact.Click += new System.EventHandler(this.buttonGetBirthdayFact_Click);
            // 
            // textBoxFact
            // 
            this.textBoxFact.Location = new System.Drawing.Point(261, 349);
            this.textBoxFact.Multiline = true;
            this.textBoxFact.Name = "textBoxFact";
            this.textBoxFact.Size = new System.Drawing.Size(277, 64);
            this.textBoxFact.TabIndex = 4;
            // 
            // buttonPostFact
            // 
            this.buttonPostFact.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPostFact.Location = new System.Drawing.Point(288, 419);
            this.buttonPostFact.Name = "buttonPostFact";
            this.buttonPostFact.Size = new System.Drawing.Size(221, 40);
            this.buttonPostFact.TabIndex = 5;
            this.buttonPostFact.Text = "Post To Friend Wall";
            this.buttonPostFact.UseVisualStyleBackColor = true;
            this.buttonPostFact.Click += new System.EventHandler(this.buttonPostFact_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::B14_Ex01_Daniel_301840724_Aviv_301547659.Properties.Resources.lol;
            this.pictureBox1.Location = new System.Drawing.Point(17, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonPostFact);
            this.Controls.Add(this.textBoxFact);
            this.Controls.Add(this.buttonGetBirthdayFact);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelFacts);
            this.Controls.Add(this.listBoxFriends);
            this.Name = "FactForm";
            this.Text = "Facts About Friends";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label labelFacts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label firstNameLabel1;
        private System.Windows.Forms.PictureBox imageLargePictureBox;
        private System.Windows.Forms.Label lastNameLabel1;
        private System.Windows.Forms.Label birthdayLabel2;
        private System.Windows.Forms.Button buttonGetBirthdayFact;
        private System.Windows.Forms.TextBox textBoxFact;
        private System.Windows.Forms.Button buttonPostFact;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}