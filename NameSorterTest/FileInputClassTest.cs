using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using KSTTestProject;

namespace NameSorterTest
{
    [TestClass]
    public class FileInputClassTest
    {
        [TestMethod]       
        public void InputList_FileFound_ReturnList()
        {
            FileInputClass input = new FileInputClass();
            var result = input.InputList("unsorted-names-list.txt");
            Assert.IsInstanceOfType(result, typeof(List<string>));
        }
        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void InputList_FileNotFound_ExceptionThrown()
        {
            FileInputClass input = new FileInputClass();
            var result = input.InputList("unknown.txt");
        }
    }
}
