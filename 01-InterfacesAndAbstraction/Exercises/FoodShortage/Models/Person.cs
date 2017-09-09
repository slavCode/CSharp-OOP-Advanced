public abstract class Person : IBuyer
{
    private string name;
    private string age;
    private int food;

    protected Person(string name, string age)
    {
        this.Name = name;
        this.Age = age;
        this.Food = 0;
    }

    public string Name
    {
        get => this.name;
        private set { this.name = value; }
    }

    public string Age
    {
        get => this.age;
        private set { this.age = value; }
    }

    public int Food
    {
        get => this.food;
        set { this.food = value; }
    }

    public virtual void BuyFood()
    {
        this.Food += 10;
    }
}
