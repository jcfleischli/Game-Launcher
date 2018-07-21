namespace Launcher
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
      this.webBrowser1 = new System.Windows.Forms.WebBrowser();
      this.webBrowser2 = new System.Windows.Forms.WebBrowser();
      this.webBrowser3 = new System.Windows.Forms.WebBrowser();
      this.panel1 = new System.Windows.Forms.Panel();
      this.voteButton = new System.Windows.Forms.Button();
      this.statusLabel = new System.Windows.Forms.Label();
      this.progressBar = new System.Windows.Forms.ProgressBar();
      this.startButton = new System.Windows.Forms.Button();
      this.thiefPicture = new System.Windows.Forms.PictureBox();
      this.piratePicture = new System.Windows.Forms.PictureBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.thiefPicture)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.piratePicture)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // webBrowser1
      // 
      this.webBrowser1.Location = new System.Drawing.Point(232, 189);
      this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
      this.webBrowser1.Name = "webBrowser1";
      this.webBrowser1.Size = new System.Drawing.Size(250, 156);
      this.webBrowser1.TabIndex = 1;
      // 
      // webBrowser2
      // 
      this.webBrowser2.Location = new System.Drawing.Point(5, 3);
      this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
      this.webBrowser2.Name = "webBrowser2";
      this.webBrowser2.Size = new System.Drawing.Size(477, 178);
      this.webBrowser2.TabIndex = 2;
      // 
      // webBrowser3
      // 
      this.webBrowser3.Location = new System.Drawing.Point(5, 189);
      this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
      this.webBrowser3.Name = "webBrowser3";
      this.webBrowser3.Size = new System.Drawing.Size(221, 111);
      this.webBrowser3.TabIndex = 3;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.panel1.Controls.Add(this.voteButton);
      this.panel1.Controls.Add(this.webBrowser1);
      this.panel1.Controls.Add(this.webBrowser3);
      this.panel1.Controls.Add(this.webBrowser2);
      this.panel1.Location = new System.Drawing.Point(0, 61);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(488, 355);
      this.panel1.TabIndex = 4;
      // 
      // voteButton
      // 
      this.voteButton.BackColor = System.Drawing.Color.Silver;
      this.voteButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.voteButton.FlatAppearance.BorderSize = 2;
      this.voteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
      this.voteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.voteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.voteButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.voteButton.Location = new System.Drawing.Point(61, 312);
      this.voteButton.Name = "voteButton";
      this.voteButton.Size = new System.Drawing.Size(110, 32);
      this.voteButton.TabIndex = 4;
      this.voteButton.Text = "Vote!";
      this.voteButton.UseVisualStyleBackColor = false;
      this.voteButton.Click += new System.EventHandler(this.voteButton_Click);
      this.voteButton.MouseEnter += new System.EventHandler(this.voteButton_MouseEnter);
      this.voteButton.MouseLeave += new System.EventHandler(this.voteButton_MouseLeave);
      // 
      // statusLabel
      // 
      this.statusLabel.AutoSize = true;
      this.statusLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.statusLabel.Location = new System.Drawing.Point(115, 419);
      this.statusLabel.Name = "statusLabel";
      this.statusLabel.Size = new System.Drawing.Size(173, 18);
      this.statusLabel.TabIndex = 8;
      this.statusLabel.Text = "Connecting to server...";
      // 
      // progressBar
      // 
      this.progressBar.Location = new System.Drawing.Point(6, 438);
      this.progressBar.Name = "progressBar";
      this.progressBar.Size = new System.Drawing.Size(374, 21);
      this.progressBar.TabIndex = 9;
      // 
      // startButton
      // 
      this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.startButton.BackColor = System.Drawing.Color.Silver;
      this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.startButton.Enabled = false;
      this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.startButton.FlatAppearance.BorderSize = 2;
      this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
      this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.startButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.startButton.Location = new System.Drawing.Point(400, 425);
      this.startButton.Name = "startButton";
      this.startButton.Size = new System.Drawing.Size(82, 34);
      this.startButton.TabIndex = 0;
      this.startButton.Text = "Start";
      this.startButton.UseVisualStyleBackColor = false;
      this.startButton.Click += new System.EventHandler(this.startButton_Click);
      this.startButton.MouseEnter += new System.EventHandler(this.startButton_MouseEnter);
      this.startButton.MouseLeave += new System.EventHandler(this.startButton_MouseLeave);
      // 
      // thiefPicture
      // 
      this.thiefPicture.Image = global::Launcher.Properties.Resources.Thief;
      this.thiefPicture.Location = new System.Drawing.Point(376, -8);
      this.thiefPicture.Name = "thiefPicture";
      this.thiefPicture.Size = new System.Drawing.Size(100, 82);
      this.thiefPicture.TabIndex = 10;
      this.thiefPicture.TabStop = false;
      // 
      // piratePicture
      // 
      this.piratePicture.Image = global::Launcher.Properties.Resources.Pirate;
      this.piratePicture.Location = new System.Drawing.Point(23, -8);
      this.piratePicture.Name = "piratePicture";
      this.piratePicture.Size = new System.Drawing.Size(100, 92);
      this.piratePicture.TabIndex = 11;
      this.piratePicture.TabStop = false;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::Launcher.Properties.Resources.title;
      this.pictureBox1.Location = new System.Drawing.Point(153, -27);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(198, 92);
      this.pictureBox1.TabIndex = 12;
      this.pictureBox1.TabStop = false;
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(102)))), ((int)(((byte)(99)))));
      this.ClientSize = new System.Drawing.Size(488, 465);
      this.Controls.Add(this.startButton);
      this.Controls.Add(this.progressBar);
      this.Controls.Add(this.statusLabel);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.thiefPicture);
      this.Controls.Add(this.piratePicture);
      this.Controls.Add(this.pictureBox1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form2";
      this.Text = "MapleChord Launcher";
      this.Shown += new System.EventHandler(this.Form2_Shown);
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.thiefPicture)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.piratePicture)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
    private System.Windows.Forms.WebBrowser webBrowser1;
    private System.Windows.Forms.WebBrowser webBrowser2;
    private System.Windows.Forms.WebBrowser webBrowser3;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button voteButton;
    private System.Windows.Forms.Label statusLabel;
    private System.Windows.Forms.ProgressBar progressBar;
    private System.Windows.Forms.PictureBox thiefPicture;
    private System.Windows.Forms.PictureBox piratePicture;
    private System.Windows.Forms.Button startButton;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}