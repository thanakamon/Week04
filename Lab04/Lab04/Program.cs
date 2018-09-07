using System;
public class MathTest
{
    static void Main(string[] args)
    {
        for (float i = 0; i < Math.PI * 2.0F; i += 0.3F)
        {
            Console.WriteLine("The i*i of {0,10:F} = {1,-10:F6}" +
            spaces(Math.Pow(i,2.0)) + "*", i, Math.Pow(i,2.0));
        }
    }
    private static string spaces(double val)
    {
        string SpaceString = new String(' ', ((int)(val * 10.0)) + 10);
        return SpaceString;
    }
}





