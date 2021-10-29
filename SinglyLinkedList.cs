using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class SinglyLinkedList<T>
    {
        private Node<T> llHead;
        private int size;

        public SinglyLinkedList()
        {
            this.size = 0;
            this.llHead = null;
        }

        public int Add(T value)
        {
            Node<T> data = new Node<T>(value);
            if (this.size == 0)
            {
                this.llHead = data;

            }
            else
            {
                Node<T> CurrentNode = this.llHead;
                for (int i = 0; i < this.size; i++)
                {
                    if (CurrentNode.Next == null)
                    {
                        CurrentNode.Next = data;
                    }
                    else
                    {
                        CurrentNode = CurrentNode.Next;
                    }
                }
            }

            this.size++;
            return this.size;
        }


        //remove the first occurence and return true


        public bool Check(T item)
        {
            Node<T> _item = this.llHead;
            for (int i = 0; i < this.size; i++)
            {
                if (_item.GetData.Equals(item))
                {
                    return true;
                }
                else
                {
                    _item = _item.Next;
                }
            }
            return false;
        }




        //Remove first occurence and return true
        public bool Delete(T item)
        {
            Node<T> _item = new Node<T>(item);
            if (this.llHead.GetData.ToString() == _item.GetData.ToString())
            {
                this.llHead = this.llHead.Next;
                this.size--;
                return true;
            }
            else
            {
                if (Check(item))
                {


                    Node<T> presentNode = this.llHead;
                    for (int i = 0; i < this.size; i++)
                    {
                        if (presentNode.Next.GetData.ToString() == _item.GetData.ToString())
                        {
                            presentNode.Next = presentNode.Next.Next;
                            this.size--;
                            return true;
                        }
                        else
                        {
                            presentNode = presentNode.Next;
                        }
                    }
                }


                else
                {
                    return false;
                }

                return false;
            }







        } //index
        public int Index(T item)
        {
            Node<T> node = this.llHead;
            if (node.GetData.ToString() == item.ToString())
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < this.size; i++)
                {
                    if (node.GetData.Equals(item))
                    {
                        return i;
                    }
                    node = node.Next;
                }
            }
            return -1;
        }



        //print function

        public void Display()
        {
            Node<T> counter = this.llHead;
            while (counter != null)
            {
                Console.WriteLine(counter.GetData);
                counter = counter.Next;

            }
        }


    }
}
