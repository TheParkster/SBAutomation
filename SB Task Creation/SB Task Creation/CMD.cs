using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace SB_Task_Creation
{
    class CMD
    {
        private static String output, error, powershellcommand  = "";

        public CMD(String taskname, String parameters, String user, String pwd)
        {

            powershellcommand = "Powershell -ExecutionPolicy Bypass -F c:" +
            addDoubleQuotes("api_create_taskUnix") +
            ".ps1 -New_task_name " + taskname + " -New_parameters " +
            addDoubleQuotes(parameters) + " -User " + addDoubleQuotes(user) +
            " -Pass " + addDoubleQuotes(pwd);

            this.runCommandLine();
        }

        public CMD(String taskname, String user, String pwd)
        {
            powershellcommand = "Powershell -ExecutionPolicy Bypass -F c:" +
            addDoubleQuotes("api_create_Workflow") +
            ".ps1 -New_task_name " + taskname + " -User " + addDoubleQuotes(user) +
            " -Pass " + addDoubleQuotes(pwd);

            this.runCommandLine();
        }

        private void runCommandLine()
        {
            ProcessStartInfo cmdStartInfo = new ProcessStartInfo();
            cmdStartInfo.FileName = @"C:\Windows\System32\cmd.exe";
            cmdStartInfo.RedirectStandardOutput = true;
            cmdStartInfo.RedirectStandardError = true;
            cmdStartInfo.RedirectStandardInput = true;
            cmdStartInfo.UseShellExecute = false;
            cmdStartInfo.CreateNoWindow = true;

            Process cmdProcess = new Process();
            cmdProcess.StartInfo = cmdStartInfo;
            cmdProcess.ErrorDataReceived += cmd_Error;
            cmdProcess.OutputDataReceived += cmd_DataReceived;
            cmdProcess.EnableRaisingEvents = true;
            cmdProcess.Start();
            cmdProcess.BeginOutputReadLine();
            cmdProcess.BeginErrorReadLine();

            cmdProcess.StandardInput.WriteLine(powershellcommand);     //Execute
            cmdProcess.StandardInput.WriteLine("exit");                  //Execute exit.

            cmdProcess.WaitForExit();
        }

        private static String addDoubleQuotes(string value)
        {
            return "\"" + value + "\"";
        }

        private void cmd_DataReceived(object sender, DataReceivedEventArgs e)
        {
            try {
                String temp = (String)e.Data;
                if (!(temp.Contains("Microsoft") || temp.Contains("Copyright") || temp.Contains(@"C:\")) && temp != "")
                    output += temp + Environment.NewLine;
            }catch(NullReferenceException)
            {
                //do nothing, happens after all processing is done, probably has to do with handling e in the parameters but don't feel like spending the time to fix it :)
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                error += ex.Message;
            }

        }

        public String getOutput()
        {
            if (error.Length == 0)
                return output;

            return output + error;
        }

        public void resetOutput()
        {
            output = "";
            error = "";
        }


        private void cmd_Error(object sender, DataReceivedEventArgs e)
        {
            error += e.Data;
        }


    }



    }
