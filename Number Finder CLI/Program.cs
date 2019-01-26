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
            foreach (int i in Chunkinator.GenerateBlock(2))
            {
                Console.Out.WriteLine(i);
            }
            Console.Read();
        }

        static void ListItems <T> (List<T> array) // A convenience function for listing all of the items in an array. 
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
