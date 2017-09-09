using System.Linq;

public class EntityFactory
{
    public IBirthdatable CreateEntity(string inputLine)
    {
        var entityArgs = inputLine.Split().ToList();
        var type = entityArgs[0];
        entityArgs.RemoveAt(0);
        switch (type)
        {
            case "Citizen":
                return new Citizen(entityArgs[0], entityArgs[1], entityArgs[2], entityArgs[3]);
            case "Pet":
                return new Pet(entityArgs[0], entityArgs[1]);
        }

        return null;
    }
}
