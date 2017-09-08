using System.Collections.Generic;

public interface IBrowsable
{
    List<string> Sites { get; }

    string Browse();

    void AddSites(string sites);
}
