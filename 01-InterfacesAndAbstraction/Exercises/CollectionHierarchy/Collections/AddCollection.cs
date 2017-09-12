using System.Collections.Generic;

public class AddCollection : IAddable
{
    protected List<string> collection;

    public AddCollection()
    {
        this.collection = new List<string>();
    }

    public virtual int Add(string item)
    {
        this.collection.Add(item);
        return collection.LastIndexOf(item);
    }
}
