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
            string path = Directory.GetCurrentDirectory();
            
            return File.ReadAllLines(path+"\\"+fileName).ToList();
        }
    }
}
