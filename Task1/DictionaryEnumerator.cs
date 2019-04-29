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
        KeyValuePair<T, V>[] keyValuePair;
        int position = -1;


        public DictionaryEnumerator(KeyValuePair<T,V>[] keyValuePair)
        {
            this.keyValuePair = keyValuePair;
        }

        public bool MoveNext()
        {
            position++;
            return (position < keyValuePair.Length-1);
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

        public KeyValuePair<T, V>  Current
        {
            get
            {
                try
                {
                    return keyValuePair[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

    }
}
