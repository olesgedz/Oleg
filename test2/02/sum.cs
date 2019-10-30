using System;

namespace Sum
{
    class Sum
    {
        static void Main(string [] args)
        {
            int a;
            int b;
            Int32.TryParse(Console.ReadLine(), out a);
            Int32.TryParse(Console.ReadLine(), out b);
            int odd = 0;
            int even = 0;
            
            for(int i = a; i <= b; i++)
            {
                if ((i % 2) == 0)
                    even+=i;
                else
                    odd+=i;
            }
            Console.WriteLine("Answer: {0}", even - odd);
        }
    }
}