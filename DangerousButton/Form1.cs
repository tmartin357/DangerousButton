using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangerousButton
{
    public partial class Form1 : Form
    {
        string PATH;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string targetDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)+@"\GitHub";
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                if (subdirectory.Remove(0, targetDirectory.Length + 1).StartsWith("PortableGit"))
                {
                    PATH = subdirectory+@"\bin\";
                    return;
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pull("Journal");
        }

        private void pull(string repo)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c dangerous.bat " + repo + " " + PATH + " " + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\GitHub\"+repo;
            //MessageBox.Show(startInfo.Arguments);
            process.StartInfo = startInfo;
            process.Start();
            //MessageBox.Show(process.StandardOutput.ReadToEnd());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            pull("Structure");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pull("Electrical");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pull("GitIntro");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pull("General");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pull("Datasheets");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pull("Business");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pull("spsu-auv-team.github.com");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pull("Design");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pull("Software");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pull("License");
        }


    }
}
