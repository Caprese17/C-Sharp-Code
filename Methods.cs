using System;

namespace MethodsInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("There");

            // calling my method
            ShowOnScreen();

            int a = 12;
            Console.WriteLine("The value of 'a' in the Main is {0}.", a);
             MethodOwnA();
            Console.WriteLine("The value of 'a' in the Main is {0}.", a);

            //pass a single argument to a method
            SingleArgPassed(a);

            //passing parameter and returnig a value back to main
            string res = ReturnParamMethod(a);
            Console.WriteLine("the value of 'res' is : {0} ", res);


            Console.ReadLine();
        }

        private static void ShowOnScreen()
        {
            Console.WriteLine("\n\n You have entered the ShowOnScreen Method");

        }

        private static void MethodOwnA()
        {
            int a = 320;
            Console.WriteLine("\nThe value os 'a' in MethodOwnA is {0}. ", a);
        }

        private static void SingleArgPassed(int num)
        {
            Console.WriteLine("The value passed from main to SingleArgPassed in {0}. ", num);
            num *= 12;
            Console.WriteLine("The value of 'a' in SingleArgsPassed is {0}. ", num);
        }

        private static string ReturnParamMethod(int num)
        {
            if (num == 12)
             return "found"; 
            else
             return "not found";
        }
    }
}
