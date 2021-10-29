using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Stack<T>
    {
        Node<T> sHead;
        private int _counter;



        public Stack()
        {
            this.sHead = null;
            this._counter = 0;
        }



        public bool IsEmpty()
        {
            return _counter == 0;
        }



        public int Size()
        {
            return this._counter;
        }



        public void Push(T item)
        {
            Node<T> _item = new Node<T>(item);
            _item.Next = sHead;
            this.sHead = _item;
            _counter++;
        }



        public T Pop()
        {
            if (_counter == 0)
            {
                throw new Exception("No item Present");
            }
            else
            {
                Node<T> _item = this.sHead;
                this.sHead = this.sHead.Next;
                this._counter--;
                return _item.GetData;



            }
        }



        public T Peek()
        {
            return this.sHead.GetData;
        }



        public void Display()
        {
            Node<T> temp = this.sHead;



            while (temp != null)
            {
                Console.WriteLine($"{temp.GetData}");
                temp = temp.Next;
            }

        }
    }
}
