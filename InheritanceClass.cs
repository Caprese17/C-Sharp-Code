using System;
using System.Collections.Generic;
using System.Text;

namespace inheritencepracticeanimal
{
    class Animal
    {
        public string name;
        public string type;

        public void display()
        {
            Console.WriteLine("I am a dog!");
        }
    }

    class Dog : Animal
    {
        public void getName()
        {
            Console.WriteLine("My name is {0} and I am a {1}.", name , type) ;
        }
    }

}
