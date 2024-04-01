using System;

class Three
{
    static void Main()
    {
        Console.Write("Enter the number of seconds: ");
        int seconds = int.Parse(Console.ReadLine());

        int minutes = seconds / 60;
        int hours = minutes / 60;
        int days = hours / 24;
        int months = days / 30;

        Console.WriteLine("Minutes: " + minutes);
        Console.WriteLine("Hours: " + hours);
        Console.WriteLine("Days: " + days);
        Console.WriteLine("Months: " + months);
    }
}
