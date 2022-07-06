using System;

namespace inheritencepracticeanimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog Lab = new Dog();
            Lab.name = "Don";
            Lab.type = "Lab";

            Lab.display();
            Lab.getName();

            Console.ReadLine();
        }
    }
}
