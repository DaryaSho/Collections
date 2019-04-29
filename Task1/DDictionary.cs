using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class DDictionary<T,V>  : IEnumerable
    {
        KeyValuePair<T,V>[] keyValues;
        int size = 64;
        int pointer = 0;

        public void Add(T Key, V Val)
        {
            CheckAndCreate();
            keyValues[HachFunction(Key)] =new KeyValuePair<T, V>(Key,Val);
            pointer++;
        }

        public DDictionary(int size = 64)
        {
            this.size = size;
            keyValues = new KeyValuePair<T, V>[size];
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
                return keyValues[HachFunction(Key)].Value;
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
            var kV = keyValues;
            keyValues = new KeyValuePair<T, V>[size];
            for (int i = 0; i < size / 2; i++)
            {
                keyValues[i] = kV[i];
            }
        }


        public void Remove(T key)
        {
            pointer--;
            keyValues[HachFunction(key)] = new KeyValuePair<T, V>(default(T), default(V));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        public DictionaryEnumerator<T, V> GetEnumerator()
        {
            return new DictionaryEnumerator<T, V>(keyValues);
        }

        private int HachFunction(T key)
        {
            return Math.Abs((key.ToString()).GetHashCode() % size);
        }
    }
}
