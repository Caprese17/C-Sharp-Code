using System;
using System.Collections.Generic;
using System.Text;

namespace Jobs
{
    class JobInfo
    {
        public string jobDesc;
        public double jobHours;
        public double jobRate;
        public double totalFee { get; }

        public JobDesc
        {
            get{ Return jobDesc; }
            set {jobDesc = value; }
        }
            
        
        public JobHours
        {
            get {return jobHours;}
            
            set
            {
                jobHours = Value;
                CalcTotalFee();
            }
        } 
         
        public JobRate
       {
        get { return jobRate; }
        set { jobRate = value;
        CalcTotalFee(); }
 
        }

public totalFee
{
    
}
      
   

    }

}
