public class Tesla : Car, IElectricCar
{
    private int batteries;
    public Tesla(string model, string color, int batteries) : base(model, color)
    {
        this.Batteries = batteries;
    }

    public int Batteries
    {
        get => this.batteries;
        private set { this.batteries = value; }
    }

    protected override string GetCarInfo()
    {
        return base.GetCarInfo() + $" with {this.Batteries} Batteries";
    }
}
