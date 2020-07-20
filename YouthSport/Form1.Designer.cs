namespace YouthSport
{
    partial class YouthSport
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.sportsLabel = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.footballRadioButton = new System.Windows.Forms.RadioButton();
            this.basketballRadioButton = new System.Windows.Forms.RadioButton();
            this.soccerRadioButton = new System.Windows.Forms.RadioButton();
            this.golfRadioButton = new System.Windows.Forms.RadioButton();
            this.lacrosseRadioButton = new System.Windows.Forms.RadioButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lacrossePictureBox = new System.Windows.Forms.PictureBox();
            this.golfPictureBox = new System.Windows.Forms.PictureBox();
            this.soccerPictureBox = new System.Windows.Forms.PictureBox();
            this.basketballPictureBox = new System.Windows.Forms.PictureBox();
            this.footballPictureBox = new System.Windows.Forms.PictureBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lacrossePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.golfPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soccerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketballPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(77, 59);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "&Name";
            // 
            // sportsLabel
            // 
            this.sportsLabel.AutoSize = true;
            this.sportsLabel.Location = new System.Drawing.Point(77, 109);
            this.sportsLabel.Name = "sportsLabel";
            this.sportsLabel.Size = new System.Drawing.Size(37, 13);
            this.sportsLabel.TabIndex = 1;
            this.sportsLabel.Text = "Sports";
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(107, 353);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(77, 30);
            this.signUpButton.TabIndex = 2;
            this.signUpButton.Text = "Si&gn Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // footballRadioButton
            // 
            this.footballRadioButton.AutoSize = true;
            this.footballRadioButton.Location = new System.Drawing.Point(140, 133);
            this.footballRadioButton.Name = "footballRadioButton";
            this.footballRadioButton.Size = new System.Drawing.Size(62, 17);
            this.footballRadioButton.TabIndex = 3;
            this.footballRadioButton.TabStop = true;
            this.footballRadioButton.Text = "&Football";
            this.footballRadioButton.UseVisualStyleBackColor = true;
            this.footballRadioButton.CheckedChanged += new System.EventHandler(this.footballRadioButton_CheckedChanged);
            // 
            // basketballRadioButton
            // 
            this.basketballRadioButton.AutoSize = true;
            this.basketballRadioButton.Location = new System.Drawing.Point(140, 170);
            this.basketballRadioButton.Name = "basketballRadioButton";
            this.basketballRadioButton.Size = new System.Drawing.Size(74, 17);
            this.basketballRadioButton.TabIndex = 4;
            this.basketballRadioButton.TabStop = true;
            this.basketballRadioButton.Text = "&Basketball";
            this.basketballRadioButton.UseVisualStyleBackColor = true;
            this.basketballRadioButton.CheckedChanged += new System.EventHandler(this.basketballRadioButton_CheckedChanged);
            // 
            // soccerRadioButton
            // 
            this.soccerRadioButton.AutoSize = true;
            this.soccerRadioButton.Location = new System.Drawing.Point(140, 209);
            this.soccerRadioButton.Name = "soccerRadioButton";
            this.soccerRadioButton.Size = new System.Drawing.Size(59, 17);
            this.soccerRadioButton.TabIndex = 5;
            this.soccerRadioButton.TabStop = true;
            this.soccerRadioButton.Text = "&Soccer";
            this.soccerRadioButton.UseVisualStyleBackColor = true;
            this.soccerRadioButton.CheckedChanged += new System.EventHandler(this.SoccerRadioButton_CheckedChanged);
            // 
            // golfRadioButton
            // 
            this.golfRadioButton.AutoSize = true;
            this.golfRadioButton.Location = new System.Drawing.Point(140, 252);
            this.golfRadioButton.Name = "golfRadioButton";
            this.golfRadioButton.Size = new System.Drawing.Size(44, 17);
            this.golfRadioButton.TabIndex = 6;
            this.golfRadioButton.TabStop = true;
            this.golfRadioButton.Text = "&Golf";
            this.golfRadioButton.UseVisualStyleBackColor = true;
            this.golfRadioButton.CheckedChanged += new System.EventHandler(this.golfRadioButton_CheckedChanged);
            // 
            // lacrosseRadioButton
            // 
            this.lacrosseRadioButton.AutoSize = true;
            this.lacrosseRadioButton.Location = new System.Drawing.Point(140, 295);
            this.lacrosseRadioButton.Name = "lacrosseRadioButton";
            this.lacrosseRadioButton.Size = new System.Drawing.Size(68, 17);
            this.lacrosseRadioButton.TabIndex = 7;
            this.lacrosseRadioButton.TabStop = true;
            this.lacrosseRadioButton.Text = "&Lacrosse";
            this.lacrosseRadioButton.UseVisualStyleBackColor = true;
            this.lacrosseRadioButton.CheckedChanged += new System.EventHandler(this.lacrosseRadioButton_CheckedChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(118, 59);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(140, 20);
            this.nameTextBox.TabIndex = 8;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "F&ile";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem1_Click);
            // 
            // lacrossePictureBox
            // 
            this.lacrossePictureBox.Image = global::YouthSport.Properties.Resources._2_men_playing_football_during_daytime_159566;
            this.lacrossePictureBox.Location = new System.Drawing.Point(364, 70);
            this.lacrossePictureBox.Name = "lacrossePictureBox";
            this.lacrossePictureBox.Size = new System.Drawing.Size(400, 300);
            this.lacrossePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lacrossePictureBox.TabIndex = 13;
            this.lacrossePictureBox.TabStop = false;
            // 
            // golfPictureBox
            // 
            this.golfPictureBox.Image = global::YouthSport.Properties.Resources.man_swinging_golf_club_facing_grass_field_1325653;
            this.golfPictureBox.Location = new System.Drawing.Point(364, 70);
            this.golfPictureBox.Name = "golfPictureBox";
            this.golfPictureBox.Size = new System.Drawing.Size(400, 300);
            this.golfPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.golfPictureBox.TabIndex = 12;
            this.golfPictureBox.TabStop = false;
            // 
            // soccerPictureBox
            // 
            this.soccerPictureBox.Image = global::YouthSport.Properties.Resources.action_activity_adult_athlete_262506;
            this.soccerPictureBox.Location = new System.Drawing.Point(364, 70);
            this.soccerPictureBox.Name = "soccerPictureBox";
            this.soccerPictureBox.Size = new System.Drawing.Size(400, 300);
            this.soccerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.soccerPictureBox.TabIndex = 11;
            this.soccerPictureBox.TabStop = false;
            // 
            // basketballPictureBox
            // 
            this.basketballPictureBox.Image = global::YouthSport.Properties.Resources.woman_in_blue_and_white_basketball_jersey_holding_brown_159607;
            this.basketballPictureBox.Location = new System.Drawing.Point(364, 70);
            this.basketballPictureBox.Name = "basketballPictureBox";
            this.basketballPictureBox.Size = new System.Drawing.Size(400, 300);
            this.basketballPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.basketballPictureBox.TabIndex = 10;
            this.basketballPictureBox.TabStop = false;
            // 
            // footballPictureBox
            // 
            this.footballPictureBox.Image = global::YouthSport.Properties.Resources._2_football_player_running_after_person_holding_football_159571;
            this.footballPictureBox.Location = new System.Drawing.Point(364, 70);
            this.footballPictureBox.Name = "footballPictureBox";
            this.footballPictureBox.Size = new System.Drawing.Size(400, 300);
            this.footballPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.footballPictureBox.TabIndex = 9;
            this.footballPictureBox.TabStop = false;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(212, 353);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(77, 30);
            this.resetButton.TabIndex = 15;
            this.resetButton.Text = "&Reset ";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // YouthSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 538);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.lacrossePictureBox);
            this.Controls.Add(this.golfPictureBox);
            this.Controls.Add(this.soccerPictureBox);
            this.Controls.Add(this.basketballPictureBox);
            this.Controls.Add(this.footballPictureBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.lacrosseRadioButton);
            this.Controls.Add(this.golfRadioButton);
            this.Controls.Add(this.soccerRadioButton);
            this.Controls.Add(this.basketballRadioButton);
            this.Controls.Add(this.footballRadioButton);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.sportsLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "YouthSport";
            this.Text = "Youth Sports";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lacrossePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.golfPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soccerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketballPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label sportsLabel;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.RadioButton footballRadioButton;
        private System.Windows.Forms.RadioButton basketballRadioButton;
        private System.Windows.Forms.RadioButton soccerRadioButton;
        private System.Windows.Forms.RadioButton golfRadioButton;
        private System.Windows.Forms.RadioButton lacrosseRadioButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.PictureBox footballPictureBox;
        private System.Windows.Forms.PictureBox basketballPictureBox;
        private System.Windows.Forms.PictureBox soccerPictureBox;
        private System.Windows.Forms.PictureBox golfPictureBox;
        private System.Windows.Forms.PictureBox lacrossePictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Button resetButton;
    }
}

