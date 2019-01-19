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
            List<int> range = GenerateAll(20);
            List<int> outs = DifferentialFromMultiple(range, 1, 3);

            foreach(int item in outs)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }

        static List<int> GenerateAll(int size)
        {
            List<int> outArray = new List<int>();

            for (int i = 0; i < size; i++)
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
                    }

                }
            }
            Console.WriteLine("There are {0} multiples of {1} in the selected range.", outArray.Count, multiple);
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
    }
}
