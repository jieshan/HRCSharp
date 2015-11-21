using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTimeInWords
{
    class TheTimeInWords
    {
        static Dictionary<int, string> timeString = new Dictionary<int, string>() 
            {
                {1, "one"},
                {2, "two"},
                {3, "three"},
                {4, "four"},
                {5, "five"},
                {6, "six"},
                {7, "seven"},
                {8, "eight"},
                {9, "nine"},
                {10, "ten"},
                {11, "eleven"},
                {12, "twelve"},
                {13, "thirteen"},
                {14, "fourteen"},
                {16, "sixteen"},
                {17, "seventeen"},
                {18, "eighteen"},
                {19, "ninteen"},
                {20, "twenty"}
            };

        static void Main(String[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            if (minute == 0)
            {
                Console.WriteLine(timeString[hour] + " o' clock");
            }
            else if (minute == 1)
            {
                Console.WriteLine("one minute past " + timeString[hour]);
            }
            else if (minute > 1 && minute < 30)
            {
                printTime(hour, minute, "past");
            }
            else if (minute == 30)
            {
                Console.WriteLine("half past " + timeString[hour]);
            }
            else if (minute > 30 && minute < 59)
            {
                printTime(hour + 1, 60 - minute, "to");
            }
            else
            {
                Console.WriteLine("one minute to " + timeString[hour + 1]);
            }
        }

        static void printTime(int hour, int minute, string prep)
        {
            if (minute == 15)
            {
                Console.WriteLine("quarter " + prep + " " + timeString[hour]);
            }
            else if (minute < 10)
            {
                Console.WriteLine(timeString[minute] + " minutes " + prep + " " + timeString[hour]);
            }
            else if (minute > 10 && minute < 20)
            {
                Console.WriteLine(timeString[minute] + " minutes " + prep + " " + timeString[hour]);
            }
            else
            {
                Console.WriteLine(timeString[minute - minute % 10] + " " + timeString[minute % 10] + " minutes " + prep + " " + timeString[hour]);
            }
        }
    }
}
