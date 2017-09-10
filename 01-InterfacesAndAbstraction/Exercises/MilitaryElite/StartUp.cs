using System;
using System.Collections.Generic;
using System.Linq;

public class StarUp
{
    public static void Main()
    {
        var soldiers = new List<ISoldier>();
        AddSoldiers(soldiers);
        PrintSoldiers(soldiers);
    }

    private static void PrintSoldiers(List<ISoldier> soldiers)
    {
        foreach (var soldier in soldiers)
        {
            Console.WriteLine(soldier);
        }
    }

    private static void AddSoldiers(List<ISoldier> soldiers)
    {
        var input = Console.ReadLine();
        while (input != "End")
        {
            var soldierArgs = input.Split().ToList();
            var type = soldierArgs[0];
            soldierArgs.RemoveAt(0);

            switch (type)
            {
                case "Private":
                    var id = soldierArgs[0];
                    var firstName = soldierArgs[1];
                    var lastName = soldierArgs[2];
                    var salary = double.Parse(soldierArgs[3]);
                    var privateSoldier = new Private(id, firstName, lastName, salary);
                    soldiers.Add(privateSoldier);
                    break;
                case "LeutenantGeneral":
                    id = soldierArgs[0];
                    firstName = soldierArgs[1];
                    lastName = soldierArgs[2];
                    salary = double.Parse(soldierArgs[3]);

                    var leutenantGeneral = new LeutenantGeneral(id, firstName, lastName, salary);
                    for (int i = 4; i < soldierArgs.Count; i++)
                    {
                        var privateId = soldierArgs[i];
                        var currPrivate = soldiers.First(s => s.Id == privateId);
                        leutenantGeneral.AddPrivate(currPrivate);
                    }

                    soldiers.Add(leutenantGeneral);
                    break;
                case "Engineer":
                    id = soldierArgs[0];
                    firstName = soldierArgs[1];
                    lastName = soldierArgs[2];
                    salary = double.Parse(soldierArgs[3]);
                    var corps = soldierArgs[4];

                    var engineer = new Engineer(id, firstName, lastName, salary, corps);
                    for (int i = 5; i < soldierArgs.Count; i += 2)
                    {
                        var repairPart = soldierArgs[i];
                        var repairHours = int.Parse(soldierArgs[i + 1]);
                        engineer.AddRepair(repairPart, repairHours);
                    }

                    if (engineer.Corps != "Invalid") soldiers.Add(engineer);
                    break;
                case "Commando":
                    id = soldierArgs[0];
                    firstName = soldierArgs[1];
                    lastName = soldierArgs[2];
                    salary = double.Parse(soldierArgs[3]);
                    corps = soldierArgs[4];
                    var commando = new Commando(id, firstName, lastName, salary, corps);

                    for (int i = 5; i < soldierArgs.Count; i += 2)
                    {
                        var codeName = soldierArgs[i];
                        var state = soldierArgs[i + 1];
                        commando.AddMission(codeName, state);
                    }

                    if (commando.Corps != "Invalid") soldiers.Add(commando);
                    break;
                case "Spy":
                    id = soldierArgs[0];
                    firstName = soldierArgs[1];
                    lastName = soldierArgs[2];
                    var codeNumber = int.Parse(soldierArgs[3]);
                    var spy = new Spy(id, firstName, lastName, codeNumber);
                    soldiers.Add(spy);
                    break;
            }

            input = Console.ReadLine();
        }
    }
}
