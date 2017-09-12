internal class Citizen : IResident, IPerson
{
    private string name;
    private string country;
    private string age;

    public Citizen(string name, string country, string age)
    {
        this.Name = name;
        this.Country = country;
        this.Age = age;
    }

    public string Name { get; }

    public string Country { get; }

    public string Age { get; }

    string IResident.GetName() => "Mr/Ms/Mrs " + this.Name;

    string IHuman.GetName() => this.Name;

}