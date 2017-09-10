using System;
using System.Collections.Generic;
using System.Text;

public class Engineer : SpecialisedSoldier
{
    private List<Repair> repaires;

    public Engineer(string id, string firstName, string lastName, double salary, string corps) : base(id, firstName, lastName, salary, corps)
    {
        this.repaires = new List<Repair>();
    }

    public void AddRepair(string repairPart, int repairHours)
    {
        this.repaires.Add(new Repair(repairPart, repairHours));
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.AppendLine("Repairs:");
        foreach (var repair in repaires)
        {
            builder.AppendLine($"{repair}");
        }

        return base.ToString() + $"{Environment.NewLine}{builder.ToString().Trim()}";
    }
}
