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
            dataGridView1.DataSource = jobs.jobs;
            panel1.Visible = true;
        }

        
        private void Form1_Load_1(object sender, EventArgs e)
        {
            jobs.Leggi();
            panel1.Visible = false;
        }

        private void Combo_f1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Combo_f1.Text)
            {
                case "Job Title":
                    Combo_f2.Items.Clear();
                    Combo_f2.Text = null;
                    Combo_f2.Items.Add("Cybersecurity Analyst");
                    Combo_f2.Items.Add("Marketing Specialist");
                    Combo_f2.Items.Add("AI Researcher");
                    Combo_f2.Items.Add("Sales Manager");
                    Combo_f2.Items.Add("UX Designer");
                    Combo_f2.Items.Add("HR Manager");
                    Combo_f2.Items.Add("Product Manager");
                    break;

                case "Industry":
                    Combo_f2.Items.Clear();
                    Combo_f2.Items.Add("Maufacturing");
                    Combo_f2.Items.Add("Education");
                    Combo_f2.Items.Add("Technology");
                    Combo_f2.Items.Add("Finance");
                    Combo_f2.Items.Add("Telecommunications");
                    break;
                case "Comapany Size":
                    Combo_f2.Items.Clear();
                    Combo_f2.Items.Add("Large");
                    Combo_f2.Items.Add("Mediumt");
                    Combo_f2.Items.Add("Small");
                    break;
                case "Location":
                    Combo_f2.Items.Clear();
                    Combo_f2.Items.Add("San Francisco");
                    Combo_f2.Items.Add("Singapore");
                    Combo_f2.Items.Add("Sydney");
                    Combo_f2.Items.Add("Dubay");
                    Combo_f2.Items.Add("Tokyo");
                    break;
                case "AI Adoption Level":
                    Combo_f2.Items.Clear();
                    Combo_f2.Items.Add("High");
                    Combo_f2.Items.Add("Mediumt");
                    Combo_f2.Items.Add("Low");
                    break;
                case "Automation Risk":
                    Combo_f2.Items.Clear();
                    Combo_f2.Items.Add("High");
                    Combo_f2.Items.Add("Mediumt");
                    Combo_f2.Items.Add("Low");
                    break;
                case "Required Skills":
                    Combo_f2.Items.Clear();
                    Combo_f2.Items.Add("Project Management");
                    Combo_f2.Items.Add("Python");
                    Combo_f2.Items.Add("Cybersecurity");
                    Combo_f2.Items.Add("Machine Learning");
                    Combo_f2.Items.Add("UX/UI Design");
                    Combo_f2.Items.Add("Data Analysis");
                    break;
                case "Salary USD":
                    Combo_f2.Items.Clear();
                    break;
                case "Remote Friendly":
                    Combo_f2.Items.Clear();
                    Combo_f2.Items.Add("Yes");
                    Combo_f2.Items.Add("No");
                    break;
                case "job Growth Projection":
                    Combo_f2.Items.Clear();
                    Combo_f2.Items.Add("Growth");
                    Combo_f2.Items.Add("Stable");
                    Combo_f2.Items.Add("Decline");
                    break;
                default: break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var campo in ) ;
              
        }
    }
}
