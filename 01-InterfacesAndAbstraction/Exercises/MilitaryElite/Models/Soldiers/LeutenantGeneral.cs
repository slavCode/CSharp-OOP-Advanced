using System;
using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral : Private, ILeutenantGeneral
{
    private List<ISoldier> privates;

    public LeutenantGeneral(string id, string firstName, string lastName, double salary)
        : base(id, firstName, lastName, salary)
    {
        this.privates = new List<ISoldier>();
    }

    public List<ISoldier> Privates
    {
        get => this.privates;
        set { this.privates = value; }
    }

    public void AddPrivate(ISoldier privateSoldier)
    {
        this.Privates.Add(privateSoldier);
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.AppendLine("Privates:");
        foreach (var pr in Privates)
        {
            builder.AppendLine(pr.ToString());
        }

        return base.ToString() + $"{Environment.NewLine}{builder.ToString().Trim()}";
    }
}
