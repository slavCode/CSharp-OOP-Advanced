using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        var collection = new List<IHuman>();
        AddHumans(collection);
        PrintNames(collection);
    }

    private static void PrintNames(List<IHuman> collection)
    {
        foreach (var human in collection)
        {
            Console.WriteLine($"{human.GetName()}");
            var resident = (IResident) human;
            Console.WriteLine($"{resident.GetName()}");
        }
    }

    private static void AddHumans(List<IHuman> collection)
    {
        string input;
        while (true)
        {
            input = Console.ReadLine();
            if (input == "End")break;

            var humanInfo = input.Split();
            var name = humanInfo[0];
            var country = humanInfo[1];
            var age = humanInfo[2];
            IResident citizenAsResident = new Citizen(name, country, age);
            collection.Add(citizenAsResident);
        }
    }
}
