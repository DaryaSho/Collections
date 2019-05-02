using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class DictionaryEnumerator <T, V> : IEnumerator 
    {
        List<KeyValuePair<T, V>>[] dDictionary;
        int position = -1;//0
        int index = 0;
        int i = 0;


        public DictionaryEnumerator(List<KeyValuePair<T, V>>[] dDictionary)
        {
            this.dDictionary = dDictionary;
        }

        public bool MoveNext()
        {
            position++;
            if (position >= dDictionary.Length - 1) return false;
            if (dDictionary[position] == null)
                return MoveNext();
            //if (index >= dDictionary[position].Count - 1) {
            //    index = 0;
            //    position++;
            //    return MoveNext();
            //}
            //else index++;
            return true;
        }

        public void Reset()
        {
            position = -1;//0
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public KeyValuePair<T,V> Current
        {
            get
            {
                try
                {
                    return  dDictionary[position].ElementAt(index);
                }
                catch(IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

    }
}
