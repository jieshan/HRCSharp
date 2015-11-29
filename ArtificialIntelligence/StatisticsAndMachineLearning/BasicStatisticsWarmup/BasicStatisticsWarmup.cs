using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStatisticsWarmup
{
    class BasicStatisticsWarmup
    {
        static void Main(String[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] array = new int[num];
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < input.Length; i++)
            {
                array[i] = int.Parse(input[i]);
            }
            getAverage(array);
            getMedian(array);
            getMode(array);
            getStdDev(array);
            getConfIntv(array);
        }

        static void getAverage(int[] array) 
        {
            int sum = array.Sum();
            double average = sum * 1.0 / array.Length;
            Console.WriteLine(String.Format("{0:0.0}", average));
        }

        static void getMedian(int[] array)
        {
            int[] ys = (int[])array.Clone();
            Array.Sort(ys);
            double med;
            if (array.Length % 2 == 0)
            {
                med = (ys[array.Length / 2 - 1] + ys[array.Length / 2]) / 2.0;
            }
            else
            {
                med = ys[(array.Length - 1)/ 2];
            }
            Console.WriteLine(String.Format("{0:0.0}", med));
        }

        static void getMode(int[] array)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach( int a in array ) {
                if (counts.ContainsKey(a))
                    counts[a] = counts[a] + 1;
                else
                    counts[a] = 1;
            }
            int result = int.MinValue;
            int max = int.MinValue;
            foreach (int key in counts.Keys) {
                if (counts[key] > max) {
                    max = counts[key];
                    result = key;
                }
                else if (counts[key] == max && key < result)
                {
                    result = key;
                }
            }
            Console.WriteLine(result);
        }

        static void getStdDev(int[] array)
        {
            double average = array.Average();
            double sumOfSquaresOfDifferences = array.Select(val => (val - average) * (val - average)).Sum();
            double sd = Math.Sqrt(sumOfSquaresOfDifferences / array.Length);
            Console.WriteLine(String.Format("{0:0.0}", sd));
        }

        static void getConfIntv(int[] array)
        {
            double m = array.Average();
	        double[] sd_i = new double[array.Length];
	        for (int i = 0; i < array.Length; i++)
            {
		        sd_i[i] = Math.Pow((array[i] - m), 2);
            }
            double sd = Math.Sqrt(sd_i.Sum() / array.Length);
	        double sigma_m = sd / Math.Sqrt(array.Length);
	        double upper = m + 1.96 * sigma_m;
	        double lower = m - 1.96 * sigma_m;
            Console.WriteLine(String.Format("{0:0.0}", lower) + " " + String.Format("{0:0.0}", upper));
        }
    }
}
