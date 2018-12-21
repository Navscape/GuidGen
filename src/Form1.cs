using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GuidGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rand1 = RandomString(8);
            string rand2 = RandomString(4);
            string rand3 = RandomString(4);
            string rand4 = RandomString(4);
            string rand5 = RandomString(12);
            string GuidGen = "{" + rand1 + "-" + rand2 + "-" + rand3 + "-" + rand4 + "-" + rand5 + "}";
            listBox1.Items.Add(GuidGen);
            listBox1.Text = GuidGen;
            
            string path = "guidfile.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter header = File.CreateText(path))
                {
                    header.WriteLine("*********************************************");
                    header.WriteLine("* Navscape GUID Generator - GUID File: V1.0 *");
                    header.WriteLine("*********************************************");
                    header.WriteLine("");
                }
            }
            StreamWriter sw = File.AppendText(path);
        	sw.WriteLine(listBox1.Text);
	        sw.Close();
            sw.Dispose();

        }
        private static Random random = new Random((int)DateTime.Now.Ticks);
        private string RandomString(int Size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < Size; i++)
            {
                string chars = "ABCDEF0123456789";
                ch = chars[random.Next(chars.Length)];
                builder.Append(ch);
            }
            return builder.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guidfileLabel_Click_1(object sender, EventArgs e)
        {

        }
    }
}