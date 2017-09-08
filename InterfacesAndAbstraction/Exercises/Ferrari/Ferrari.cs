using System.Text;

public class Ferrari : ICar
{
    public Ferrari(string driverName)
    {
        this.DriverName = driverName;
        this.Model = "488-Spider";
    }

    public string DriverName { get; }
    public string Model { get; }

    public string UseBreaks() => "Brakes!";

    public string UseGasPedal() => "Zadu6avam sA!";

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.AppendLine($"{this.Model}/{UseBreaks()}/{UseGasPedal()}/{this.DriverName}");
        return builder.ToString().Trim();
    }
}
