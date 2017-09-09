using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var people = new List<Person>();
        AddPeople(people);
        AddFood(people);
        PrintPurchasedFood(people);
    }

    private static void PrintPurchasedFood(List<Person> people)
    {
        Console.WriteLine(people.Sum(p=>p.Food));
    }

    private static void AddFood(List<Person> people)
    {
        var input = Console.ReadLine();
        while (true)
        {
            if (input == "End") break;
            if (people.Select(p => p.Name).Contains(input))
            {
                people.First(p => p.Name == input).BuyFood();
            }

            input = Console.ReadLine();
        }
    }

    private static void AddPeople(List<Person> people)
    {
        var numberOfPeople = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfPeople; i++)
        {
            var personInfo = Console.ReadLine().Split();
            if (personInfo.Length > 3)
            {
                var name = personInfo[0];
                var age = personInfo[1];
                var id = personInfo[2];
                var birthDate = personInfo[3];
                var citizen = new Citizen(id, name, age, birthDate);
                people.Add(citizen);
            }

            else
            {
                var name = personInfo[0];
                var age = personInfo[1];
                var group = personInfo[2];
                var rebel = new Rebel(name, age, group);
                people.Add(rebel);
            }
        }
    }
}
