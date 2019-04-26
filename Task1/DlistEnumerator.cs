using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class DlistEnumerator: IEnumerator<object>
        {
            object[] arr;
            int position = -1;

            public DlistEnumerator(object[] arr)
            {
            this.arr = arr;
            }

            public object Current
            {
                get
                {
                    if (position == -1 || position >= arr.Length)
                        throw new InvalidOperationException();
                    return arr[position];
                }
            }
        object IEnumerator.Current => throw new NotImplementedException();

           public bool MoveNext()
            {
                if (position < arr.Length - 1)
                {
                    position++;
                    return true;
                }
                else
                    return false;
            }

            public void Reset()
            {
                position = -1;
            }
        public void Dispose() { }
    }
}

