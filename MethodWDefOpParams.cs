using System;

namespace MethodWDefOpParams
{
    class Program
    {
        static void Main(string[] args)
        {
            detail("xyz", 123);
            detail("ABC", 456, "B-");
            detail("DEF", 789, "B+", "Software Developer");
            Console.ReadLine();
        }

        private static void detail(string ename, int eid, string bgrp = "A+", string dept = "review team")
        {
            Console.WriteLine("Employee name: {0}", ename);
            Console.WriteLine("Employee ID: {0}", eid);
            Console.WriteLine("Employee Blood group: {0}", bgrp);
            Console.WriteLine("Employee Blood Department: {0}", dept);
            Console.WriteLine(-----------------);

        }
    }

}
