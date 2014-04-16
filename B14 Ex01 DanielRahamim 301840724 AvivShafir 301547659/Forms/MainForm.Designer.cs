namespace B14_Ex01_Daniel_301840724_Aviv_301547659
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PictureBoxUser = new System.Windows.Forms.PictureBox();
            this.buttonUploadFunny = new System.Windows.Forms.Button();
            this.buttonGetStatics = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonQuoteMaster = new System.Windows.Forms.Button();
            this.buttonRandomCat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxUser
            // 
            this.PictureBoxUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxUser.BackgroundImage")));
            this.PictureBoxUser.Location = new System.Drawing.Point(24, 25);
            this.PictureBoxUser.Name = "PictureBoxUser";
            this.PictureBoxUser.Size = new System.Drawing.Size(59, 50);
            this.PictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxUser.TabIndex = 0;
            this.PictureBoxUser.TabStop = false;
            // 
            // buttonUploadFunny
            // 
            this.buttonUploadFunny.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUploadFunny.Location = new System.Drawing.Point(12, 148);
            this.buttonUploadFunny.Name = "buttonUploadFunny";
            this.buttonUploadFunny.Size = new System.Drawing.Size(524, 50);
            this.buttonUploadFunny.TabIndex = 1;
            this.buttonUploadFunny.Text = "Ragefaces";
            this.buttonUploadFunny.UseVisualStyleBackColor = true;
            this.buttonUploadFunny.Click += new System.EventHandler(this.buttonUploadFunny_Click);
            // 
            // buttonGetStatics
            // 
            this.buttonGetStatics.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetStatics.Location = new System.Drawing.Point(12, 92);
            this.buttonGetStatics.Name = "buttonGetStatics";
            this.buttonGetStatics.Size = new System.Drawing.Size(524, 50);
            this.buttonGetStatics.TabIndex = 2;
            this.buttonGetStatics.Text = "Statistics";
            this.buttonGetStatics.UseVisualStyleBackColor = true;
            this.buttonGetStatics.Click += new System.EventHandler(this.buttonGetStatics_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(134, 36);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(94, 25);
            this.labelWelcome.TabIndex = 3;
            this.labelWelcome.Text = "Logged In As :";
            // 
            // buttonQuoteMaster
            // 
            this.buttonQuoteMaster.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuoteMaster.Location = new System.Drawing.Point(12, 207);
            this.buttonQuoteMaster.Name = "buttonQuoteMaster";
            this.buttonQuoteMaster.Size = new System.Drawing.Size(524, 50);
            this.buttonQuoteMaster.TabIndex = 4;
            this.buttonQuoteMaster.Text = "Facts Generator";
            this.buttonQuoteMaster.UseVisualStyleBackColor = true;
            this.buttonQuoteMaster.Click += new System.EventHandler(this.buttonQuoteMaster_Click);
            // 
            // buttonRandomCat
            // 
            this.buttonRandomCat.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandomCat.Location = new System.Drawing.Point(12, 263);
            this.buttonRandomCat.Name = "buttonRandomCat";
            this.buttonRandomCat.Size = new System.Drawing.Size(524, 50);
            this.buttonRandomCat.TabIndex = 5;
            this.buttonRandomCat.Text = "Random Cats";
            this.buttonRandomCat.UseVisualStyleBackColor = true;
            this.buttonRandomCat.Click += new System.EventHandler(this.buttonRandomCat_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 330);
            this.Controls.Add(this.buttonRandomCat);
            this.Controls.Add(this.buttonQuoteMaster);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonGetStatics);
            this.Controls.Add(this.buttonUploadFunny);
            this.Controls.Add(this.PictureBoxUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DPF | DesignPatternsFacebook";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxUser;
        private System.Windows.Forms.Button buttonUploadFunny;
        private System.Windows.Forms.Button buttonGetStatics;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonQuoteMaster;
        private System.Windows.Forms.Button buttonRandomCat;
    }
}