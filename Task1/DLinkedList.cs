using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class DLinkedList<T> : IEnumerable
    {
        private Node<T> first;
        private Node<T> last;
        private int number;

        public DLinkedList()
        {
            first = null;
            last = null;
            number = 0;
        }

        public T First
        {
            get
            {
                return first.value;
            }
        }

        public T Last
        {
            get
            {
                return last.value;
            }
        }

        public int Count
        {
            get
            {
                return number;
            }
        }

        private Node<T> Find(T value)
        {
            Node<T> current = first;
            while (current != null)
            {
                if (current.value.Equals(value))
                {
                    return current;
                }
                current = current.next;
            }
            return null;
        }

        public void AddLast(T value)
        {
            if (!isEmpty())
            {
                Node<T> previous = last;
                last = new Node<T>(value, previous, null);
                previous.next = last;
            }
            else
            {
                last = new Node<T>(value, null, null);
                first = last;
            }
            number++;
        }

        public void AddFirst(T value)
        {
            if (!isEmpty())
            {
                Node<T> previous = first;
                first = new Node<T>(value, null, previous);
                previous.prev = first;
            }
            else
            {
                first = new Node<T>(value, null, null);
                last = first;
            }
            number++;
        }

        public void AddAfter(T value, T element)
        {
            Node<T> current = Find(value);
            if (current == null)
            {
                return;
            }
            number++;
            if (current.next == null)
            {
                AddLast(element);
            }
            else
            {
                Node<T> next = current.next;
                current.next = new Node<T>(element, current, next);
                next.prev = current.next;
            }
        }

        public void AddBefore(T value, T element)
        {
            Node<T> current = Find(value);
            if (current == null)
            {
                return;
            }
            number++;
            if (current.prev == null)
            {
                AddFirst(element);
            }
            else
            {
                Node<T> previous = current.prev;
                previous.next = new Node<T>(element, previous, current);
                current.prev = previous.next;
            }
        }



        public void Display()
        {
            Node<T> current = first;
            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            };
        }

        public void ReverseDisplay()
        {
            Node<T> current = last;
            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.prev;
            };
        }

        public void Remove(T value)
        {
            if (!isEmpty())
            {
                Node<T> current = Find(value);
                if (current == null)
                {
                    return;
                }
                number--;
                if (current.next == null)
                {
                    last = current.prev;
                    last.next = null;
                }
                if (current.prev == null)
                {
                    first = current.next;
                    first.prev = null;
                }
                if ((current.next != null) && (current.prev != null))
                {
                    current.prev.next = current.next;
                    current.next.prev = current.prev;
                }
            }
        }

        private bool isEmpty()
        {
            return number == 0;
        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        public DLinkedEnumerator<T> GetEnumerator()
        {
            return new DLinkedEnumerator<T>(first);
        }

    }

    public class Node<T>
    {
        public T value;
        public Node<T> prev;
        public Node<T> next;

        public Node(T value, Node<T> prev, Node<T> next)
        {
            this.value = value;
            this.next = next;
            this.prev = prev;
        }
    }
}
