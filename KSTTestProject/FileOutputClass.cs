using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace KSTTestProject
{
    public class FileOutputClass
    {
        public void WriteOutputFile(List<string> sortedList,string outputFile)
        {
            //getting the .exe filepath, the reult would be written there
            var docPath = Directory.GetCurrentDirectory();

            //write the sorted list into file
            using (StreamWriter writer = new StreamWriter(Path.Combine(docPath, outputFile)))
            {
                foreach (string line in sortedList)
                {
                    writer.WriteLine(line);
                }
            }

            // write the sorted list on the console screen
            foreach (var i in sortedList)
            {
                Console.WriteLine(i);
            }

        }
    }
}
