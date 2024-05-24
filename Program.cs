using System;

public class Program
{

    public static void Main(String[] args)
    {
        double unitFactor = 2.54;
        Console.WriteLine("enter inches");
        var inches = Convert.ToDouble(Console.ReadLine());
        double centimeters = inches * unitFactor;
        Console.WriteLine($"{inches} inches is {centimeters} centimeters");
    }
}
