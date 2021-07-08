public interface ICustomLinkedList<T>
{
    void Add(params T[] data);
    int Length { get; }
    bool Contains(T data);
    T Get(int index);
}