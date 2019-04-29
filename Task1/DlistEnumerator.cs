using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class DlistEnumerator<T>: IEnumerator
    {
        T[] arr;
        int position = -1;
        int size;
           

        public DlistEnumerator(T[] arr, int size)
        {
            this.arr = arr;
            this.size = size;
        }

        public bool MoveNext()
        {
            position++;
            return (position < size);
        }
            
        public void Reset()
        {
         position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public T Current
        {
            get
            {
                try
                {
                    return arr[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
            
    }
}

