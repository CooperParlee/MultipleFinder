using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Number_Finder_CLI
{
    class CSV_Write
    {
        public static void SaveArrayAsCSV <T> (List<T> tea, string header, string fileName)
        {
            using (StreamWriter file = new StreamWriter(fileName))
            {
                file.Write(header + Environment.NewLine);
                foreach (T item in tea)
                {
                    file.Write(item + Environment.NewLine);
                }
            }
        }
    }
}
