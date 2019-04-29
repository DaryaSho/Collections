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

            DList<int> dList = new DList<int>(5);
            dList.Add(1);
            dList.Add(2);
            dList.Add(3);
            dList.Add(4);
            dList.Add(5);
            dList.Remove();
            for (int i = 0; i < dList.Count; i++)
            {
                Console.WriteLine(dList[i]);
            }
            Console.WriteLine("_________________");
            dList.Add(4);
            foreach (var item in dList)
            {
                Console.WriteLine(item);
            }
            dList.Add(4);
            DList<string> dListStr = new DList<string>(5);
            dListStr.Add("1");
            dListStr.Add("2");
            dListStr.Add("3");
            dListStr.Add("4");
            dListStr.Add("5");
            dListStr.Remove(2);
            foreach (var item in dListStr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
