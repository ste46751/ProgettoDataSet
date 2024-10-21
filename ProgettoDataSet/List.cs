using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoDataSet
{
    internal class List
    {
        public List<Job> jobs= new List<Job>();

        public List() { }

        public void Leggi()
        {
            StreamReader sr = new StreamReader("ai_job_market_insights.csv");

            string[] array = new string[10];
            string linea = sr.ReadLine();
            while (linea != null)
            {
                if (linea != null)
                {
                    array = linea.Split(',');
                    Job job = new Job(array[0], array[1], array[2], array[3], array[4], array[5], array[6], array[7], array[8], array[9]);
                    jobs.Add(job);
                }
                linea = sr.ReadLine();
            }
            sr.Close();



        }
        

        public List<Job> Filtra(string par1, string par2)
        {
            List<Job> nl = new List<Job>();

            for (int i = 0; i < jobs.Count; i++) 
            {
                var tipo= jobs[i].GetType();
                var proprietà = tipo.GetProperty(par2);
                var valore = proprietà.GetValue(jobs[i])?.ToString();
                if(valore == par1)
                {
                    nl.Add(jobs[i]);
                }
                else
                {

                }
            }

            if(nl.Count == 0)
            {
                MessageBox.Show("errore");

                return jobs;
            }
            else
            {
                return nl;
            }

        }   
    }
}
