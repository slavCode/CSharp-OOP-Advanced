public class EntityFactory
{
    public IHabitable CreateEntity(string inputLine)
    {
        var entityArgs = inputLine.Split();
        if (entityArgs.Length > 2)
        {
            return new Citizen(entityArgs[0], entityArgs[1], entityArgs[2]);
        }

        return new Robot(entityArgs[0], entityArgs[1]);
    }
}
