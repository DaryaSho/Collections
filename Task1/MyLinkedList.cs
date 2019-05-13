using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MyLinkedList<T>
    {
        private Node first;
        private Node last;
        private int number;

        public MyLinkedList()
        {
            first = null;
            last = null;
            number = 0;
        }

        public void add(T item)
        {
            if (!isEmpty())
            {
                Node previous = last;
                last = new Node(item, null);
                previous.next = last;
            }
            else
            {
                last = new Node(item, null);
                first = last;
            }
            number++;
        }

        public bool remove(T item)
        {
            if (isEmpty()) return false;
            bool result = false;
            Node previous = first;
            Node current = first;
            while (current.next != null || current == last)
            {
                if (current.value.Equals(item))
                {
                    if (number == 1) { first = null; last = null; }
                    else if (current.Equals(first)) { first = first.next; }
                    else if (current.Equals(last)) { last = previous; last.next = null; }
                    else { previous.next = current.next; }
                    number--;
                    result = true;
                    break;
                }
                previous = current;
                current = previous.next;
            }
            return result;
        }

        public int count()
        {
            return number;
        }

        public bool isEmpty()
        {
            return number == 0;
        }

        private class Node
        {
            public T value;
            public Node next;

            public Node(T value, Node next)
            {
                this.value = value;
                this.next = next;
            }
        }

    }
}
