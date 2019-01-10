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

namespace DataCapture
{
    public partial class Form1 : Form
    {
        StreamWriter writer;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select location to store CSV capture data.";
            openFileDialog1.Filter = "CSV files |*.csv";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "data_capture.csv";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter sr = new
                   StreamWriter(openFileDialog1.FileName);
            }
        }
    }
}
