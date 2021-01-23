using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace KSTTestProject
{
    public class FileOutputClass
    {
        public void WriteOutputFile(List<string> sortedArray,string outputFile)
        {
            var docPath = Directory.GetCurrentDirectory();
            using (StreamWriter writer = new StreamWriter(Path.Combine(docPath, outputFile)))
            {
                foreach (string line in sortedArray)
                {
                    writer.WriteLine(line);
                }
            }
            foreach (var i in sortedArray)
            {
                Console.WriteLine(i);
            }

        }
    }
}
