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
    public partial class PatternSelector : Form
    {
        string directoryToRead = null;
        List<string> attributes;
        bool toggleList = false;
        PatternFinder patternFinder = new PatternFinder();
        HarveyChampion harveyChampionDT;
        HarveySupporter harveySupporterDT;
        Sisuaq sisuaqDT;
        bool sisuaq = false;
        bool supporter = false;
        bool champion = false;
        string savePath = "temp.arff";

		private MainWindow mainWindow = null;
        public PatternSelector(Form callingForm)
        {
			mainWindow = callingForm as MainWindow;
            InitializeComponent();
            button5.Enabled = false;
        }

        // Select Harvey Supporter Database
        private void button1_Click(object sender, EventArgs e)
        {
           browseForFile("Please choose Harvey Supporter Database.");
            if (directoryToRead != null)
            {
                harveySupporterDT = new HarveySupporter(directoryToRead);
                button5.Enabled = true;
            }
            supporter = true;
            champion = false;
            sisuaq = false;
        }

        // Select Harvey Champion Database
        private void button2_Click(object sender, EventArgs e)
        {
            browseForFile("Please choose Harvey Champion Database.");
            if (directoryToRead != null)
            {
                harveyChampionDT = new HarveyChampion(directoryToRead);
                button5.Enabled = true;
            }
            supporter = false;
            champion = true;
            sisuaq = false;       
        }

        // Select Sisuaq Database
        private void button3_Click(object sender, EventArgs e)
        {
            browseForFile("Please choose Sisuaq Database.");
            if (directoryToRead != null)
            {
                sisuaqDT = new Sisuaq(directoryToRead);
                button5.Enabled = true;
            }
            supporter = false;
            champion = false;
            sisuaq = true;
        }

        // Select Attributes to Look for patterns with
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            attributes = checkedListBox1.CheckedItems.OfType<string>().ToList();
        }

        // Select/Deselect all attributes
        private void button4_Click(object sender, EventArgs e)
        {
            if (toggleList == false) toggleList = true;
            else toggleList = false;

            // Loop through and set all to checked or not checked.
            for (int x = 0; x < checkedListBox1.Items.Count; x++)
            {
                checkedListBox1.SetItemChecked(x, toggleList);
            }

            attributes = checkedListBox1.CheckedItems.OfType<string>().ToList();
            button5.Enabled = true;
        }

        // Find patterns
        private void button5_Click(object sender, EventArgs e)
        {
            attributes = checkedListBox1.CheckedItems.OfType<string>().ToList();
            if (supporter)
            {
                DataTableToARFF.exportToARFF(harveySupporterDT.getDataTable(), attributes, savePath);
            }

            else if (champion)
            {
                DataTableToARFF.exportToARFF(harveyChampionDT.getDataTable(), attributes, savePath);
            }

            else if (sisuaq)
            {
                DataTableToARFF.exportToARFF(sisuaqDT.getDataTable(), attributes, savePath);
            }

            patternFinder.findPatterns(savePath);
			this.mainWindow.outputTextBox.Text = patternFinder.getDataTree();
        }

        // Browse for a Database
        private void browseForFile(string message)
        {
            OpenFileDialog fileBrowser = new OpenFileDialog();

            // Set the file browser to filter .xls files
            fileBrowser.Filter = "Excel File XLS (*.xls)|*.xls";

            // Set the file browser's name to Select an Excel File
            fileBrowser.Title = message;

            // Show the dialog and get result.
            DialogResult result = fileBrowser.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                directoryToRead = fileBrowser.FileName;
            }
        }
    }
}
