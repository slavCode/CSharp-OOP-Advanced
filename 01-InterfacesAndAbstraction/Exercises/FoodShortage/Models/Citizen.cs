public class Citizen : Person, IBirthdatable, IBuyer, IHabitable
{
    private string id;
    public Citizen(string id, string name, string age, string birthdate) : base(name, age)
    {
        this.Birthdate = birthdate;
        this.Id = id;
    }

    public string Id { get; }

    public string Birthdate { get; }

}
