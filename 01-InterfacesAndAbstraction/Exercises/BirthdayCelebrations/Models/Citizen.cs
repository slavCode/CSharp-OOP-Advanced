public class Citizen : IHabitable, IBirthdatable
{
    
    public Citizen(string name, string age, string id, string birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthdate;
    }

    public string Birthdate { get; }
    public string Name { get; }
    public string Age { get; }
    public string Id { get; }
}
