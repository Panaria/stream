using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace stream
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Dosya.txt");

            sw.WriteLine(richTextBox1.Text);

            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            StreamReader sr = new StreamReader(openFileDialog1.FileName);

            while (!sr.EndOfStream)
            {
                richTextBox2.Text = sr.ReadLine().ToString();
            }

            sr.Close();
        }
    }
}
