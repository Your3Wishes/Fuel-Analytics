using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SoftwareEngineeringProject2016
{
    class DataTableToARFF
    {
        
        public static void exportToARFF(DataTable DT, List<string> columns, string saveLocation)
        {
            List<string> lines = new List<string>();

            lines.Add("@relation fuel_consumption");

            foreach(DataColumn column in DT.Columns)
            {
                if (columns.Contains(column.ColumnName))
                {
                    lines.Add("@attribute '" + column.ColumnName.ToLower() + "' " + getColumnType(column.ColumnName));
                }
            }

            lines.Add("@attribute '" + "class" + "' " + getColumnType("fuelconsumption"));

            lines.Add("@data");

            for(int i = 0; i < DT.Rows.Count; i++)
            {
                string line = "";
                DataRow dr = DT.Rows[i];
                for (int j = 0; j < DT.Columns.Count - 1; j++)
                {
                    string columnName = DT.Columns[j].ColumnName;
                    if (columns.Contains(columnName))
                        line = line + dr[j].ToString() + ",";
                }
                line = line + "" + getConvertFuelType(Convert.ToDouble(dr[DT.Columns.Count - 1]));

                lines.Add(line);
            }

            System.IO.File.WriteAllLines(saveLocation, lines);
        }

        private static string getColumnType(string ColumnName)
        {
            switch (ColumnName.ToLower())
            {
                case "date":
                    return "string";
                    break;
                case "time":
                    return "string";
                    break;
                case "dieselgenerator":
                    return "{ 1, 2, 3, 4, 1\\2, 1\\3, 1\\4, 2\\3, 2\\4, 3\\4, 1\\2\\3, 2\\3\\4, 1\\2\\3\\4 }";
                    break;
                case "fuelconsumption":
                    return "{ bad, poor, average, good, excellent }";
                    break;
                case "propellorrpm":
                    return "numeric";
                    break;
                case "kwusage":
                    return "numeric";
                    break;
                case "vesselspeed":
                    return "numeric";
                    break;
                case "heading":
                    return "numeric";
                    break;
                case "currentspeed":
                    return "numeric";
                    break;
                case "windspeed":
                    return "numeric";
                    break;
                case "winddirection":
                    return "{ N, S, E, W, NE, NW, SE, SW, NNE, NNW, WSW, 0, ENE, ESE, SSW, WNW, Var }";
                    break;
                case "draft":
                    return "numeric";
                    break;
                case "seadirection":
                    return "{ N, S, E, W, NE, NW, SE, SW, NNE, NNW, WSW, 0, ENE, ESE, SSW, WNW, Var }";
                    break;
                case "seaheight":
                    return "numeric";
                    break;
                case "dpops":
                    return "{ N/A, DP-Working, DP-Standby, Dp-AutoHead/Sway}";
                    break;
                case "mode":
                    return "{ Underway, OnDPWorking, OnDP500mz, OnDP150mz, OnDP300mz, OnDP400mz, DP }";
                    break;
                case "transitassettime":
                    return "numeric";
                    break;
                case "dpcargoops":
                    return "{ Cargoops, S/BY, Supplies, Fuel }";
                    break;
                case "vesselmode":
                    return "{ DP}";
                    break;
            }
            return "";
        }

        private static string getConvertFuelType(double fuel)
        {
            if (fuel < 34)
            {
                return "excellent";
			}

            else if (fuel < 49)
            {
                return "good";
            }

            else if (fuel < 64)
            {
                return "average";
            }

            else if (fuel < 79)
            {
                return "poor";
            }

            else
            {
                return "bad";
            }
        }

    }
}
