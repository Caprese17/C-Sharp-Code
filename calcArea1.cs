using System;

namespace calcArea1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stopLoop = false;
            while (stopLoop == false)
            {
                Console.WriteLine("Would you like the area of a square or a triage? Please enter S for square, or T for triangle ");
                string input = Convert.ToString(Console.ReadLine());
                input.ToUpper();
                if (input == "S")
                {
                    Console.WriteLine("How many inches are the sides of the square?");
                    int Sside = Convert.ToInt32(Console.ReadLine());

                    int sqrAreares = SquareArea(Sside);

                    Console.WriteLine("The area of the {0} x {1} square is {2}", Sside, Sside, sqrAreares);
                }

                if (input == "T")
                {
                    Console.Write("Enter the Base of the triangle:");
                    double Base = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the Height of the triangle:");
                    double Height = Convert.ToDouble(Console.ReadLine());

                    double triAreares = TriangleArea(Base, Height);

                    Console.WriteLine("The area of the {0} x {1} triangle is {2}", Base, Height, triAreares);
                }

                Console.WriteLine("Are you finished getting the area of the shapes? Y or N ");
                string ans = Convert.ToString(Console.ReadLine());
                ans.ToUpper();
                if (ans == "Y")
                    Console.WriteLine("Thank you! Good Bye!");
                    stopLoop = true;
                if (ans == "N")
                    stopLoop = false;
            }
        }
        public static int SquareArea(int side)
        {
            int area = side * side;
            return area;

        }
        public static double TriangleArea(double B, double H)
        {
            double area = (B * H) / 2;
            return area;
        }
    }
}
        
    

