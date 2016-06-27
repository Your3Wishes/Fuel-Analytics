using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineeringProject2016.Forms
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			//When this form closes, close the application.
			Application.Exit();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.PatternSelector databaseSelector = new Forms.PatternSelector(this);
            databaseSelector.Show();
        }
    }
}
