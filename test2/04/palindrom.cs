using System;

namespace Poly
{
    class Poly
    {
        static void Main(string [] args)
        {
            string input = Console.ReadLine();
            int i = 0;
            for( ;i < input.Length; i++)
            {
                Console.WriteLine(input.Length);
                if ((input.Length - i > 0) && input[i] != input[input.Length - i])
                {
                //     // if ((input.Length - i -1 > 0 ) && (input[i] == input[input.Length - i -1]))
                //     //     break;

                }
            }
           // Console.WriteLine("answer: {0}", i);
        }
    }
}