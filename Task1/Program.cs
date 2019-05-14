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
            DLink();

           // CreateDictionary();
          //  CrateDList();
        }
        static void CrateDList()
        {
            DList<int> dList = new DList<int>(3);
            dList.Add(0);
            dList.Add(1);
            dList.Add(2);
            dList.Add(3);
            dList.Add(4);
            dList.Remove(3);
            Console.WriteLine(dList[1]);
            foreach (var item in dList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("______________");
            Console.WriteLine(dList.Count);
        }
        static void CreateDictionary()
        {
            DDictionary<int, string> dd = new DDictionary<int, string>(10);
            dd.Add(0, "q");
            dd.Add(1, "w");
            dd.Add(2, "e");
            dd.Add(3, "r");
            dd.Add(11, "1");
            foreach (var item in dd)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(dd[3]);
            dd.Remove(3);
            Console.WriteLine(dd[3]);
        }
        static void DLink()
        {
            DLinkedList<int> dLinked = new DLinkedList<int>();
            dLinked.AddFirst(3);
            dLinked.AddLast(10);
            dLinked.AddFirst(2);
            dLinked.AddFirst(1);
            dLinked.AddAfter(1, 200);
            dLinked.AddBefore(dLinked.Last, 100);
           // dLinked.Remove(2);
           // dLinked.Show();
            foreach (var item in dLinked)
            {
                Console.WriteLine(item);
            }

        }
    }
}
