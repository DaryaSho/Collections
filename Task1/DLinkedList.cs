using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class DLinkedList<T>: IEnumerable
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

        public void AddLast(T value)
        {
            if (!isEmpty())
            {
                Node<T> previous = last;
                last = new Node<T>(value, null);
                previous.next = last;
            }
            else
            {
                last = new Node<T>(value, null);
                first = last;
            }
            number++;
        }
        public void AddAfter(T value, T element)
        {
            Node<T> current = first;
            Node<T> newElement = new Node<T>(element, null);
            while (current.next != null || current == last)
            {
                if (current.value.Equals(value))
                {
                    if (current.Equals(last)) { AddLast(element); }
                    else {
                        Node<T> previous = current.next;
                        current.next = newElement;
                        newElement.next = previous;
                    }
                    number++; 
                    break;
                }
                current = current.next;
            }
        }

        public void AddBefore(T value, T element)
        {
            Node<T> current = first;
            Node<T> previous = current;
            Node<T> newElement = new Node<T>(element, null);
            while (current.next != null || current == last)
            {
                if (current.value.Equals(value))
                {
                    if (current.Equals(first)) { AddFirst(element); }
                    else
                    {
                        newElement.next=current;
                        previous.next=newElement;
                    }
                    number++;
                    break;
                }
                previous = current;
                current = previous.next;
            }
        }


        public void AddFirst(T value)
        {
            if (!isEmpty())
            {
                Node<T> previous = first;
                first = new Node<T>(value, null);
                first.next = previous;
            }
            else
            {
                first = new Node<T>(value, null);
                last = first;
            }
            number++;
        }

        public void Show()
        {
            Node<T> current = first;
            while (current != null)
            {              
                Console.WriteLine(current.value);
                current = current.next;
            };
        }

        public void Remove(T value)
        {
            if (!isEmpty())
            {
                Node<T> previous = first;
                Node<T> current = first;
                while (current.next != null || current == last)
                {
                    if (current.value.Equals(value))
                    {
                        if (number == 1) { first = null; last = null; }
                        else if (current.Equals(first)) { first = first.next; }
                        else if (current.Equals(last)) { last = previous; last.next = null; }
                        else { previous.next = current.next; }
                        number--;
                        break;
                    }
                    previous = current;
                    current = previous.next;
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
            return new DLinkedEnumerator<T>(first , last);
        }

    }
    public class Node<T>
    {
        public T value;
        public Node<T> next;

        public Node(T value, Node<T> next)
        {
            this.value = value;
            this.next = next;
        }
    }
}
