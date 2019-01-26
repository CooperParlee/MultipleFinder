using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Finder_CLI
{
    class Chunkinator
    {
        private static int blocksize = 1024;

        public static List<int> GenerateAll(int min, long max) // Generates every number between the range of min and max.
        {
            List<int> outArray = new List<int>();

            for (int i = min - 1; i < max; i++)
            {
                outArray.Add(i + 1);
            }
            return outArray;
        }

        public static int[] GenerateBlock (int blockID)
        {
            int[] returnArray = new int[blocksize];

            for(int i = 1; i <= blocksize; i++)
            {
                int startNum = (blockID - 1) * blocksize;
                returnArray[i - 1] = startNum + i;
            }
            return returnArray;
        }
    }
}
