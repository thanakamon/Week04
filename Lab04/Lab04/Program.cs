using System;
namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Namber: ");
            int p = int.Parse(Console.ReadLine());
            Random random = new Random();
            int randomNumber = random.Next(0, 9);
            Console.WriteLine(randomNumber);
           

            bool a = randomNumber == p;
            Console.WriteLine("{0}", a);


        }
    }
}



