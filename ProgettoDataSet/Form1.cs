using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoDataSet
{
    public partial class Form1 : Form
    {
        List jobs = new List();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(this.jobs);

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jobs.Leggi();
        }
    }
}
