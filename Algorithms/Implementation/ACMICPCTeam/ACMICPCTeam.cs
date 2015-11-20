using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMICPCTeam
{
    class ACMICPCTeam
    {
        static void Main(String[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int numPeople = int.Parse(input[0]);
            int numSubjects = int.Parse(input[1]);
            string[] people = new string[numPeople];
            for (int i = 0; i < numPeople; i++)
            {
                people[i] = Console.ReadLine();
            }
            int maxSubjects = 0;
            int count = 0;
            for (int i = 0; i < numPeople - 1; i++)
            {
                for (int j = i + 1; j < numPeople; j++)
                {
                    int subjects = CountOr(people[i], people[j]);
                    if (subjects > maxSubjects)
                    {
                        maxSubjects = subjects;
                        count = 1;
                    }
                    else if (subjects == maxSubjects)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(maxSubjects);
            Console.WriteLine(count);
        }

        static int CountOr(string a, string b)
        {
            int count = 0;
            for (int i = 0; i < Math.Min(a.Length, b.Length); i++)
            {
                count += (a[i] - '0') | (b[i] - '0');
            }
            return count;
        }
    }
}
