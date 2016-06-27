using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace SoftwareEngineeringProject2016.Forms
{
	public partial class InformationLookupRequestForm : Form
	{
		public InformationLookupRequestForm()
		{
			InitializeComponent();
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			FindForm().Hide();
		}

		private void SubmitButton_Click(object sender, EventArgs e)
		{
			MailMessage resetMessage = new MailMessage();
			resetMessage.To.Add(EmailSubmissionBox.Text);
			resetMessage.From = new MailAddress("softwareengineeringproject2016@gmail.com");
			resetMessage.Subject = "Login Information Requested - Software Engineering Project 2016";

			//We're just hardcoding this in since you're the only one using the application.
			resetMessage.Body = "We have discovered the following information associated with this account:" + 
								"\nUsername: Admin" + "\nPassword: Password";

			SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
			smtp.Credentials = new NetworkCredential("softwareengineeringproject2016@gmail.com","justanormalpassword");
			smtp.EnableSsl = true;
			smtp.Send(resetMessage);

			infoLabel.Text = "We have sent an email to that address. Please check your inbox.";
		}
	}
}
