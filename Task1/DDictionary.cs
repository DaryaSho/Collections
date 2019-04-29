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
        T[] TKey;
        V[] TValue;
        int size = 4; 
        int pointer = 0;

        public void Add(T Key, V Val)
        {
            CheckAndCreate();
            TKey[pointer] = Key;
            TValue[pointer] = Val;
            pointer++;
        }

        public DDictionary(int size = 4)
        {
            this.size = size;
            TKey = new T[size];
            TValue = new V[size];
        }

        public int Count
        {
            get
            {
                return pointer;
            }
        }

        public V this[T Key]
        {
            get
            {
                return TValue[Search(Key)];
            }
        }

        private int Search (T key)
        {
            return Array.IndexOf(TKey, key);
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
            var k = TKey;
            var v = TValue;
            TKey = new T[size];
            TValue = new V[size];
            for (int i = 0; i < size / 2; i++)
            {
                TKey[i] = k[i];
                TValue[i] = v[i];
            }
        }

        public void Remove()
        {
            pointer--;
            TKey[pointer] = default(T);
            TValue[pointer] = default(V);
        }

        public void Remove(int index)
        {
            pointer--;
            for (int i = index; i < pointer; i++)
            {
                TKey[pointer] = TKey[i + 1];
                TValue[pointer] = TValue[i + 1];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        public DictionaryEnumerator<T,V> GetEnumerator()
        {
            return new DictionaryEnumerator<T,V>(TKey, TValue, Count);
        }
    }
}
