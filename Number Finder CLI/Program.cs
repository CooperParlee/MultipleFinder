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
            int startTime = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;

            List<int> range = GenerateAll(1, 6859000000);
            List<int> outs = MultipleArrayOfDifferential(range, new int[] {2, 3, 4, 5, 6}, 1);

            Console.WriteLine("There are {0} possibilities in the specified range. Applying next filter", outs.Count);
            List<int> outs2 = MultipleOf(outs, 7);

            Console.WriteLine("There are {0} possibilities in this range.", outs2.Count);
            int now = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
            Console.WriteLine("Finished. Took {0} seconds.", now - startTime);

            CSV_Write.SaveArrayAsCSV<int>(outs2, "All Values Between 1-2mil", "Ntest.csv");
            Console.Read();
        }

        static List<int> GenerateAll(int min, long max) // Generates every number between the range of min and max.
        {
            List<int> outArray = new List<int>();

            for (int i = min-1; i < max; i++)
            {
                outArray.Add(i + 1);
            }
            return outArray;
        }
        static List<int> MultipleOf (List<int> inArray, int multiple) // Returns all values that are multiples of "multiple" from inside of inArray.
        {
            List<int> outArray = new List<int>();

            foreach (int num in inArray)
            {
                Console.Out.WriteLine("Checking if {0}, is a multiple of {1}", num, multiple);
                double d = ((double)num / (double)multiple);
                if (d == (int)d)
                {
                    outArray.Add(num);
                }
                else
                {
                    Console.WriteLine("Removing number.");
                }
            }
            if (outArray.Count == 0)
            {
                Console.WriteLine("There are no multiples in this range.");
            }
            //Console.WriteLine("There are {0} multiples of {1} in the selected range.", outArray.Count, multiple);
            return outArray;
        }
        static List<int> MultipleArrayOf(List<int> inArray, int[] multiples)
        {
            List<int> outArray = new List<int>(inArray);

            foreach(int multiple in multiples)
            {
                int lastCount = outArray.Count;

                outArray = MultipleOf(outArray, multiple);
                Console.WriteLine("{0} possible multiples removed. {1} remain.", lastCount - outArray.Count, outArray.Count);
                if (outArray.Count <= 0)
                {
                    Console.WriteLine("There are no valid multiples of said number(s) within this range.");
                    break;
                }
            }
            return outArray;
        }
        static List<int> MultipleArrayOfDifferential(List<int> inArray, int[] multiples, int consistentOffset)
        {
            List<int> initArray = new List<int>(inArray);
            List<int> outArray = new List<int>();

            initArray = MultipleArrayOf(initArray, multiples);

            if(initArray.Count != 0)
            {
                foreach (int multiple in initArray)
                {
                    outArray.Add(multiple + consistentOffset);
                }
            }
            
            return outArray;
        }
        static List<int>DifferentialFromMultiple(List<int> inArray, int differential, int multiple) // Returns all values that are multiples of "multiple" from inArray, however, applies a differential to their values.
        {
            List<int> m_inArray = MultipleOf(inArray, multiple);
            List<int> outArray = new List<int>();
            
            foreach(int num in m_inArray)
            {
                outArray.Add(num + differential);
            }
            return outArray;
        }
        static void ListItems(List<int> array) // A convenience function for listing all of the items in an array. 
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
