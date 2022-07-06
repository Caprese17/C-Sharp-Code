using System;

namespace FineForOverdueBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nPlease Enter The Number of Days Your Book is Overdue   ");
            int dys = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nPlease Enter How Many books you Have Checked Out       ");
            int bks = Convert.ToInt32(Console.ReadLine());
            
            FineCalc(dys, bks);

            Console.ReadLine();
        }
    
        static void FineCalc(int days, int books)
        {
            double sum = 0;

            if (days <= 7)
                sum = books * 0.10 + (days * .10);
            else if (days > 7)
                sum = books * 0.20 + 7 * 0.10 + (days - 7) * 0.20;

            Console.WriteLine("Your Fine Is: {0:C} ", sum);


            /*int sum = 0;
            
            for(int x = 1; x <= 7; x++)
            //while (days <= 7)
            {
                double dayfine = 0.10;
                days = days * Convert.ToInt32(dayfine);
                books = books * Convert.ToInt32(dayfine);
                sum = books + days;
                
            }
            Console.WriteLine("Your Fine Is: {0:C} ", sum);  


            for (int x = 1; x > 7; x++)
            //while (days > 7)
            {
                int daysOver7 = days - 7;
                double over7fine = 0.20;
                daysOver7 = daysOver7 * Convert.ToInt32(over7fine);
                books = books * Convert.ToInt32(over7fine);
                sum = books + days; 
            }
            Console.WriteLine("Your Fine Is: {0:C} ", sum);*/


           
            
        }

    
    
    
    
    
    
    }

}
