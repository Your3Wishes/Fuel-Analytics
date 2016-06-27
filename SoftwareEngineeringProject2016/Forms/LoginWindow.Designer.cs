namespace SoftwareEngineeringProject2016
{
	partial class LoginWindow
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
			this.ProjectTitleLabel = new System.Windows.Forms.Label();
			this.AuthorNamesLabel = new System.Windows.Forms.Label();
			this.UsernameBox = new System.Windows.Forms.TextBox();
			this.UsernameLabel = new System.Windows.Forms.Label();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.PasswordBox = new System.Windows.Forms.TextBox();
			this.LoginButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.ForgottenInformationLink = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// ProjectTitleLabel
			// 
			this.ProjectTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.ProjectTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProjectTitleLabel.Location = new System.Drawing.Point(14, 14);
			this.ProjectTitleLabel.Margin = new System.Windows.Forms.Padding(5);
			this.ProjectTitleLabel.Name = "ProjectTitleLabel";
			this.ProjectTitleLabel.Size = new System.Drawing.Size(605, 46);
			this.ProjectTitleLabel.TabIndex = 0;
			this.ProjectTitleLabel.Text = "Software Engineering Project 2016";
			this.ProjectTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AuthorNamesLabel
			// 
			this.AuthorNamesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.AuthorNamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AuthorNamesLabel.Location = new System.Drawing.Point(14, 70);
			this.AuthorNamesLabel.Margin = new System.Windows.Forms.Padding(5);
			this.AuthorNamesLabel.Name = "AuthorNamesLabel";
			this.AuthorNamesLabel.Size = new System.Drawing.Size(605, 28);
			this.AuthorNamesLabel.TabIndex = 0;
			this.AuthorNamesLabel.Text = "Christopher LaChance, Walter White, Bradley Williams, Minh-Nhat Duong";
			this.AuthorNamesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// UsernameBox
			// 
			this.UsernameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.UsernameBox.Location = new System.Drawing.Point(159, 170);
			this.UsernameBox.Margin = new System.Windows.Forms.Padding(150);
			this.UsernameBox.Name = "UsernameBox";
			this.UsernameBox.Size = new System.Drawing.Size(315, 20);
			this.UsernameBox.TabIndex = 1;
			this.UsernameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// UsernameLabel
			// 
			this.UsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UsernameLabel.Location = new System.Drawing.Point(14, 138);
			this.UsernameLabel.Margin = new System.Windows.Forms.Padding(5);
			this.UsernameLabel.Name = "UsernameLabel";
			this.UsernameLabel.Size = new System.Drawing.Size(605, 25);
			this.UsernameLabel.TabIndex = 2;
			this.UsernameLabel.Text = "Username:";
			this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PasswordLabel.Location = new System.Drawing.Point(14, 218);
			this.PasswordLabel.Margin = new System.Windows.Forms.Padding(5);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(605, 25);
			this.PasswordLabel.TabIndex = 2;
			this.PasswordLabel.Text = "Password:";
			this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PasswordBox
			// 
			this.PasswordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.PasswordBox.Location = new System.Drawing.Point(159, 246);
			this.PasswordBox.Margin = new System.Windows.Forms.Padding(150);
			this.PasswordBox.Name = "PasswordBox";
			this.PasswordBox.PasswordChar = '*';
			this.PasswordBox.Size = new System.Drawing.Size(315, 20);
			this.PasswordBox.TabIndex = 2;
			this.PasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// LoginButton
			// 
			this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.LoginButton.Location = new System.Drawing.Point(326, 332);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(148, 41);
			this.LoginButton.TabIndex = 3;
			this.LoginButton.Text = "Login";
			this.LoginButton.UseVisualStyleBackColor = true;
			this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelButton.Location = new System.Drawing.Point(159, 332);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(148, 41);
			this.CancelButton.TabIndex = 4;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// ForgottenInformationLink
			// 
			this.ForgottenInformationLink.Location = new System.Drawing.Point(159, 306);
			this.ForgottenInformationLink.Name = "ForgottenInformationLink";
			this.ForgottenInformationLink.Size = new System.Drawing.Size(315, 23);
			this.ForgottenInformationLink.TabIndex = 5;
			this.ForgottenInformationLink.TabStop = true;
			this.ForgottenInformationLink.Text = "Forgot your information?";
			this.ForgottenInformationLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ForgottenInformationLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgottenInformationLink_LinkClicked);
			// 
			// LoginWindow
			// 
			this.AcceptButton = this.LoginButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(633, 400);
			this.Controls.Add(this.ForgottenInformationLink);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.LoginButton);
			this.Controls.Add(this.PasswordBox);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.UsernameBox);
			this.Controls.Add(this.UsernameLabel);
			this.Controls.Add(this.AuthorNamesLabel);
			this.Controls.Add(this.ProjectTitleLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LoginWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label ProjectTitleLabel;
		private System.Windows.Forms.Label AuthorNamesLabel;
		private System.Windows.Forms.TextBox UsernameBox;
		private System.Windows.Forms.Label UsernameLabel;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.TextBox PasswordBox;
		private System.Windows.Forms.Button LoginButton;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.LinkLabel ForgottenInformationLink;
	}
}

