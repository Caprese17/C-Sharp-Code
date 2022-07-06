using System;
using System.Collections.Generic;
using System.Text;

namespace CookieSale1
{
    class Cookie
    {
        public string Name;
        public int Amt;

        public Cookie() { }

        public Cookie(string name, int amt)
        {
            this.Name = name; 
            this.Amt = amt;
           
        }
        public void Display()
        {
            Console.WriteLine(Name + "    " + Amt);

        }
        public static Cookie operator +(Cookie co1, Cookie co2)
        {
            Cookie Total = new Cookie();
            Total.Amt = co1.Amt + co2.Amt;
            Total.Name = "Total number of boxes ";

            return Total;
        }

    }

}
