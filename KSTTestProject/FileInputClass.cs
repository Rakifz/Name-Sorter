using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace KSTTestProject
{
    public class FileInputClass
    {
        public List<string> InputList(string fileName)
        {
            //getting the input file (the file is  used for test, so it placed in the same folder as the solution)
            string path = Directory.GetCurrentDirectory()+ "\\..\\..\\..\\..\\";
            
            //return the list from input file
            return File.ReadAllLines(path+"\\"+fileName).ToList();
        }
    }
}
