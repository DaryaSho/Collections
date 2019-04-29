using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class DictionaryEnumerator<T,V>:IEnumerator
    {
        T[] Tkey;
        V[] TValue;
        int position = -1;
        int size;


        public DictionaryEnumerator(T[] Tkey,V[] TValue, int size)
        {
            this.Tkey = Tkey;
            this.TValue = TValue;
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

        public V Current
        {
            get
            {
                try
                {
                    return TValue[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
