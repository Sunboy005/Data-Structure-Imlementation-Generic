using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    public class Node<T>
    {
        private T _data;

        private Node<T> _next;

        public Node(T data)
        {
            _data = data;
            _next = null;
        }

        public T GetData
        {
            get { return _data; }
            set { _data = value; }
        }

        public Node<T> Next
        {

            get { return _next; }
            set { _next = value; }
        }

    }
}
