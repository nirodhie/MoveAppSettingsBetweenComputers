using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace MoveAppSettingsBetweenComputers
{
    public partial class Form1 : Form
    {


        
        public Form1()
        {
            InitializeComponent();
            //checkBox1.Text = applocation1;
            checkBox1.Text = valueFromFile("appSettingsLocation.txt", 0);
            checkBox2.Text = valueFromFile("appSettingsLocation.txt", 1);
            checkBox3.Text = returnCMDoutput("powershell.exe", "(Get-WmiObject -Class win32_bios).serialnumber");
            checkBox4.Text = returnCMDoutput("cmd.exe", "/c hostname");

            performCMD("cmd.exe", "/c echo "+ valueFromFile("appSettingsLocation.txt", 1) + "&& pause");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private string valueFromFile (string file,int lineNumber)
        {
           return  File.ReadLines(file).Skip(lineNumber).Take(1).First();
        }

        private string returnCMDoutput(string command, string arguments)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @command;
            //provide powershell script full path
            startInfo.Arguments = @arguments;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            Process process = new Process();
            process.StartInfo = startInfo;
            // execute script call start process
            process.Start();
            // get output information
            string output = process.StandardOutput.ReadToEnd();

            // catch error information
            string errors = process.StandardError.ReadToEnd();
            return output;
        }

        private void performCMD(string command, string arguments)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @command;
            //provide powershell script full path
            startInfo.Arguments = @arguments;
            startInfo.RedirectStandardOutput = false;
            startInfo.RedirectStandardError = false;
            startInfo.UseShellExecute = true;
            startInfo.CreateNoWindow = false;
            Process process = new Process();
            process.StartInfo = startInfo;
            // execute script call start process
            process.Start();
                        
        }




    }
} 