using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Queue<T>
    {
        Node<T> qHead;
        Node<T> qTail;
        private int counter;



        public Queue()
        {
            this.qHead = null;
            this.qTail = null;
            this.counter = 0;
        }



        public bool IsEmpty()
        {
            return this.counter == 0;
        }



        public int Size()
        {
            return this.counter;
        }



        public void Enqueue(T item)
        {
            Node<T> _item = new Node<T>(item);
            if (counter == 0)
            {
                this.qHead = _item;
                this.qTail = _item;
            }
            else
            {
                Node<T> qHeadNode = this.qHead;
                Node<T> qTailNode = this.qTail;
                for (int i = 0; i < this.counter; i++)
                {
                    if (qTailNode.Next == null)
                    {





                        this.qTail = _item;
                    }
                    else
                    {
                        qTailNode = qTailNode.Next;
                    }
                }
            }

        }
    }
}
