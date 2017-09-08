using System;

public class StartUp
{
    public static void Main()
    {
        var smartPhone = new Smartphone();
        smartPhone.AddNumbers(Console.ReadLine());
        smartPhone.AddSites(Console.ReadLine());
        Console.WriteLine(smartPhone.ToString());
    }
}
