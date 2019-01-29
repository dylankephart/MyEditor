using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                System.IO.StreamReader sr = new //streamreader
                System.IO.StreamReader(openFileDialog1.FileName); //this takes away from having to type the file path
                //MessageBox.Show(sr.ReadToEnd()); //returns back to file path 
                //sr.Close();

                rtb.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtb.SaveFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
        }
    }
}
