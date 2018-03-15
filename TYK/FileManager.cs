using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TYK
{
    class FileManager
    {
        public void ResultsWrite()
        {
            string answ;
            answ = Console.ReadLine();
            string results = answ + Environment.NewLine;
            File.WriteAllText(@"D:\NAU\2\SA\results.txt", results);
        }

        public void TestReader()
        {
            // test parser to place
            // consider reading from .txt
        }
    }
}
