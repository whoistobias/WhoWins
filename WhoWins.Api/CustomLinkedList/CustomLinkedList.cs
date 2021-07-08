using System;

namespace WhoWins.Api.CustomLinkedList
{
    public class CustomLinkedList<T> : ICustomLinkedList<T>
    {
        internal Node<T> Head;
        public CustomLinkedList(params T[] args)
        {
            foreach (T data in args)
            {
                Add(data);
            }
        }

        public int Length
        {
            get
            {

                if (Head == null) return 0;

                int count = 1;
                var currentNode = Head;

                while (currentNode.Next != null)
                {
                    count++;
                    currentNode = currentNode.Next;
                }
                return count;
            }
        }

        public void Add(params T[] args)
        {
            foreach (T data in args)
            {
                var newNode = new Node<T>(data);
                if (Head == null)
                {
                    Head = newNode;
                }
                else
                {
                    var currentNode = Head;
                    while (currentNode.Next != null)
                    {
                        currentNode = currentNode.Next;
                    }
                    currentNode.Next = newNode;
                }
            }

        }

        public bool Contains(T data)
        {
            if (Head != null)
            {
                Node<T> currentNode = Head;
                do
                {
                    if (currentNode.Data.Equals(data)) return true;
                    currentNode = currentNode.Next;
                } while (currentNode.Next != null);
            }
            return false;
        }

        public T Get(int index)
        {
            if (index >= Length || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            var currentNode = Head;
            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.Next;
            }
            return currentNode.Data;
        }
    }
}