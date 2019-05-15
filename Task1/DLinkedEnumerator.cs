using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class DLinkedEnumerator<T> : IEnumerator
    {
        Node<T> first;
        bool number = true;
        Node<T> current;


        public DLinkedEnumerator(Node<T> first)
        {
            this.first = current = first;
        }

        public bool MoveNext()
        {
            if (number)
            {
                number = false;
                return true;
            }
            current = current.next;
            return current != null;
        }

        public void Reset()
        {
            current = first;
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
                    return current.value;
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
