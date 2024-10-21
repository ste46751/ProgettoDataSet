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

    }
}
