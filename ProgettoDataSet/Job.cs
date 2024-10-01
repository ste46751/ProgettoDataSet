using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoDataSet
{
    internal class Job
    {
        public string job_title { get; set; }
        public string industry { get; set; }
        public string company_size { get; set;}
        public string location { get; set; }
        public string adoption_level { get; set;}
        public string automation_risk { get; set;}
        public string required_skills { get; set;}
        public string salary_usd { get; set; }
        public string remote_friendly { get; set; }
        public string job_growth_projection { get; set;}

        public Job(string job_title, string industry, string company_size, string location, string adoption_level, string automation_risk, string required_skills, string salary_usd, string remote_friendly, string job_growth_projection)
        {
            this.job_title = job_title;
            this.industry = industry;
            this.company_size = company_size;
            this.location = location;
            this.adoption_level = adoption_level;
            this.automation_risk = automation_risk;
            this.required_skills = required_skills;
            this.salary_usd = salary_usd;
            this.remote_friendly = remote_friendly;
            this.job_growth_projection = job_growth_projection;
        }
    }
}
