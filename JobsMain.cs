using System;

namespace Jobs
{
    class Program
    {
        static void Main(string[] args)
        {
            JobInfo job1 = new JobInfo();
            JobInfo job2 = new JobInfo();

            job1.jobDesc = "Plumbing";
            job1.jobHours = 7.5;
            job1.jobRate = 35.00;

            job2.jobDesc = "Electrical";
            job2.jobHours = 3;
            job2.jobRate = 35.00;

            JobInfo jobBoth = job1 + job2; 

        }

        public static JobInfo operator + (JobInfo j1, JobInfo j2)
        {
            JobInfo j3 = new JobInfo();
            j3.jobDesc = j1.jobDesc + "AND" + j2.jobDesc;
            j3.jobHours = j1.jobHours + j2.jobHours;
            j3.jobRate = (j1.jobRate + j2.jobRate) / 2;
            

        }

       


    }

}
