using System;
public class intergerTest
{
    static void Main(string[] args)
    {
        double y, b,x,a;
        Console.WriteLine("x:");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("y:");
        y = double.Parse(Console.ReadLine());
        Console.WriteLine("a:");
        a = double.Parse(Console.ReadLine());
        b = 100 * x + y % 2 - a;
        Console.WriteLine("100*x+y%2-a = {0}", b);
        Console.ReadKey();
    }
}




