using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        private Node head;
        private int size;

        public LinkedList()
        {
            this.head = null;
            this.size = 0;
        }

        public bool Empty
        {
            get {return this.size ==0;}
        }

        public int Count
        {
            get {return this.size;}
        }

        public int Add(int index, int o)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Indice: " + index);

            if(index > Count)
                index = Count;

            Node current = this.head;

            if(this.Empty || index == 0)
            {
                this.head = new Node(o, this.head);
            }
            else
            {
                for(int i= 0; i < index - 1; i++)
                {
                    current = current.Next;

                    current.Next = new Node(o, current.Next);
                }

                Count++;

                return o;
            }

           public int Add(int o)
           {
               return this.Add(Count, o);
           }
        }
    }
}