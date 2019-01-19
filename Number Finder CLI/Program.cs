using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Finder_CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> range = GenerateAll(1, 20);
            List<int> outs = MultipleOf(range, 100);

            ListItems(outs);
            Console.Read();
        }

        static List<int> GenerateAll(int min, int max)
        {
            List<int> outArray = new List<int>();

            for (int i = min-1; i < max; i++)
            {
                outArray.Add(i + 1);
            }
            return outArray;
        }
        static List<int> MultipleOf (List<int> inArray, int multiple)
        {
            List<int> outArray = new List<int>();

            foreach (int num in inArray)
            {
                double d = ((double)num / (double)multiple);
                if (d == (int)d)
                {
                    if (outArray != null)
                    {
                        outArray.Add(num);
                        break;
                    }
                }
            }
            if (outArray.Count == 0)
            {
                Console.WriteLine("There are no multiples in this range.");
            }
            //Console.WriteLine("There are {0} multiples of {1} in the selected range.", outArray.Count, multiple);
            return outArray;
        }
        static List<int>DifferentialFromMultiple(List<int> inArray, int differential, int multiple)
        {
            List<int> m_inArray = MultipleOf(inArray, multiple);
            List<int> outArray = new List<int>();
            
            foreach(int num in m_inArray)
            {
                outArray.Add(num + differential);
            }
            return outArray;
        }
        static void ListItems(List<int> array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
