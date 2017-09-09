using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        List<IBirthdatable> entities = new List<IBirthdatable>();
        AddEntity(entities);

        var yearToMatch = Console.ReadLine();
        PrintMatchedEntities(entities, yearToMatch);
    }

    private static void PrintMatchedEntities(List<IBirthdatable> entities, string yearToMatch)
    {
        foreach (var entity in entities.Where(e => e.Birthdate.EndsWith(yearToMatch)))
        {
            Console.WriteLine(entity.Birthdate);
        }
    }

    private static void AddEntity(List<IBirthdatable> entities)
    {
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var entityArgs = input.Split().ToList();
            var type = entityArgs[0];
            entityArgs.RemoveAt(0);
            switch (type)
            {
                case "Citizen":
                    entities.Add(new Citizen(entityArgs[0], entityArgs[1], entityArgs[2], entityArgs[3]));
                    break;
                case "Pet":
                    entities.Add(new Pet(entityArgs[0], entityArgs[1]));
                    break;
            }
        }
    }
}
