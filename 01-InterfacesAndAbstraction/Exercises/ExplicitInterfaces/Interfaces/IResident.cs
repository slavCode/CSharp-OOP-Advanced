public interface IResident : IHuman
{
    string Country { get; }
    new string GetName();
}
