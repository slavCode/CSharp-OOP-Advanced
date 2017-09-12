public class MyList : AddRemoveCollection
{
    private int used;

    public MyList()
    {
        this.Used = used;
    }

    public int Used { get; }

    public override int Add(string item)
    {
        this.used++;
        this.collection.Insert(0, item);
        return 0;
    }

    public override string Remove()
    {
        this.used--;
        var result = this.collection[0];
        this.collection.RemoveAt(0);
        return result;
    }
}
