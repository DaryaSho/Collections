using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
  
    class DList
    {
      

       object[] arr;
       int n = 4;
       int pointer = 0;

       public object this[int i]
        {
            get
            {
                return arr[i];
            }
       }
       
        public DList(int n)
        {
            if (n.GetType() == this.n.GetType()) {
                this.n = n;
            } 
            arr = new object[n];
        }

        public DList()
        {
            arr = new object[4];
        }
       
        public int count
        {
            get
            {
                return pointer;
            }
        }

        public void Add (object t)
        {
            Check();
            arr[pointer] = t;
            pointer++;
        }

        public void Remove()
        {
            pointer--;
            arr[pointer] = null;
        }
        public void Remove(int ind)
        {
            int  j = 0;
            pointer--;
            var arr1 = arr;
            for ( int i = 0; i < pointer; i++)
            {
                if (ind == i-1) j++;
                arr[i] = arr[j];
                j++;
               
            }
        }
        private void Check()
        {

            if (pointer >= n)
            {
                n *= 2;
                Create();
            }     
        }

        private void Create()
        {
            var arr1 = arr;
            arr = new object[n];
            for (int i = 0; i < n/2; i++)
            {
                arr[i] = arr1[i];
            } 
        }

        public IEnumerator<object> GetEnumerator()
        {
                return new DlistEnumerator(arr);
        }
    }

}

