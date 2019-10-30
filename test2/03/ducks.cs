using System;

namespace Ducks
{
    class Ducks
    {
        static void Main(string [] args)
        {
            int answer;
            int a;
            int b;
            Int32.TryParse(Console.ReadLine(), out a);
            Int32.TryParse(Console.ReadLine(), out b);
            answer = 0;
            for(; ; answer++)
            {
                if(answer % a == 1)
                {
                    if (answer % b == 2)
                        break;
                }
            }
            Console.WriteLine("Answer: {0}", answer);
        }
    }
}