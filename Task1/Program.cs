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
  
            DList dList = new DList();
            dList.Add(1);
            dList.Add(2);
            dList.Add(3);
            dList.Add(4);
            dList.Add(5);
            dList.Add(6);
            Console.WriteLine(dList[2]);
            Console.WriteLine(  dList.count);
            Console.WriteLine("_________________");
            dList.Remove(2);
            Console.WriteLine(dList[2]);
            Console.WriteLine(dList.count);
             Console.WriteLine("_________________");
            foreach (var item in dList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("_________________");
            for (int i = 0; i < dList.count; i++)
            {
                Console.WriteLine(dList[i]);
            }
            Console.WriteLine("_________________");
            dList.Add(4);
            foreach (var item in dList)
            {
                Console.WriteLine(item);
            }
            


        }
    }
}
