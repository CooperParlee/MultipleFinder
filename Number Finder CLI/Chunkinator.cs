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
        private static bool blocklock = false;

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
            int[] m_returnArray = new int[blocksize];

            for(int i = 1; i <= blocksize; i++)
            {
                int startNum = (blockID - 1) * blocksize;
                m_returnArray[i - 1] = startNum + i;
            }
            return m_returnArray;
        }

        public static int SetBlockSize(int m_blocksize)
        {
            if (!blocklock)
            {
                blocksize = m_blocksize;
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public static void SetLockedEnabled(bool m_dolock)
        {
            blocklock = m_dolock;
        }

        public static int GetBlockSize()
        {
            return blocksize;
        }
        public static bool IsLocked()
        {
            return blocklock;
        }
    }
}
