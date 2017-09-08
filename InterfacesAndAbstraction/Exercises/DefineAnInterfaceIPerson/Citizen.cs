public class Citizen : IPerson
{
    public string Name { get; }
    public int Age { get; }

    public Citizen(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
}
