public class Pet : IHabitable
{
    public Pet(string id, string birthdate)
    {
        this.Id = id;
        this.Birthdate = birthdate;
    }

    public string Id { get; }
    public string Birthdate { get; }
}
