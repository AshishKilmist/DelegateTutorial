using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesTutorial
{
    class Program
    {
        public delegate bool FunctionForString(string s);


        public static string[] PerformOperationOnStringArray(string[] myStrings, FunctionForString myFunction)
        {
            System.Collections.ArrayList myList = new System.Collections.ArrayList();
            foreach(string s in myStrings)
            {
                if (myFunction(s))
                {
                    myList.Add(s);
                }
            }
            return (string[])myList.ToArray(typeof(string));
        }


        public static bool StartsWithA(string s)
        {
            return s.StartsWith("A");
        }

        public static bool EndsWithN(string s)
        {
            return s.EndsWith("n");
        }

        static void Main(string[] args)
        {
            string[] myStrings = { "Adam", "Alan", "Bob", "Steve", "Jim", "Aiden" };
            string[] stringsA = PerformOperationOnStringArray(myStrings, StartsWithA);

            string[] stringsN = PerformOperationOnStringArray(myStrings, EndsWithN);

            foreach(string s in stringsN)
            {
                Console.WriteLine("Names that Start With the Letter A: " + s);
            }

            foreach (string s in stringsA)
            {
                Console.WriteLine("Names that end with the letter N: " + s);
            }
            Console.ReadLine();
        }
    }
}
