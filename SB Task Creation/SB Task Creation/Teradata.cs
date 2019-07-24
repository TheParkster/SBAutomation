using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teradata.Client.Provider;
using System.Windows.Forms;

namespace SB_Task_Creation
{
    class Teradata
    {
        TdConnectionStringBuilder connectionStringBuilder;
        TdConnection cn;
       public Teradata(String user, String pwd)
        {
            connectionStringBuilder = new TdConnectionStringBuilder();
            connectionStringBuilder.AuthenticationMechanism = "LDAP";
            connectionStringBuilder.UserId = user;
            connectionStringBuilder.Password =pwd;
            connectionStringBuilder.DataSource = "10.102.5.28";

            cn = new TdConnection();
        }

        public bool tryConnect()
        {
            try
            {
                cn.ConnectionString = connectionStringBuilder.ConnectionString;

                cn.Open();
                cn.Close();

                return true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        
        }

        public bool doesWorkflowExist(String folder, String workflow)
        {
            String folder_name = "'" + folder + "'";
            String workflow_name = "'" + workflow + "'";

            try
            {
                cn.Open();
                TdCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT count(*) from edw_auv_d.INFA_SESSION_LOG where subject_area = " + folder_name + " and workflow_name =" + workflow_name  + ";";

                Int32 count = (Int32)cmd.ExecuteScalar();
                cn.Close();

                if (count > 0)
                    return true;

                return false;

            }catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
