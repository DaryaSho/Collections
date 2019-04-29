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
            Console.WriteLine(dDictionary[1]);
            DDictionary<string, string> dDi = new DDictionary<string, string>();
            dDi.Add("1", "A");
            dDi.Add("2", "B");
            Console.WriteLine(dDi["1"]);
            foreach (var item in dDi)
            {
                Console.WriteLine(item);
            }
        }
    }
}
