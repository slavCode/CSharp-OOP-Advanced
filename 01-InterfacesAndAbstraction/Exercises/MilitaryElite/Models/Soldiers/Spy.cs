using System;

public class Spy : Soldier
{
    private int codeNumber;

    public Spy(string id, string firstName, string lastName, int codeNumber)
    : base(id, firstName, lastName)
    {
        this.CodeNumber = codeNumber;
    }

    public int CodeNumber
    {
        get => this.codeNumber;
        set { this.codeNumber = value; }
    }

    public override string ToString()
    {
        return base.ToString() + $"{Environment.NewLine}Code Number: {this.CodeNumber}";
    }
}
