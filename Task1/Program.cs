using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            DDictionary<int, string> dDictionary = new DDictionary<int, string>();
            dDictionary.Add(1, "A");
            dDictionary.Add(2, "B");
            dDictionary.Add(122, "dfg");
            Console.WriteLine(dDictionary[1]);
            DDictionary<string, string> dDi = new DDictionary<string, string>(5);
            dDi.Add("1", "A");
            dDi.Add("2", "B");
            dDi.Add("3", "C");
            dDi.Add("4", "D");
            Console.WriteLine("_________");
            foreach (var item in dDi)
            {
                Console.WriteLine(item);
            }
            



        }
       
    }
}
