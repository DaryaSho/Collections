using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class DictionaryEnumerator<T, V> : IEnumerator
    {
        List<KeyValuePair<T, V>>[] keyValuePair;
        int position = 0;//0
        int index = -1;


        public DictionaryEnumerator(List<KeyValuePair<T, V>>[] keyValuePair)
        {
            this.keyValuePair = keyValuePair;
        }

        public bool MoveNext()
        {
            if (position >= keyValuePair.Length - 1) return false;
            if (keyValuePair[position] == null)
            {
                position++;
                return MoveNext();
            }
            index++;
            if (index > keyValuePair[position].Count - 1)
            {
                index = -1;
                position++;
                return MoveNext();
            }
            return true;
        }

        public void Reset()
        {
            position = 0;//0;
            index = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public KeyValuePair<T, V> Current
        {
            get
            {
                try
                {
                    return keyValuePair[position].ElementAt(index);
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

    }
}
