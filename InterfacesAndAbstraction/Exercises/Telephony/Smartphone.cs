using System;
using System.Collections.Generic;
using System.Linq;

public class Smartphone : ICallable, IBrowsable
{
    public Smartphone()
    {
        this.Numbers = new List<string>();
        this.Sites = new List<string>();
    }

    public List<string> Numbers { get; }
    public List<string> Sites { get; }

    public void AddNumbers(string inputNumbers)
    {
        foreach (var number in inputNumbers.Split().ToList())
        {
            if (!number.Any(char.IsDigit)) this.Numbers.Add("Invalid number!");
            else this.Numbers.Add($"Calling... {number}");
        }
    }

    public void AddSites(string sites)
    {
        foreach (var site in sites.Split().ToList())
        {
            if (site.Any(char.IsDigit)) this.Sites.Add("Invalid URL!");
            else Sites.Add($"Browsing: {site}!");
        }
    }

    public string Call()
    {
        return $"{string.Join($"{Environment.NewLine}", this.Numbers)}";
    }

    public string Browse()
    {
        return $"{string.Join($"{Environment.NewLine}", this.Sites)}";
    }

    public override string ToString() 
    {
        return Call() + $"{Environment.NewLine}" + Browse();
    }
}
