using System.Collections.Generic;

public interface ICallable
{
    List<string> Numbers { get;}
    string Call();
    void AddNumbers(string inputNumbers);
}
