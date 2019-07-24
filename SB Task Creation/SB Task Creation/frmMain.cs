using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teradata.Client.Provider;
using System.IO;
using System.Threading;

namespace SB_Task_Creation
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            rchOutput.Text = "";

            if (txtFolderName.Text == "" || txtWorkflowName.Text == "" || txtUserName.Text == "" || txtWorkflowName.Text == "")
                MessageBox.Show("Not All Information Has Been Entered");
            else
            {
                try
                {
                    Teradata td = new Teradata(txtUserName.Text, txtPassword.Text);
                    this.addMessage("Attempting to Connect to Teradata.....");

                    if (td.tryConnect())
                    {
                        this.addMessage("Teradata Connection Successful");
                        this.addMessage("Checking to see if workflow exists....");

                        if (td.doesWorkflowExist(txtFolderName.Text, txtWorkflowName.Text))
                        {
                            this.addMessage(txtFolderName.Text + "_" + txtWorkflowName.Text + " Found in DEV");

                            CMD powershell = new CMD(this.buildTaskName(), this.buildParameter(), txtUserName.Text, txtPassword.Text);

                            this.addMessage("Creating SB Task For " + txtFolderName.Text + "_" + txtWorkflowName.Text + ".....");
                            this.addMessage(powershell.getOutput());

                            powershell.resetOutput();

                        }
                        else
                            this.addMessage(txtFolderName.Text + "_" + txtWorkflowName.Text + " Not Found in DEV");
                    }
                    else
                        this.addMessage("Failed Connection: Please See Error Box");


                }
                catch (Exception ex)
                {
                    this.addMessage(ex.Message);
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private String buildTaskName()
        {
            return txtFolderName.Text + "_" + txtWorkflowName.Text;
        }

        private String buildTaskName(String folder, String workflow)
        {
            return folder + "_" + workflow;
        }

        private String buildParameter()
        {
            if(chkUnicode.Checked)
                return "-f " + txtFolderName.Text + " " + txtWorkflowName.Text + " -tu";

            return "-f " + txtFolderName.Text + " " + txtWorkflowName.Text + " -t";
        }

        private String buildParameter(String folder, String workflow, String unicode)
        {
            if(unicode.Trim() == "Y")
                return "-f " + folder + " " + workflow + " -tu";
            else
                return "-f " + folder + " " + workflow + " -t";
        }

        public void addMessage(String msg)
        {
            rchOutput.Text += msg + Environment.NewLine;
            rchOutput.Refresh();
            rchOutput.SelectionStart = rchOutput.Text.Length;
            // scroll automatically
            rchOutput.ScrollToCaret();
        }



        private void frmMain_Load(object sender, EventArgs e)
        {
            dgvWorkflows.Columns[0].Name = "FolderName";
            dgvWorkflows.Columns[0].HeaderText = "FolderName";
            dgvWorkflows.Columns[0].DataPropertyName = "FolderName";
            dgvWorkflows.Columns[1].Name = "WorkflowName";
            dgvWorkflows.Columns[1].HeaderText = "WorkflowName";
            dgvWorkflows.Columns[1].DataPropertyName = "WorkflowName";
            dgvWorkflows.Columns[2].Name = "Unicode";
            dgvWorkflows.Columns[2].HeaderText = "Unicode";
            dgvWorkflows.Columns[2].DataPropertyName = "Unicode";

            txtWorkflow.Text = "TD_US_<DOMAIN>_<DATABASE>";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFolderName.Text = "";
            txtWorkflowName.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            rchOutput.Text = "";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog

            if (result == DialogResult.OK) // Test result.
                txtBrowse.Text = openFileDialog1.FileName;
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvWorkflows.DataSource = null;
            CSV file = new CSV(txtBrowse.Text);
            dgvWorkflows.DataSource = file.getWorkflowList();
            dgvWorkflows.AutoResizeColumns();
            this.AcceptButton = btnRunMultiple;
        }

        private void btnClearMultiple_Click(object sender, EventArgs e)
        {
            dgvWorkflows.DataSource = null;

            txtBrowse.Text = "";
            txtPasswordMultiple.Text = "";
            txtUserNameMultiple.Text = "";
            rchOutput.Text = "";
        }

        private void btnRunMultiple_Click(object sender, EventArgs e)
        {
            rchOutput.Text = "";

            try
            {
                int TDsuccess=0, TDfail=0, SBsuccess=0, SBfail = 0;
                String[,] success = new String[dgvWorkflows.Rows.Count, 3];
                String[,] fail = new String[dgvWorkflows.Rows.Count, 3];

                if (txtUserNameMultiple.Text == "" || txtPasswordMultiple.Text == "" || dgvWorkflows.Rows.Count == 0)
                    MessageBox.Show("Not All Information Has Been Entered");
                else
                {
                    Teradata tdmultiple = new Teradata(txtUserNameMultiple.Text, txtPasswordMultiple.Text);
                    this.addMessage("Attempting to Connect to Teradata.....");

                    if (tdmultiple.tryConnect())
                    {
                        this.addMessage("Teradata Connection Successful!");

                        this.addMessage("Checking to see if workflow exists....");

                        for (int i = 0; i < dgvWorkflows.Rows.Count; i++)
                        {
                            if (tdmultiple.doesWorkflowExist(dgvWorkflows.Rows[i].Cells[0].Value.ToString(), dgvWorkflows.Rows[i].Cells[1].Value.ToString()))
                            {
                                this.addMessage(dgvWorkflows.Rows[i].Cells[0].Value.ToString() + " " + dgvWorkflows.Rows[i].Cells[1].Value.ToString() + " Found in DEV");
                                success[TDsuccess, 0] = dgvWorkflows.Rows[i].Cells[0].Value.ToString();
                                success[TDsuccess, 1] = dgvWorkflows.Rows[i].Cells[1].Value.ToString();
                                success[TDsuccess, 2] = dgvWorkflows.Rows[i].Cells[2].Value.ToString();
                                TDsuccess++;
                            }
                            else
                            {
                                fail[TDfail, 0] = dgvWorkflows.Rows[i].Cells[0].Value.ToString();
                                fail[TDfail, 1] = dgvWorkflows.Rows[i].Cells[1].Value.ToString();
                                fail[TDfail, 2] = dgvWorkflows.Rows[i].Cells[2].Value.ToString();
                                TDfail++;
                                this.addMessage(dgvWorkflows.Rows[i].Cells[0].Value.ToString() + " " + dgvWorkflows.Rows[i].Cells[1].Value.ToString() + " NOT Found in DEV");
                            }
                        }

                        this.addMessage("");
                        for (int i = 0; i < TDsuccess; i++)
                        {
                            int milliseconds = 250;
                            Thread.Sleep(milliseconds);//added because it was running too fast, powershell script was still being used by previous process(add multi-threading?)

                            this.addMessage(Environment.NewLine + "Creating SB Task For " + (String)success[i, 0] + "_" + (String)success[i, 1] + ".....");

                            CMD powershell = new CMD(this.buildTaskName((String)success[i, 0], (String)success[i, 1]), this.buildParameter((String)success[i, 0], (String)success[i, 1], (String)success[i, 2]), txtUserNameMultiple.Text, txtPasswordMultiple.Text);

                            if (powershell.getOutput().Contains("Success"))
                                SBsuccess++;
                            else
                                SBfail++;

                            this.addMessage(powershell.getOutput());

                            powershell.resetOutput();
                        }

                        this.addMessage("");
                        this.addMessage("TD Workflows Found: " + TDsuccess + Environment.NewLine + "TD Workflows Not Found:" + TDfail);
                        this.addMessage("SB Success: " + SBsuccess + Environment.NewLine + "SB Fail: " + SBfail);
                    }
                    else
                        this.addMessage("Failed Connection: Please See Error Box");

                }
            }catch(Exception ex)
            {
                this.addMessage(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("StoneBranch Task Creation v1.0 for QVC" + "\n" + "Q:\EDW - Teradata\EDW - SB Task Creator\Stonebranch Task and Workflow Creation Documentation.docx");
        }

        private void btnRunWorkflow_Click(object sender, EventArgs e)
        {
            rchOutput.Text = "";

            try
            {
                if (!(txtPasswordWorkflow.Text.Equals("") || txtUserNameWorkflow.Text.Equals("") || txtWorkflow.Text.Equals("")))
                {
                    this.addMessage("Creating Workflow " + txtWorkflow.Text + ".....");
                    CMD worklow = new CMD(txtWorkflow.Text, txtUserNameWorkflow.Text, txtPasswordWorkflow.Text);
                    this.addMessage(worklow.getOutput());
                }
                else
                    MessageBox.Show("Not All Information Is Entered");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClearWorkflow_Click(object sender, EventArgs e)
        {
            txtPasswordWorkflow.Clear();
            txtUserNameWorkflow.Clear();
            rchOutput.Clear();
            txtWorkflow.Clear();
        }
    }
}
