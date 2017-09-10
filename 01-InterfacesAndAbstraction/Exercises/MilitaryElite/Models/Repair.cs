public class Repair
{
    private string partName;
    private int hoursWorked;

    public Repair(string partName, int hoursWorked)
    {
        this.PartName = partName;
        this.HoursWorked = hoursWorked;
    }

    public string PartName
    {
        get => this.partName;
        set { this.partName = value; }
    }

    public int HoursWorked
    {
        get => this.hoursWorked;
        set { this.hoursWorked = value; }
    }

    public override string ToString()
    {
        return $"Part Name: {this.PartName} Hours Worked: {this.HoursWorked}";
    }
}
