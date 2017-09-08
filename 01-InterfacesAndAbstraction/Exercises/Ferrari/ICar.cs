public interface ICar
{
    string DriverName { get; }
    string Model { get; }
    string UseBreaks();
    string UseGasPedal();
}
