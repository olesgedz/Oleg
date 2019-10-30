using System;

namespace TimeZones
{
    class TimeZones
    {
        static void Main(string [] args)
        {
            int time;
            int a;
            int b;
            Int32.TryParse(Console.ReadLine(), out time);
            Int32.TryParse(Console.ReadLine(), out a);
            Int32.TryParse(Console.ReadLine(), out b);
            time = time - Math.Abs(a-b);
            if (time < 0)
                time = 24 + time;
            if (time > 24)
                time = 0 + (time - 24);
            Console.WriteLine("Time: {0}", time);
        }
    }
}