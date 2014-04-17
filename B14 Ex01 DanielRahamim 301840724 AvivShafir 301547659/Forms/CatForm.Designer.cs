namespace B14_Ex01_Daniel_301840724_Aviv_301547659.Forms
{
    partial class CatForm
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
            this.pictureBoxCat = new System.Windows.Forms.PictureBox();
            this.buttonGetCat = new System.Windows.Forms.Button();
            this.listBox2Friends = new System.Windows.Forms.ListBox();
            this.buttonPostToWallCat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstNameLabel1 = new System.Windows.Forms.Label();
            this.imageLargePictureBox = new System.Windows.Forms.PictureBox();
            this.lastNameLabel1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCat
            // 
            this.pictureBoxCat.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxCat.Name = "pictureBoxCat";
            this.pictureBoxCat.Size = new System.Drawing.Size(182, 182);
            this.pictureBoxCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCat.TabIndex = 0;
            this.pictureBoxCat.TabStop = false;
            // 
            // buttonGetCat
            // 
            this.buttonGetCat.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetCat.Location = new System.Drawing.Point(12, 200);
            this.buttonGetCat.Name = "buttonGetCat";
            this.buttonGetCat.Size = new System.Drawing.Size(182, 33);
            this.buttonGetCat.TabIndex = 1;
            this.buttonGetCat.Text = "Randomize A Cat";
            this.buttonGetCat.UseVisualStyleBackColor = true;
            this.buttonGetCat.Click += new System.EventHandler(this.buttonGetCat_Click);
            // 
            // listBox2Friends
            // 
            this.listBox2Friends.DataSource = this.userBindingSource;
            this.listBox2Friends.DisplayMember = "Name";
            this.listBox2Friends.FormattingEnabled = true;
            this.listBox2Friends.Location = new System.Drawing.Point(221, 12);
            this.listBox2Friends.Name = "listBox2Friends";
            this.listBox2Friends.Size = new System.Drawing.Size(135, 186);
            this.listBox2Friends.TabIndex = 2;
            // 
            // buttonPostToWallCat
            // 
            this.buttonPostToWallCat.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPostToWallCat.Location = new System.Drawing.Point(557, 150);
            this.buttonPostToWallCat.Name = "buttonPostToWallCat";
            this.buttonPostToWallCat.Size = new System.Drawing.Size(197, 34);
            this.buttonPostToWallCat.TabIndex = 3;
            this.buttonPostToWallCat.Text = "Post To Friend Wall";
            this.buttonPostToWallCat.UseVisualStyleBackColor = true;
            this.buttonPostToWallCat.Click += new System.EventHandler(this.buttonPostToWallCat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose A Friend";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(575, 77);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(179, 67);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(597, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add A Comment";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(375, 51);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 11;
            firstNameLabel.Text = "First Name:";
            // 
            // firstNameLabel1
            // 
            this.firstNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "FirstName", true));
            this.firstNameLabel1.Location = new System.Drawing.Point(446, 51);
            this.firstNameLabel1.Name = "firstNameLabel1";
            this.firstNameLabel1.Size = new System.Drawing.Size(100, 23);
            this.firstNameLabel1.TabIndex = 12;
            this.firstNameLabel1.Text = "label3";
            // 
            // imageLargePictureBox
            // 
            this.imageLargePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageLarge", true));
            this.imageLargePictureBox.Location = new System.Drawing.Point(381, 118);
            this.imageLargePictureBox.Name = "imageLargePictureBox";
            this.imageLargePictureBox.Size = new System.Drawing.Size(127, 80);
            this.imageLargePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageLargePictureBox.TabIndex = 14;
            this.imageLargePictureBox.TabStop = false;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(374, 77);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 15;
            lastNameLabel.Text = "Last Name:";
            // 
            // lastNameLabel1
            // 
            this.lastNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "LastName", true));
            this.lastNameLabel1.Location = new System.Drawing.Point(446, 77);
            this.lastNameLabel1.Name = "lastNameLabel1";
            this.lastNameLabel1.Size = new System.Drawing.Size(100, 23);
            this.lastNameLabel1.TabIndex = 16;
            this.lastNameLabel1.Text = "label3";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(557, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "Post To My Wall";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 259);
            this.Controls.Add(this.button1);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameLabel1);
            this.Controls.Add(this.imageLargePictureBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPostToWallCat);
            this.Controls.Add(this.listBox2Friends);
            this.Controls.Add(this.buttonGetCat);
            this.Controls.Add(this.pictureBoxCat);
            this.Name = "CatForm";
            this.Text = "CatForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCat;
        private System.Windows.Forms.Button buttonGetCat;
        private System.Windows.Forms.ListBox listBox2Friends;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button buttonPostToWallCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label firstNameLabel1;
        private System.Windows.Forms.PictureBox imageLargePictureBox;
        private System.Windows.Forms.Label lastNameLabel1;
        private System.Windows.Forms.Button button1;
    }
}