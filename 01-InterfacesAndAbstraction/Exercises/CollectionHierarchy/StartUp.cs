using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class StartUp
{
    public static void Main()
    {
        var input = Console.ReadLine().Split().ToList();
        var numberOfRemoves = int.Parse(Console.ReadLine());

        var addCollection = new AddCollection();
        var addRemoveCollection = new AddRemoveCollection();
        var myList = new MyList();
        var sBuilder = new StringBuilder();

        AddElementsToCollection(sBuilder, addCollection, input);
        AddElementsToCollection(sBuilder, addRemoveCollection, input);
        AddElementsToCollection(sBuilder, myList, input);

        RemoveElementsFromCollection(sBuilder, addRemoveCollection, numberOfRemoves);
        RemoveElementsFromCollection(sBuilder, myList, numberOfRemoves);

        PrintResult(sBuilder);
    }

    private static void PrintResult(StringBuilder sBuilder)
    {
        Console.WriteLine(sBuilder.ToString().Trim());
    }

    private static void RemoveElementsFromCollection(StringBuilder sBuilder, IRemovable collection, int numberOfRemoves)
    {
        for (int i = 0; i < numberOfRemoves; i++)
        {
            sBuilder.Append(collection.Remove());
            sBuilder.Append(" ");
        }

        sBuilder.AppendLine();
    }

    private static void AddElementsToCollection(StringBuilder sBuilder, IAddable collection, List<string> input)
    {
        foreach (var element in input)
        {
            sBuilder.Append(collection.Add(element));
            sBuilder.Append(" ");
        }

        sBuilder.AppendLine();
    }
}
