using System;
using System.Collections.Generic;
namespace AddelementsInList
{
    class program
    {
        static void Main(string[] args)
        {

            List<int> intList = new List<int>() { 10, 20, 30,40,60,70 };
            intList.Remove(30);
            intList.RemoveAt(1);
            foreach (int i in intList)
            {
                Console.WriteLine(i);
            }

        }
    }
}