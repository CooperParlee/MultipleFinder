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
            foreach (int i in MakeOmelette(10, 1, new int[] {2, 3, 5, 6}, new int[] {1}, 1))
            {
                Console.Out.WriteLine(i);
            }
            Console.Read();
        }

        public static List<int> MakeOmelette(int blockCount, int startBlock, int[] differentialMultiples, int[] multiples, int consistentDifferential)
        {
            Console.WriteLine("They say you can't make an omelette without a few Broken Eggs.");

            List<int> multiplesArray = new List<int>();
            Chunkinator.SetBlockSize(16384);
            Chunkinator.SetLockedEnabled(true);

            for (int i = 0; i <= blockCount; i++)
            {
                List<int> m_LocalPossibilities = MultipleScan.IntArrayToList(Chunkinator.GenerateBlock(i + startBlock));

                foreach (int item in MultipleScan.MultipleArrayOf(MultipleScan.MultipleArrayOfDifferential(m_LocalPossibilities, differentialMultiples, 1), multiples))
                {
                    multiplesArray.Add(item);
                }
            }
            return multiplesArray;
        }
    }
}
