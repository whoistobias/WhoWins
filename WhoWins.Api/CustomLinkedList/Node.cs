namespace WhoWins.Api.CustomLinkedList
{
    public class Node<T>
    {
        public T Data;
        public Node<T> Next;
        public Node(T value)
        {
            Data = value;
            Next = null;
        }
    }
}