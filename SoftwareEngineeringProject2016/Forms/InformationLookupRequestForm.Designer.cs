namespace SoftwareEngineeringProject2016.Forms
{
	partial class InformationLookupRequestForm
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
			this.infoLabel = new System.Windows.Forms.Label();
			this.EmailSubmissionBox = new System.Windows.Forms.TextBox();
			this.SubmitButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// infoLabel
			// 
			this.infoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.infoLabel.AutoSize = true;
			this.infoLabel.Location = new System.Drawing.Point(14, 14);
			this.infoLabel.Margin = new System.Windows.Forms.Padding(5);
			this.infoLabel.Name = "infoLabel";
			this.infoLabel.Size = new System.Drawing.Size(426, 13);
			this.infoLabel.TabIndex = 0;
			this.infoLabel.Text = "Enter your email address and we\'ll send you the information associated with that " +
    "account:";
			this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// EmailSubmissionBox
			// 
			this.EmailSubmissionBox.Location = new System.Drawing.Point(14, 37);
			this.EmailSubmissionBox.Margin = new System.Windows.Forms.Padding(5);
			this.EmailSubmissionBox.Name = "EmailSubmissionBox";
			this.EmailSubmissionBox.Size = new System.Drawing.Size(426, 20);
			this.EmailSubmissionBox.TabIndex = 1;
			this.EmailSubmissionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// SubmitButton
			// 
			this.SubmitButton.Location = new System.Drawing.Point(332, 67);
			this.SubmitButton.Margin = new System.Windows.Forms.Padding(5);
			this.SubmitButton.Name = "SubmitButton";
			this.SubmitButton.Size = new System.Drawing.Size(108, 27);
			this.SubmitButton.TabIndex = 2;
			this.SubmitButton.Text = "Submit";
			this.SubmitButton.UseVisualStyleBackColor = true;
			this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelButton.Location = new System.Drawing.Point(14, 67);
			this.CancelButton.Margin = new System.Windows.Forms.Padding(5);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(108, 27);
			this.CancelButton.TabIndex = 3;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// InformationLookupRequestForm
			// 
			this.AcceptButton = this.SubmitButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(454, 108);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.SubmitButton);
			this.Controls.Add(this.EmailSubmissionBox);
			this.Controls.Add(this.infoLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "InformationLookupRequestForm";
			this.Text = "Request Login Information";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label infoLabel;
		private System.Windows.Forms.TextBox EmailSubmissionBox;
		private System.Windows.Forms.Button SubmitButton;
		private System.Windows.Forms.Button CancelButton;
	}
}