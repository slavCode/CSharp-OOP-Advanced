public class Citizen:IHabitable
{

    public Citizen(string name, string age, string id)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
    }

    public string Name { get; }
    public string Age { get; }
    public string Id { get; }
}
