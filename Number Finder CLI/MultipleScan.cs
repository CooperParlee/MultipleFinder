using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Finder_CLI
{
    class MultipleScan
    {
        public static List<int> MultipleOf(List<int> inArray, int multiple) // Returns all values that are multiples of "multiple" from inside of inArray.
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
        public static List<int> MultipleArrayOf(List<int> inArray, int[] multiples)
        {
            List<int> outArray = new List<int>(inArray);

            foreach (int multiple in multiples)
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

        public static List<int> DifferentialFromMultiple(List<int> inArray, int differential, int multiple) // Returns all values that are multiples of "multiple" from inArray, however, applies a differential to their values.
        {
            List<int> m_inArray = MultipleOf(inArray, multiple);
            List<int> outArray = new List<int>();

            foreach (int num in m_inArray)
            {
                outArray.Add(num + differential);
            }
            return outArray;
        }
        public static List<int> MultipleArrayOfDifferential(List<int> inArray, int[] multiples, int consistentOffset)
        {
            List<int> initArray = new List<int>(inArray);
            List<int> outArray = new List<int>();

            initArray = MultipleArrayOf(initArray, multiples);

            if (initArray.Count != 0)
            {
                foreach (int multiple in initArray)
                {
                    outArray.Add(multiple + consistentOffset);
                }
            }

            return outArray;
        }

        public static List<int> IntArrayToList(int[] array)
        {
            List<int> outList = new List<int>();
            foreach (int item in array)
            {
                outList.Add(item);
            }
            return outList;
        }
        static void ReadList<T>(List<T> list)
        {
            foreach(T item in list)
            {
                Console.WriteLine(item);
            }
            

        }

    }
}
