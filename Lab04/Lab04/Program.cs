using System;
namespace variableProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double me = 57910000 , v = 108200000, e = 149600000, ma = 227940000, j = 778330000, u = 2873550000;
            double l = 17960279.04 ,n = 4501000000 , p = 5945900000  ;
            double mer ,m = 1.609344 ,s= 186000, merc ;
            Console.WriteLine("93,000,000 miles = 1 A.U. ");
            Console.WriteLine("Light speed 186,000 Mile Per second");
            double sl = s * 60;
            Console.WriteLine("Light speed {0} Mile Per mintue",sl);
            mer = me / m;
            merc = mer / sl;
            Console.WriteLine("sun to mercury distance = {0} and sun to mercury time of light = {1} ",mer,merc);
            double ve = v / m;
            double ven = ve / sl;
            Console.WriteLine("sun to venus distance = {0} and sun to venus time of light = {1} ", ve, ven);
            double ea = e / m;
            double ear = ea / sl;
            Console.WriteLine("sun to earth distance = {0} and sun to earth time of light = {1} ", ea, ear);
            double mar = ma / m;
            double mars = mar / sl;
            Console.WriteLine("sun to mars distance = {0} and sun to mars time of light = {1} ", ea, ear);
            double ju = j / m;
            double jup = ju / sl;
            Console.WriteLine("sun to jupiter distance = {0} and sun to pupiter time of light = {1} ", ju, jup);
            double ur = u / m;
            double ura = ur / sl;
            Console.WriteLine("sun to uranus distance = {0} and sun to uranus time of light = {1} ", ur, ura);
            double ne = n / m;
            double nep = ne / sl;
            Console.WriteLine("sun to neptune distance = {0} and sun to earth time of light = {1} ", ne, nep);
            double pl = p / m;
            double plu = pl / sl;
            Console.WriteLine("sun to pluto distance = {0} and sun to pluto time of light = {1} ", pl, plu);


            Console.ReadKey();
        }
    }
}




