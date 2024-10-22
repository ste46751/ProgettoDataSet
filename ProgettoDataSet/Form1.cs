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
using System.Windows.Forms.DataVisualization.Charting;

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
            panel2.Visible = false;
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            lista.Leggi();
            panel1.Visible = false;
            panel2.Visible = false;
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
                    Combo_f2.Items.Add("Software Engineer");
                    Combo_f2.Items.Add("Data Scientist");
                    Combo_f2.Items.Add("Operations Manager");
                    break;

                case "industry":
                    Combo_f2.Items.Clear();
                    Combo_f2.Text = null;
                    Combo_f2.Items.Add("Manufacturing");
                    Combo_f2.Items.Add("Education");
                    Combo_f2.Items.Add("Technology");
                    Combo_f2.Items.Add("Finance");
                    Combo_f2.Items.Add("Telecommunications");
                    Combo_f2.Items.Add("Entertainment");
                    Combo_f2.Items.Add("Retail");
                    Combo_f2.Items.Add("Transportation");
                    Combo_f2.Items.Add("Healthcare");
                    Combo_f2.Items.Add("Energy");
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
                    Combo_f2.Items.Add("Dubai");
                    Combo_f2.Items.Add("Tokyo");
                    Combo_f2.Items.Add("New York");
                    Combo_f2.Items.Add("London");
                    Combo_f2.Items.Add("Berlin");
                    Combo_f2.Items.Add("Paris");
                    Combo_f2.Items.Add("Toronto");
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
                    Combo_f2.Items.Add("Marketing");
                    Combo_f2.Items.Add("JavaScript");
                    Combo_f2.Items.Add("Communication");
                    Combo_f2.Items.Add("Marketing");
                    Combo_f2.Items.Add("Sales");
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
        public int GetQuantity(string stringa, string campo)
        {
            int n = 0;

            for (int i = 0; i < lista.jobs.Count; i++)
            {
                var tipo = lista.jobs[i].GetType();  // Ottieni il tipo dell'oggetto
                var proprieta = tipo.GetProperty(campo);  // Ottieni la proprietà
                var valoreProprieta = proprieta.GetValue(lista.jobs[i])?.ToString();  // Ottieni il valore della proprietà come stringa

                if (valoreProprieta == stringa)
                {
                    n++;
                }
            }
            return n;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;

            //PRIMO GRAFICO
            chart1.Series.Clear();
            Series serie1 = new Series
            {
                Name = "Dati",
                ChartType = SeriesChartType.Column, //Tipo di grafico
                IsVisibleInLegend = true

            };

            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 6);
            chart1.ChartAreas[0].AxisX.Interval = 1;

            chart1.Series.Add(serie1);
            string campo = "industry";

            serie1.Points.AddXY("Entertainment", GetQuantity("Entertainment", campo));
            serie1.Points.AddXY("Technology", GetQuantity("Technology", campo));
            serie1.Points.AddXY("Retail", GetQuantity("Retail", campo));
            serie1.Points.AddXY("Education", GetQuantity("Education", campo));
            serie1.Points.AddXY("Finance", GetQuantity("Finance", campo));
            serie1.Points.AddXY("Transportation", GetQuantity("Transportation", campo));
            serie1.Points.AddXY("Telecommunications", GetQuantity("Telecommunications", campo));
            serie1.Points.AddXY("Manufacturing", GetQuantity("Manufacturing", campo));
            serie1.Points.AddXY("Healthcare", GetQuantity("Healthcare", campo));
            serie1.Points.AddXY("Energy", GetQuantity("Energy", campo));

            chart1.Titles.Add("Industries");

            chart1.ChartAreas[0].AxisX.Title = "Industry";
            chart1.ChartAreas[0].AxisY.Title = "Quantity";

            //SECONDO GRAFICO
            chart2.Series.Clear();
            Series serie2 = new Series
            {
                Name = "Dati",
                ChartType = SeriesChartType.Column, 
                IsVisibleInLegend = true

            };

            chart2.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 6);
            chart2.ChartAreas[0].AxisX.Interval = 1;

            chart2.Series.Add(serie2);
            string campo2 = "job_title";

            serie2.Points.AddXY("Cybersecurity Analyst", GetQuantity("Cybersecurity Analyst", campo2));
            serie2.Points.AddXY("Marketing Specialist", GetQuantity("Marketing Specialist", campo2));
            serie2.Points.AddXY("AI Researcher", GetQuantity("AI Researcher", campo2));
            serie2.Points.AddXY("Sales Manager", GetQuantity("Sales Manager", campo2));
            serie2.Points.AddXY("UX Designer", GetQuantity("UX Designer", campo2));
            serie2.Points.AddXY("HR Manager", GetQuantity("HR Manager", campo2));
            serie2.Points.AddXY("Product Manager", GetQuantity("Product Manager", campo2));
            serie2.Points.AddXY("Software Engineer", GetQuantity("Software Engineer", campo2));
            serie2.Points.AddXY("Data Scientist", GetQuantity("Data Scientist", campo2));
            serie2.Points.AddXY("Operations Manager", GetQuantity("Operations Manager", campo2));

            chart2.Titles.Add("");

            chart2.ChartAreas[0].AxisX.Title = "Job";
            chart2.ChartAreas[0].AxisY.Title = "Quantity";

            //TERZO GRAFICO
            chart3.Series.Clear();
            Series serie3 = new Series
            {
                Name = "Dati",
                ChartType = SeriesChartType.Column, 
                IsVisibleInLegend = true

            };

            chart3.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 6);
            chart3.ChartAreas[0].AxisX.Interval = 1;

            chart3.Series.Add(serie3);
            string campo3 = "location";

            serie3.Points.AddXY("Dubai", GetQuantity("Dubai", campo3));
            serie3.Points.AddXY("Singapore", GetQuantity("Singapore", campo3));
            serie3.Points.AddXY("Sydney", GetQuantity("Sydney", campo3));
            serie3.Points.AddXY("San Francisco", GetQuantity("San Francisco", campo3));
            serie3.Points.AddXY("London", GetQuantity("London", campo3));
            serie3.Points.AddXY("Paris", GetQuantity("Paris", campo3));
            serie3.Points.AddXY("Tokyo", GetQuantity("Tokyo", campo3));
            serie3.Points.AddXY("Toronto", GetQuantity("Toronto", campo3));
            serie3.Points.AddXY("New York", GetQuantity("New York", campo3));
            serie3.Points.AddXY("Berlin", GetQuantity("Berlin", campo3));

            chart3.Titles.Add("Locations in the world");

            chart3.ChartAreas[0].AxisX.Title = "Location";
            chart3.ChartAreas[0].AxisY.Title = "Quantity";

            //QUARTO GRAFICO
            chart4.Series.Clear();
            Series serie4 = new Series
            {
                Name = "Dati",
                ChartType = SeriesChartType.Column, 
                IsVisibleInLegend = true

            };

            chart4.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 6);
            chart4.ChartAreas[0].AxisX.Interval = 1;

            chart4.Series.Add(serie4);
            string campo4 = "required_skills";

            serie4.Points.AddXY("UX/UI Design", GetQuantity("UX/UI Design", campo4));
            serie4.Points.AddXY("Marketing", GetQuantity("Marketing", campo4));
            serie4.Points.AddXY("Project Management", GetQuantity("Project Management", campo4));
            serie4.Points.AddXY("JavaScript", GetQuantity("JavaScript", campo4));
            serie4.Points.AddXY("Cybersecurity", GetQuantity("Cybersecurity", campo4));
            serie4.Points.AddXY("Sales", GetQuantity("Sales", campo4));
            serie4.Points.AddXY("Machine Learning", GetQuantity("Machine Learning", campo4));
            serie4.Points.AddXY("Communication", GetQuantity("Communication", campo4));
            serie4.Points.AddXY("Python", GetQuantity("Python", campo4));
            serie4.Points.AddXY("Data Analysis", GetQuantity("Data Analysis", campo4));

            chart4.Titles.Add("Locations in the world");

            chart4.ChartAreas[0].AxisX.Title = "Required Skills";
            chart4.ChartAreas[0].AxisY.Title = "Quantity";
        }
    }
}
