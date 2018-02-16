using System;

class Program
{
    static void Main()
    {
        DateTime value = new DateTime(2018, 2, 15);
        Console.WriteLine(value);
        Console.WriteLine(value == DateTime.Today);
    }
}
