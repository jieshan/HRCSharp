using System;
using System.Collections.Generic;
using System.IO;

namespace IntroToTutorialChallenges
{
    class IntroToTutorialChallenges
    {
        static void Main(String[] args)
        {
            int value = int.Parse(Console.ReadLine());
            int lower = 0;
            int upper = int.Parse(Console.ReadLine());
            string[] values = Console.ReadLine().Split(' ');
            int pointer = (lower + upper) / 2;
            while (lower < upper) 
            {
                if (int.Parse(values[pointer]) < value)
                {
                    lower = pointer;
                }
                else if (int.Parse(values[pointer]) > value)
                {
                    upper = pointer;
                }
                else 
                {
                    Console.WriteLine(pointer);
                    return;
                }
                pointer = (lower + upper) / 2;
            }
            Console.WriteLine(pointer);
        }
    }
}
