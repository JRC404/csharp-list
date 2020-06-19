using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // arrays: static. Fixed in size.
            // lists: dynamic.
            // where to use lists?
            // if you don't know how many items your array is going to hold...
            // userSignup - can you predict how many are going to signup? Nope.
            // use a list.
            // LINQ - query

            List<int> salary = new List<int>();
            List<int> expenditure = new List<int>();
            int[] otherCosts = new int[] { 9, 12, 10 };
            int subscriptionForMonday = 10;
            salary.Add(7); // add an object to the end of the list... index 0
            salary.Add(18000); // index 1
            salary.Add(22000); // index 2
            salary.AddRange(otherCosts); // adding otherCosts to the dynamic list salary
            expenditure.AddRange(salary);
            salary.ForEach(i => Console.Write("{0}\t", i));
            salary.RemoveAt(1);
            salary.Remove(22000);
            Console.WriteLine(expenditure.Count);
            Console.WriteLine(expenditure.Capacity);

            Console.ReadKey();

            //Console.WriteLine("Hello World!");
        }
    }
}
