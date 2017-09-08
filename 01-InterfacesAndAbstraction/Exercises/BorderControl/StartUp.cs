using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    private static string input;

    public static void Main()
    {
        List<IHabitable> entities = new List<IHabitable>();
        while ((input = Console.ReadLine()) != "End")
        {
            var entity = new EntityFactory().CreateEntity(input);
            entities.Add(entity);
        }

        var fakeId = Console.ReadLine();
        foreach (var entity in entities.Where(e => e.Id.EndsWith(fakeId)))
        {
            Console.WriteLine(entity.Id);
        }
    }
}
