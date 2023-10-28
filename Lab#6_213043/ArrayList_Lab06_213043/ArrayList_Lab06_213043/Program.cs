using ArrayList_Lab06_213043;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AddelementsInList
{
    class program
    {
       // private static bool isPositiveInt;
        static void Main(string[] args)
        {
            Student student1 = new Student()
            {
                Name = "Rimsha ALi",
                Id = 213043,
            };
            Student student2 = new Student()
            {
                Name = "zahra",
                Id = 213001
            };
            Student student3 = new Student()
            {
                Name = "khansa",
                Id = 213064
            };
            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            foreach (Student i in students)
            {
                Console.WriteLine("Name : {0} ID: {1}", i.Name, i.Id);
            }

            List<int> ints = new List<int>();
            ints.Add(11);
            ints.Add(22);
            ints.Add(33);
            ints.Add(44);
            ints.Add(55);
            ints.Sort();
            Console.WriteLine("Sort()- - - - - - - - - - - - - - - -");

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Reverse()- - - - - - - - - - - - - - - -");
            ints.Reverse();
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Contains()- - - - - - - - - - - - - - - -");
            Console.WriteLine(ints.Contains(11));
            Console.WriteLine("Insert---------------------------");
            ints.Insert(1, 18);
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("AddRage( )- - - - - - - - - - - - - - - -");
            ints.AddRange(ints);
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("InsertRange-------------------------");
            ints.InsertRange(2, ints);
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Remove- - - - - - - - - - - - -");
            ints.Remove(22);
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("RemoveAt- - - - - - - - - - - - - - - - ");
            ints.RemoveAt(5);
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("RemoveRange- - - - - - - - - - - - - - - - - -");
            ints.RemoveRange(2, 2);
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
            //List<string> mystring = new List<string>();
            //mystring.Add("Rimsha");
            //mystring.Add("Ali");
            /*foreach (string i in mystring)
            {
                Console.WriteLine(i);
            }*/
        }
    }
}