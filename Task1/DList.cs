using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
  
    class DList<T> : IEnumerable<T>
    {
      

       T[] arr;
       int size = 4; //capacity
       int pointer = 0;

       public T this[int i]
       {
            get
            {
                return arr[i];
            }
       }
       
        public DList(int size = 4)
        {
           
            this.size = size;
            arr = new T[size];
        }

       
        public int Count
        {
            get
            {
                return pointer;
            }
        }

        public void Add (T t)
        {
            CheckAndCreate();
            arr[pointer++] = t;
        }

        public void Remove()
        {
            arr[--pointer] = default(T);
        }

        public void Remove(int index)
        { 
            pointer--;
            for (int i = index; i < pointer; i++)
            {
                arr[i] = arr[i + 1];
            }
        }

        private void CheckAndCreate()
        {

            if (pointer >= size)
            {
                size *= 2;
                Recreate();
            }     
        }

        private void Recreate()
        {
            var arr1 = arr;
            arr = new T[size];
            for (int i = 0; i < size / 2; i++)
            {
                arr[i] = arr1[i];
            } 
        }
        public IEnumerator<T> GetEnumerator()
        {
            return arr.Take(Count).GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }

}

