public class Rebel : Person
{
    public Rebel(string name, string age, string group)
        : base(name, age)
    {
        this.Group = group;
    }

    public string Group { get; }

    public override void BuyFood()
    {
        this.Food += 5;
    }
}
