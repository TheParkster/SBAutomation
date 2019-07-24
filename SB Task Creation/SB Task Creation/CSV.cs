using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;


namespace SB_Task_Creation
{
    class CSV
    {
        String filename = "";
        DataTable workflows;

        public CSV(String file)
        {
            filename = file;

            this.parseFile();
        }

        public DataTable getWorkflowList()
        {
            return workflows;
        }

        private void parseFile()
        {
            try {
                workflows = new DataTable();
                workflows.Columns.Add("FolderName");
                workflows.Columns.Add("WorkflowName");
                workflows.Columns.Add("Unicode");
                String[] temp;

                foreach (string str in File.ReadLines(filename))
                {
                    temp = str.Split(',');
                    DataRow drow = workflows.NewRow();   // Here you will get an actual instance of a DataRow
                    drow["FolderName"] = temp[0];
                    drow["WorkflowName"] = temp[1];
                    drow["Unicode"] = temp[2];
                    // Assign values 
                    workflows.Rows.Add(drow);             // add the row to the DataTable.             
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Not a Valid CSV: "  + "\n" + ex.Message);
            }
        
        
        }

    }
}
