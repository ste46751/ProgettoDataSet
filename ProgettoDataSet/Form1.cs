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
        
        List lista = new List();
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)

        {
            dataGridView1.DataSource = lista.jobs;
            panel1.Visible = true;
        }

        
        private void Form1_Load_1(object sender, EventArgs e)
        {
            lista.Leggi();
            panel1.Visible = false;
        }

        private void Combo_f1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Combo_f1.Text)
            {
                case "job_title":
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

                case "industry":
                    Combo_f2.Items.Clear();
                    Combo_f2.Text = null;
                    Combo_f2.Items.Add("Manufacturing");
                    Combo_f2.Items.Add("Education");
                    Combo_f2.Items.Add("Technology");
                    Combo_f2.Items.Add("Finance");
                    Combo_f2.Items.Add("Telecommunications");
                    break;
                case "company_size":
                    Combo_f2.Items.Clear();
                    Combo_f2.Text = null;
                    Combo_f2.Items.Add("Large");
                    Combo_f2.Items.Add("Medium");
                    Combo_f2.Items.Add("Small");
                    break;
                case "location":
                    Combo_f2.Items.Clear();
                    Combo_f2.Text = null;
                    Combo_f2.Items.Add("San Francisco");
                    Combo_f2.Items.Add("Singapore");
                    Combo_f2.Items.Add("Sydney");
                    Combo_f2.Items.Add("Dubay");
                    Combo_f2.Items.Add("Tokyo");
                    break;
                case "adoption_level":
                    Combo_f2.Items.Clear();
                    Combo_f2.Text = null;
                    Combo_f2.Items.Add("High");
                    Combo_f2.Items.Add("Medium");
                    Combo_f2.Items.Add("Low");
                    break;
                case "automation_risk":
                    Combo_f2.Items.Clear();
                    Combo_f2.Text = null;
                    Combo_f2.Items.Add("High");
                    Combo_f2.Items.Add("Medium");
                    Combo_f2.Items.Add("Low");
                    break;
                case "required_skills":
                    Combo_f2.Items.Clear();
                    Combo_f2.Text = null;
                    Combo_f2.Items.Add("Project Management");
                    Combo_f2.Items.Add("Python");
                    Combo_f2.Items.Add("Cybersecurity");
                    Combo_f2.Items.Add("Machine Learning");
                    Combo_f2.Items.Add("UX/UI Design");
                    Combo_f2.Items.Add("Data Analysis");
                    break;
                case "salary_usd":
                    Combo_f2.Items.Clear();
                    Combo_f2.Text = null;
                    break;
                case "remote_friendly":
                    Combo_f2.Items.Clear();
                    Combo_f2.Text = null;
                    Combo_f2.Items.Add("Yes");
                    Combo_f2.Items.Add("No");
                    break;
                case "job_growth_projection":
                    Combo_f2.Items.Clear();
                    Combo_f2.Text = null;
                    Combo_f2.Items.Add("Growth");
                    Combo_f2.Items.Add("Stable");
                    Combo_f2.Items.Add("Decline");
                    break;
                default: break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Job> jobs2 = new List<Job>();

            for (int i = 0; i < lista.jobs.Count; i++)
            {
                var tipo = lista.jobs[i].GetType();  // Ottieni il tipo dell'oggetto
                var proprieta = tipo.GetProperty(Combo_f1.SelectedItem.ToString());  // Ottieni la proprietà
                var valoreProprieta = proprieta.GetValue(lista.jobs[i])?.ToString();  // Ottieni il valore della proprietà come stringa

                if (valoreProprieta == Combo_f2.SelectedItem.ToString())
                {
                    jobs2.Add(lista.jobs[i]);
                }
            }
            dataGridView1.DataSource = jobs2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = lista.jobs;
        }
    }
}
