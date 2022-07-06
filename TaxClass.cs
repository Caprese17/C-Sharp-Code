using System;
using System.Collections.Generic;
using System.Text;

namespace TaxIt
{
    class Tax
    {
        public string Name { get; set; }
        private double price;
        private double taxowed;

        public double Price
        {
            get { return price; }
            set { price = value;
                //TaxCalc();
                taxowed = value * 0.0825;
            }
        }

        public double Taxowed
        { 
            get { return taxowed; }
        }

        //private void TaxCalc()
        //{
        //    taxowed = value * 0.0825;
        //}
    }
}
