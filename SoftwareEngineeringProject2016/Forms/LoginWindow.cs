using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineeringProject2016
{
	public partial class LoginWindow : Form
	{
		public LoginWindow()
		{
			InitializeComponent();
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void LoginButton_Click(object sender, EventArgs e)
		{
			//loginMethod(UsernameBox.Text, PasswordBox.Text);

			//Hardcoded an admin account and password since you're the only one using it.
			if (UsernameBox.Text.ToLower() == "admin" && (PasswordBox.Text.ToLower() == "password" || PasswordBox.Text == ""))
			{
				Forms.MainWindow mainWindow = new Forms.MainWindow();
				mainWindow.Show();

				this.FindForm().Hide();
			}

			else
			{
				UsernameLabel.Text = "Incorrect Account Details! Please try again:";
			}
		}

		private void ForgottenInformationLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Forms.InfoRequestForm infoLookupForm = new Forms.InfoRequestForm();
			infoLookupForm.Show();
		}
	}
}
