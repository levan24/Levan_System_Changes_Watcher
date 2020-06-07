using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ChangeWatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fswMain_Changed(object sender, System.IO.FileSystemEventArgs e)         //e.FullPath - полный путь , e.OldFullPath+ -старое название до изменения
        {
            tbEvents.Text += "Внесены изменения в : " + e.FullPath + "\r\n";   
        }

        private void fswMain_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            tbEvents.Text += "Создан: " + e.FullPath + "\r\n";
        }

        private void fswMain_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            tbEvents.Text += "Удален: " + e.FullPath + "\r\n";
        }

        private void fswMain_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            tbEvents.Text += "Переименован "+ e.OldFullPath+ " На " + e.FullPath + "\r\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"D:\" + textBox1.Text +".txt";

            if (!File.Exists(path))
            {
                string LogInformation = tbEvents.Text + Environment.NewLine;
                File.WriteAllText(path, LogInformation);
            }
            // string AppendLogInformation = "New" + Environment.NewLine;
            // File.AppendAllText(path, AppendLogInformation);
            MessageBox.Show("Log Saved in " + path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbEvents.Clear();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter File Name")
            {
                textBox1.Text = "";

                textBox1.ForeColor = Color.Black;

            }
        }
    }
}
