using System.Collections.Generic;
using System.Linq;

public class Box<T>
{
    private List<T> data;

    public Box()
    {
        this.data = new List<T>();
    }

    public void Add(T element)
    {
        data.Add(element);
    }

    public int Count => this.data.Count;

    public T Remove()
    {
        var remove = this.data.Last();
        this.data.RemoveAt(this.data.Count -1);
        return remove;
    } 
}
