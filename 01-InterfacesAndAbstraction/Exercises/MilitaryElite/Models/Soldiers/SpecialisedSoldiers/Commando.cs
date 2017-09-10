using System;
using System.Collections.Generic;
using System.Text;

public class Commando : SpecialisedSoldier
{
    private List<Mission> missions;
    public Commando(string id, string firstName, string lastName, double salary, string corps)
        : base(id, firstName, lastName, salary, corps)
    {
        this.missions = new List<Mission>();
    }

    public List<Mission> Missions
    {
        get => this.missions;
        private set { this.missions = value; }
    }

    public void AddMission(string codeName, string state)
    {
        var mission = new Mission(codeName, state);
        if (mission.State != "Invalid")
        {
            this.Missions.Add(mission);
        }
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.AppendLine("Missions:");
        foreach (var mission in missions)
        {
            builder.AppendLine($"{mission}");
        }

        return base.ToString() + $"{Environment.NewLine}{builder.ToString().Trim()}";
    }
}
