using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueNames
{
    class Program
    {

        public static string[] uniqueNames(string[] names1,string[] names2)
        {

          
            // first Solution 
            HashSet<string> res = new HashSet<string>(names1);
            res.Union(names2);
            return res.ToArray<string>();



            //After searching online 
            return  names1.Union(names2).ToArray();
            



        }
        static void Main(string[] args)
        {
            string[] names1 = new string[] { "Ava", "Emma", "Olivia"};
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            Console.WriteLine(string.Join(",", uniqueNames(names1, names2)));


        }
    }
}
