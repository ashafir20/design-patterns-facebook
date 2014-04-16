namespace B14_Ex01_Daniel_301840724_Aviv_301547659.Forms
{
    partial class StatisticsForm
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
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.PictureBoxUserFriend = new System.Windows.Forms.PictureBox();
            this.buttonPickFriend = new System.Windows.Forms.Button();
            this.listBoxPickedFriends = new System.Windows.Forms.ListBox();
            this.labelPickedFriendsCounter = new System.Windows.Forms.Label();
            this.buttonGetLikesStatistics = new System.Windows.Forms.Button();
            this.buttonRemoveFriend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonPhotos = new System.Windows.Forms.RadioButton();
            this.radioButtonPosts = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.listViewResults = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.pictureBoxPickedFriends = new System.Windows.Forms.PictureBox();
            this.buttonSortList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPickedFriends)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(3, 117);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(173, 132);
            this.listBoxFriends.TabIndex = 0;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // PictureBoxUserFriend
            // 
            this.PictureBoxUserFriend.Location = new System.Drawing.Point(3, 16);
            this.PictureBoxUserFriend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PictureBoxUserFriend.Name = "PictureBoxUserFriend";
            this.PictureBoxUserFriend.Size = new System.Drawing.Size(175, 94);
            this.PictureBoxUserFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxUserFriend.TabIndex = 1;
            this.PictureBoxUserFriend.TabStop = false;
            // 
            // buttonPickFriend
            // 
            this.buttonPickFriend.Location = new System.Drawing.Point(17, 257);
            this.buttonPickFriend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPickFriend.Name = "buttonPickFriend";
            this.buttonPickFriend.Size = new System.Drawing.Size(132, 50);
            this.buttonPickFriend.TabIndex = 2;
            this.buttonPickFriend.Text = "Pick Friend";
            this.buttonPickFriend.UseVisualStyleBackColor = true;
            this.buttonPickFriend.Click += new System.EventHandler(this.buttonPickFriend_Click);
            // 
            // listBoxPickedFriends
            // 
            this.listBoxPickedFriends.FormattingEnabled = true;
            this.listBoxPickedFriends.ItemHeight = 16;
            this.listBoxPickedFriends.Location = new System.Drawing.Point(200, 117);
            this.listBoxPickedFriends.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxPickedFriends.Name = "listBoxPickedFriends";
            this.listBoxPickedFriends.Size = new System.Drawing.Size(173, 132);
            this.listBoxPickedFriends.TabIndex = 3;
            this.listBoxPickedFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxPickedFriends_SelectedIndexChanged);
            // 
            // labelPickedFriendsCounter
            // 
            this.labelPickedFriendsCounter.AutoSize = true;
            this.labelPickedFriendsCounter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPickedFriendsCounter.Location = new System.Drawing.Point(216, 329);
            this.labelPickedFriendsCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPickedFriendsCounter.Name = "labelPickedFriendsCounter";
            this.labelPickedFriendsCounter.Size = new System.Drawing.Size(148, 19);
            this.labelPickedFriendsCounter.TabIndex = 4;
            this.labelPickedFriendsCounter.Text = "You Picked 0 Friends";
            // 
            // buttonGetLikesStatistics
            // 
            this.buttonGetLikesStatistics.Enabled = false;
            this.buttonGetLikesStatistics.Location = new System.Drawing.Point(392, 257);
            this.buttonGetLikesStatistics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGetLikesStatistics.Name = "buttonGetLikesStatistics";
            this.buttonGetLikesStatistics.Size = new System.Drawing.Size(192, 49);
            this.buttonGetLikesStatistics.TabIndex = 5;
            this.buttonGetLikesStatistics.Text = "Get Statistics !";
            this.buttonGetLikesStatistics.UseVisualStyleBackColor = true;
            this.buttonGetLikesStatistics.Click += new System.EventHandler(this.buttonGetLikesStatistics_Click);
            // 
            // buttonRemoveFriend
            // 
            this.buttonRemoveFriend.Location = new System.Drawing.Point(220, 258);
            this.buttonRemoveFriend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRemoveFriend.Name = "buttonRemoveFriend";
            this.buttonRemoveFriend.Size = new System.Drawing.Size(140, 49);
            this.buttonRemoveFriend.TabIndex = 6;
            this.buttonRemoveFriend.Text = "Remove Friend";
            this.buttonRemoveFriend.UseVisualStyleBackColor = true;
            this.buttonRemoveFriend.Click += new System.EventHandler(this.buttonRemoveFriend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "My Top Liker In:";
            // 
            // radioButtonPhotos
            // 
            this.radioButtonPhotos.AutoSize = true;
            this.radioButtonPhotos.Checked = true;
            this.radioButtonPhotos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.radioButtonPhotos.Location = new System.Drawing.Point(415, 75);
            this.radioButtonPhotos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonPhotos.Name = "radioButtonPhotos";
            this.radioButtonPhotos.Size = new System.Drawing.Size(123, 21);
            this.radioButtonPhotos.TabIndex = 8;
            this.radioButtonPhotos.TabStop = true;
            this.radioButtonPhotos.Text = "Albums Photos";
            this.radioButtonPhotos.UseVisualStyleBackColor = true;
            // 
            // radioButtonPosts
            // 
            this.radioButtonPosts.AutoSize = true;
            this.radioButtonPosts.Location = new System.Drawing.Point(416, 117);
            this.radioButtonPosts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonPosts.Name = "radioButtonPosts";
            this.radioButtonPosts.Size = new System.Drawing.Size(64, 21);
            this.radioButtonPosts.TabIndex = 9;
            this.radioButtonPosts.TabStop = true;
            this.radioButtonPosts.Text = "Posts";
            this.radioButtonPosts.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(416, 158);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(124, 21);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.Text = "Photos + Posts";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // listViewResults
            // 
            this.listViewResults.Location = new System.Drawing.Point(608, 144);
            this.listViewResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.Size = new System.Drawing.Size(481, 178);
            this.listViewResults.TabIndex = 11;
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(808, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Results";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(731, 332);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(241, 28);
            this.progressBar.TabIndex = 13;
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Location = new System.Drawing.Point(17, 315);
            this.buttonSelectAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(132, 43);
            this.buttonSelectAll.TabIndex = 14;
            this.buttonSelectAll.Text = "SelectAll";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // pictureBoxPickedFriends
            // 
            this.pictureBoxPickedFriends.Location = new System.Drawing.Point(200, 15);
            this.pictureBoxPickedFriends.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxPickedFriends.Name = "pictureBoxPickedFriends";
            this.pictureBoxPickedFriends.Size = new System.Drawing.Size(175, 94);
            this.pictureBoxPickedFriends.TabIndex = 15;
            this.pictureBoxPickedFriends.TabStop = false;
            // 
            // buttonSortList
            // 
            this.buttonSortList.Enabled = false;
            this.buttonSortList.Location = new System.Drawing.Point(748, 87);
            this.buttonSortList.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSortList.Name = "buttonSortList";
            this.buttonSortList.Size = new System.Drawing.Size(192, 49);
            this.buttonSortList.TabIndex = 16;
            this.buttonSortList.Text = "Sort List";
            this.buttonSortList.UseVisualStyleBackColor = true;
            this.buttonSortList.Click += new System.EventHandler(this.buttonSortList_Click);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 375);
            this.Controls.Add(this.buttonSortList);
            this.Controls.Add(this.pictureBoxPickedFriends);
            this.Controls.Add(this.buttonSelectAll);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewResults);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButtonPosts);
            this.Controls.Add(this.radioButtonPhotos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRemoveFriend);
            this.Controls.Add(this.buttonGetLikesStatistics);
            this.Controls.Add(this.labelPickedFriendsCounter);
            this.Controls.Add(this.listBoxPickedFriends);
            this.Controls.Add(this.buttonPickFriend);
            this.Controls.Add(this.PictureBoxUserFriend);
            this.Controls.Add(this.listBoxFriends);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPickedFriends)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.PictureBox PictureBoxUserFriend;
        private System.Windows.Forms.Button buttonPickFriend;
        private System.Windows.Forms.ListBox listBoxPickedFriends;
        private System.Windows.Forms.Label labelPickedFriendsCounter;
        private System.Windows.Forms.Button buttonGetLikesStatistics;
        private System.Windows.Forms.Button buttonRemoveFriend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonPhotos;
        private System.Windows.Forms.RadioButton radioButtonPosts;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ListView listViewResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.PictureBox pictureBoxPickedFriends;
        private System.Windows.Forms.Button buttonSortList;
    }
}