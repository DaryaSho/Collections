using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
  
    class DDictionary<T,V> : IEnumerable
    {
        List<KeyValuePair<T, V>>[] dDictionary;
        int size = 10;
        int pointer = 0;

        public DDictionary(int size = 10)
        {
            this.size = size;
            dDictionary = new List<KeyValuePair<T, V>>[size];
        }

        public int Count
        {
            get
            {
                return pointer;
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
            var kV = dDictionary;
            dDictionary = new List<KeyValuePair<T, V>>[size];
            for (int i = 0; i < size / 2; i++)
            {
                dDictionary[i] = kV[i];
            }
        }

        private int HashFunction(T key)
        {
            return Math.Abs((key.ToString()).GetHashCode() % size);
        }

        public V this[T Key]
        {
            get
            {
                return dDictionary[HashFunction(Key)].Find(x => x.Key.Equals(Key)).Value;
            }
        }

        public void Add(T Key, V Val)
        {
            CheckAndCreate();
            int index = HashFunction(Key);
            if (dDictionary[index]==null) dDictionary[index] = new List<KeyValuePair<T, V>>();
            if (CheckByKey(Key)) Remove(Key);
            dDictionary[index].Add(new KeyValuePair<T, V>(Key, Val));
            pointer++;
        }

        public void Remove (T Key)
        {
            int index = HashFunction(Key);
            KeyValuePair<T, V> kv = dDictionary[index].Find(x => x.Key.Equals(Key));
            if (dDictionary[index] != null) dDictionary[index].Remove(kv);
        }

        private bool CheckByKey(T Key)
        {
            int index = HashFunction(Key);
            int i = dDictionary[index]==null? -1: dDictionary[index].FindIndex(x => x.Key.Equals(Key));
            return i!=-1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        public DictionaryEnumerator<T,V> GetEnumerator()
        {
            return new DictionaryEnumerator<T,V>(dDictionary);
        }

    }
}