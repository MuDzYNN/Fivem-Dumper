using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuperUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            label2.Visible = false;
            textBox3.Visible = false;
            label3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Visible = checkBox1.Checked;
            label2.Visible = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Visible = checkBox2.Checked;
            label3.Visible = checkBox2.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                {
                label5.Text = "Enter server IP!";
                return;
            }
            string command = "java -jar " + Directory.GetCurrentDirectory() + "\\fivem-client-dumper-1.0.2-SNAPSHOT-all.jar -a " + textBox1.Text;
            if (checkBox1.Checked)
            {
                if (textBox2.Text == "")
                {
                    label5.Text = "Enter server port!";
                    return;
                }
                command = command + " -p " + textBox2.Text;
            }
            if (checkBox2.Checked)
            {
                if (textBox3.Text == "")
                {
                    label5.Text = "Enter name of directory!";
                    return;
                }
                command = command + " -o " + textBox3.Text;
            }
            label5.Text = "";
            var proc1 = new ProcessStartInfo();
            ///System.Diagnostics.Process.Start("CMD.exe", command);
            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Arguments = "/k " + command;
            proc1.WindowStyle = ProcessWindowStyle.Maximized;
            Process.Start(proc1);
        }
    }
}
