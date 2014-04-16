namespace B14_Ex01_Daniel_301840724_Aviv_301547659.Forms
{
    public partial class FunnyForm
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
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.labelUploadRageFaces = new System.Windows.Forms.Label();
            this.buttonPostToWall = new System.Windows.Forms.Button();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRagePersons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonNextFaces = new System.Windows.Forms.Button();
            this.buttonPrevFaces = new System.Windows.Forms.Button();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.buttonOpenInPaint = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOpenBrowser = new System.Windows.Forms.Button();
            this.buttonAddFilter = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxRageFace = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRageFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(174, 57);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(141, 31);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrev.Location = new System.Drawing.Point(17, 57);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(139, 31);
            this.buttonPrev.TabIndex = 1;
            this.buttonPrev.Text = "Prev";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // labelUploadRageFaces
            // 
            this.labelUploadRageFaces.AutoSize = true;
            this.labelUploadRageFaces.Font = new System.Drawing.Font("Virtual DJ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUploadRageFaces.Location = new System.Drawing.Point(75, 15);
            this.labelUploadRageFaces.Name = "labelUploadRageFaces";
            this.labelUploadRageFaces.Size = new System.Drawing.Size(371, 30);
            this.labelUploadRageFaces.TabIndex = 3;
            this.labelUploadRageFaces.Text = "RageFace Madness";
            // 
            // buttonPostToWall
            // 
            this.buttonPostToWall.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPostToWall.Location = new System.Drawing.Point(19, 626);
            this.buttonPostToWall.Name = "buttonPostToWall";
            this.buttonPostToWall.Size = new System.Drawing.Size(298, 36);
            this.buttonPostToWall.TabIndex = 4;
            this.buttonPostToWall.Text = "Post To Your Wall";
            this.buttonPostToWall.UseVisualStyleBackColor = true;
            this.buttonPostToWall.Click += new System.EventHandler(this.buttonSubmitPost_Click);
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.BackColor = System.Drawing.Color.LightGray;
            this.richTextBoxDescription.Location = new System.Drawing.Point(19, 523);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(298, 97);
            this.richTextBoxDescription.TabIndex = 5;
            this.richTextBoxDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add Description";
            // 
            // panelRagePersons
            // 
            this.panelRagePersons.AutoScroll = true;
            this.panelRagePersons.ColumnCount = 3;
            this.panelRagePersons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelRagePersons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelRagePersons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelRagePersons.Location = new System.Drawing.Point(339, 57);
            this.panelRagePersons.Name = "panelRagePersons";
            this.panelRagePersons.RowCount = 5;
            this.panelRagePersons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelRagePersons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelRagePersons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelRagePersons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelRagePersons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelRagePersons.Size = new System.Drawing.Size(275, 569);
            this.panelRagePersons.TabIndex = 7;
            // 
            // buttonNextFaces
            // 
            this.buttonNextFaces.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextFaces.Location = new System.Drawing.Point(487, 636);
            this.buttonNextFaces.Name = "buttonNextFaces";
            this.buttonNextFaces.Size = new System.Drawing.Size(127, 27);
            this.buttonNextFaces.TabIndex = 8;
            this.buttonNextFaces.Text = "Next Faces";
            this.buttonNextFaces.UseVisualStyleBackColor = true;
            this.buttonNextFaces.Click += new System.EventHandler(this.buttonNextFaces_Click);
            // 
            // buttonPrevFaces
            // 
            this.buttonPrevFaces.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrevFaces.Location = new System.Drawing.Point(339, 636);
            this.buttonPrevFaces.Name = "buttonPrevFaces";
            this.buttonPrevFaces.Size = new System.Drawing.Size(124, 28);
            this.buttonPrevFaces.TabIndex = 9;
            this.buttonPrevFaces.Text = "Previous Faces";
            this.buttonPrevFaces.UseVisualStyleBackColor = true;
            this.buttonPrevFaces.Click += new System.EventHandler(this.buttonPrevFaces_Click);
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveImage.Location = new System.Drawing.Point(173, 414);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(141, 36);
            this.buttonSaveImage.TabIndex = 10;
            this.buttonSaveImage.Text = "Save Image";
            this.buttonSaveImage.UseVisualStyleBackColor = true;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // buttonOpenInPaint
            // 
            this.buttonOpenInPaint.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenInPaint.Location = new System.Drawing.Point(19, 414);
            this.buttonOpenInPaint.Name = "buttonOpenInPaint";
            this.buttonOpenInPaint.Size = new System.Drawing.Size(141, 36);
            this.buttonOpenInPaint.TabIndex = 20;
            this.buttonOpenInPaint.Text = "Open In Paint";
            this.buttonOpenInPaint.UseVisualStyleBackColor = true;
            this.buttonOpenInPaint.Click += new System.EventHandler(this.buttonOpenInPaint_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(17, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 9);
            this.label4.TabIndex = 21;
            this.label4.Text = "[Image Will Be Saved To Desktop]";
            // 
            // buttonOpenBrowser
            // 
            this.buttonOpenBrowser.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenBrowser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenBrowser.Location = new System.Drawing.Point(463, 15);
            this.buttonOpenBrowser.Name = "buttonOpenBrowser";
            this.buttonOpenBrowser.Size = new System.Drawing.Size(151, 31);
            this.buttonOpenBrowser.TabIndex = 22;
            this.buttonOpenBrowser.Text = "Browse To Facebook";
            this.buttonOpenBrowser.UseVisualStyleBackColor = true;
            this.buttonOpenBrowser.Click += new System.EventHandler(this.buttonOpenBrowser_Click);
            // 
            // buttonAddFilter
            // 
            this.buttonAddFilter.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddFilter.Location = new System.Drawing.Point(19, 372);
            this.buttonAddFilter.Name = "buttonAddFilter";
            this.buttonAddFilter.Size = new System.Drawing.Size(295, 36);
            this.buttonAddFilter.TabIndex = 24;
            this.buttonAddFilter.Text = "Add Filter";
            this.buttonAddFilter.UseVisualStyleBackColor = true;
            this.buttonAddFilter.Click += new System.EventHandler(this.buttonAddFilter_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 674);
            this.splitter1.TabIndex = 28;
            this.splitter1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::B14_Ex01_Daniel_301840724_Aviv_301547659.Properties.Resources.lol;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(148, 275);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 91);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::B14_Ex01_Daniel_301840724_Aviv_301547659.Properties.Resources.faceicon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(17, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 53);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxRageFace
            // 
            this.pictureBoxRageFace.Location = new System.Drawing.Point(17, 94);
            this.pictureBoxRageFace.Name = "pictureBoxRageFace";
            this.pictureBoxRageFace.Size = new System.Drawing.Size(298, 169);
            this.pictureBoxRageFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxRageFace.TabIndex = 2;
            this.pictureBoxRageFace.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::B14_Ex01_Daniel_301840724_Aviv_301547659.Properties.Resources.lol2;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(17, 275);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(139, 91);
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // FunnyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 674);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.buttonAddFilter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonOpenBrowser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSaveImage);
            this.Controls.Add(this.buttonOpenInPaint);
            this.Controls.Add(this.buttonPostToWall);
            this.Controls.Add(this.buttonPrevFaces);
            this.Controls.Add(this.buttonNextFaces);
            this.Controls.Add(this.panelRagePersons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUploadRageFaces);
            this.Controls.Add(this.pictureBoxRageFace);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.richTextBoxDescription);
            this.Name = "FunnyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Share Funny Stuff";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRageFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.PictureBox pictureBoxRageFace;
        private System.Windows.Forms.Label labelUploadRageFaces;
        private System.Windows.Forms.Button buttonPostToWall;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel panelRagePersons;
        private System.Windows.Forms.Button buttonNextFaces;
        private System.Windows.Forms.Button buttonPrevFaces;
        private System.Windows.Forms.Button buttonSaveImage;
        private System.Windows.Forms.Button buttonOpenInPaint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOpenBrowser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAddFilter;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}