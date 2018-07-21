namespace Launcher
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.usernameLabel = new System.Windows.Forms.Label();
      this.passwordLabel = new System.Windows.Forms.Label();
      this.loginButton = new System.Windows.Forms.Button();
      this.usernameBox = new System.Windows.Forms.TextBox();
      this.passwordBox = new System.Windows.Forms.TextBox();
      this.rememberBox = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // usernameLabel
      // 
      this.usernameLabel.AutoSize = true;
      this.usernameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.usernameLabel.Location = new System.Drawing.Point(12, 27);
      this.usernameLabel.Name = "usernameLabel";
      this.usernameLabel.Size = new System.Drawing.Size(87, 19);
      this.usernameLabel.TabIndex = 0;
      this.usernameLabel.Text = "Username";
      // 
      // passwordLabel
      // 
      this.passwordLabel.AutoSize = true;
      this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.passwordLabel.Location = new System.Drawing.Point(19, 72);
      this.passwordLabel.Name = "passwordLabel";
      this.passwordLabel.Size = new System.Drawing.Size(80, 19);
      this.passwordLabel.TabIndex = 1;
      this.passwordLabel.Text = "Password";
      // 
      // loginButton
      // 
      this.loginButton.BackColor = System.Drawing.Color.Silver;
      this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
      this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.loginButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.loginButton.Location = new System.Drawing.Point(127, 133);
      this.loginButton.Name = "loginButton";
      this.loginButton.Size = new System.Drawing.Size(84, 28);
      this.loginButton.TabIndex = 2;
      this.loginButton.Text = "Login";
      this.loginButton.UseVisualStyleBackColor = false;
      this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
      this.loginButton.MouseEnter += new System.EventHandler(this.loginButton_MouseEnter);
      this.loginButton.MouseLeave += new System.EventHandler(this.loginButton_MouseLeave);
      // 
      // usernameBox
      // 
      this.usernameBox.Location = new System.Drawing.Point(106, 28);
      this.usernameBox.Name = "usernameBox";
      this.usernameBox.Size = new System.Drawing.Size(133, 20);
      this.usernameBox.TabIndex = 3;
      // 
      // passwordBox
      // 
      this.passwordBox.Location = new System.Drawing.Point(106, 73);
      this.passwordBox.Name = "passwordBox";
      this.passwordBox.PasswordChar = '*';
      this.passwordBox.Size = new System.Drawing.Size(133, 20);
      this.passwordBox.TabIndex = 4;
      // 
      // rememberBox
      // 
      this.rememberBox.AutoSize = true;
      this.rememberBox.Location = new System.Drawing.Point(106, 105);
      this.rememberBox.Name = "rememberBox";
      this.rememberBox.Size = new System.Drawing.Size(106, 17);
      this.rememberBox.TabIndex = 5;
      this.rememberBox.Text = "Remember Login";
      this.rememberBox.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(336, 190);
      this.Controls.Add(this.rememberBox);
      this.Controls.Add(this.passwordBox);
      this.Controls.Add(this.usernameBox);
      this.Controls.Add(this.loginButton);
      this.Controls.Add(this.passwordLabel);
      this.Controls.Add(this.usernameLabel);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "MapleChord Launcher";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.CheckBox rememberBox;
    }
}

