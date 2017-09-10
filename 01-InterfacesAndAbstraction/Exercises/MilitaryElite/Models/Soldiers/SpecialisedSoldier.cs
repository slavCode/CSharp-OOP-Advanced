using System;

public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
{
    private string corps;

    protected SpecialisedSoldier(string id, string firstName, string lastName, double salary, string corps)
        : base(id, firstName, lastName, salary)
    {
        this.Corps = corps;
    }

    public string Corps
    {
        get => this.corps;
        set
        {
            if (value != "Airforces" && value != "Marines")
            {
                this.corps = "Invalid";
            }

            else this.corps = value;
        }
    }

    public override string ToString()
    {
        return base.ToString() + $"{Environment.NewLine}Corps: {this.Corps}";
    }
}
