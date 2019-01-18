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
            foreach (var item in MultipleOf(GenerateAll(12), 2))
            {
                Console.WriteLine(item.ToString());
            }

            Console.Read();
        }

        static int [] GenerateAll(int size)
        {
            int[] outArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                outArray[i] = i + 1;
            }
            return outArray;
        }
        static List<int> MultipleOf (int[] inArray, int multiple)
        {
            List<int> outArray = new List<int>();

            foreach (int num in inArray)
            {
                double d = ((double)num / (double)multiple);
                if (d == (int)d)
                {
                    Console.WriteLine("Yes! {0} is a multiple of {1}!", num, multiple);
                    if (outArray != null)
                    {
                        outArray.Add(num);
                    }

                }
            }
            
            return outArray;
        }
    }
}
