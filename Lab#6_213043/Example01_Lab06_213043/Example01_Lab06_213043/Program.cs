using Example01_Lab06_213043;
using System;
using System.Collections.Generic;
namespace AddelementsInList
{
    class program
    {
        //private static bool isPositiveInt;
        static void Main(string[] args)
        {
           
            List<Student> students = new List<Student>();
            students.Add(new Student());
            students.Add(new Student());
            students.Add(new Student());
            List<int> ints = new List<int>() ;
            ints.Add(11);
            ints.Add(22);
            ints.Add(33);
            ints.Add(44);
            ints.Add(55);
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
            
            List<string> mystring = new List<string>();
            mystring.Add("Rimsha");
            mystring.Add("Ali");
            

        }

    }

}