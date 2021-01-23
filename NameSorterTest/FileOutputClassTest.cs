using KSTTestProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NameSorterTest
{
    [TestClass]
    public class FileOutputClassTest
    {
        [TestMethod]
        public void WriteOutput_WriteSuccess_ReturnTrue()
        {
            FileOutputClass output = new FileOutputClass();
            List<string> list = new List<string>() { "test","case1"};
            output.WriteOutputFile(list,"text1.txt");
            var path = Directory.GetCurrentDirectory();
            List<string> result =File.ReadAllLines(path + "\\" + "text1.txt").ToList();

            CollectionAssert.AreEqual(result, list);
        }

    }
}
