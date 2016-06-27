using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace SoftwareEngineeringProject2016
{
    class HarveySupporter
    {
        private DataTable dt = new DataTable();
        private List<DataColumn> dtColumns = new List<DataColumn>();

        private Excel.Application xlApp;
        private Excel.Workbook xlWorkBook;
        private Excel.Worksheet xlWorkSheet;
        private Excel.Range range;
        private object misValue = System.Reflection.Missing.Value;

        public HarveySupporter(string fileLocation)
        {
            // Add default columns to our datatable
            addColumns();

            // Add DataColumns to our DataTable
            dt.Columns.AddRange(dtColumns.ToArray());

            // Start Excel Application
            xlApp = new Excel.Application();
            // Open workbook
            xlWorkBook = xlApp.Workbooks.Open(fileLocation, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            // Open the worksheet labeled "Sheet1"
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets["Sheet1"];

            // Select the range of the data
            Excel.Range c1 = (Excel.Range)xlWorkSheet.Cells[3, 1];
            Excel.Range c2 = (Excel.Range)xlWorkSheet.Cells[xlWorkSheet.UsedRange.Rows.Count, 14];
            range = xlWorkSheet.get_Range(c1, c2);

            // Set values from the range to an Object 2D array
            Object[,] value = range.Value;

            // For each Object, add a dataRow and fill the data in the appropriate column
            for (int i = 1; i <= value.GetLength(0); i++)
            {
                DataRow dr = dt.NewRow();
                for (int j = 1; j <= value.GetLength(1); j++)
                {
                    //MessageBox.Show("Value: " + value[i, j].ToString());
                    if (value[i, j] != null)
                        dr[j - 1] = value[i, j].ToString();
                    else
                        dr[j - 1] = "";
                    //MessageBox.Show("DR: " + dr[j-1].ToString());
                }
                if (!dr[0].ToString().Equals(""))
                    dt.Rows.Add(dr);
                else
                    continue;
            }
            //MessageBox.Show("src: dt.rows.count = " + dt.Rows.Count);


            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
        }

        public DataColumn getDataColumn(string name)
        {
            foreach (DataColumn column in dt.Columns)
            {
                if (column.ColumnName.Equals(name))
                {
                    return column;
                }
            }

            return null;
        }

        public DataTable getDataTable()
        {
            return dt;
        }

        // Create the DataColumns that we will include in our DataTable
        private void addColumns()
        {
            dtColumns.Add(new DataColumn("Date"));
            dtColumns.Add(new DataColumn("Time"));
            dtColumns.Add(new DataColumn("DieselGenerator"));
            dtColumns.Add(new DataColumn("KWUsage"));
            dtColumns.Add(new DataColumn("VesselSpeed"));
            dtColumns.Add(new DataColumn("Heading"));
            dtColumns.Add(new DataColumn("CurrentSpeed"));
            dtColumns.Add(new DataColumn("WindSpeed"));
            dtColumns.Add(new DataColumn("WindDirection"));
            dtColumns.Add(new DataColumn("Draft"));
            dtColumns.Add(new DataColumn("SeaDirection"));
            dtColumns.Add(new DataColumn("SeaHeight"));
            dtColumns.Add(new DataColumn("Mode"));
			dtColumns.Add(new DataColumn("FuelConsumption"));
		}
    }
}
