using KSTTestProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NameSorterTest
{
    [TestClass]
    public class NameSorterTest
    {
        [TestMethod]
        public void NameSort_GetSorted_WrittenFileSortedFromList()
        {
            List<string> sortedList = new List<string> {
                "Avie Annakin",
                "Hailey Annakin",
                "Erna Dorey Battelle",
                "Selle Bellison",
                "Flori Chaunce Franzel",
                "Orson Milka Iddins",
                "Odetta Sue Kaspar",
                "Roy Ketti Kopfen",
                "Madel Bordie Mapplebeck",
                "Debra Micheli",
                "Leonerd Adda Micheli Monaghan",
                "Leonerd Adda Mitchell Monaghan"
            };
            NameSorter sorter = new NameSorter();
            sorter.NameSort("unsorted-names-list-Test.txt");

            var path = Directory.GetCurrentDirectory();
            List<string> result = File.ReadAllLines(path + "\\" + "sorted-names-list.txt").ToList();

            CollectionAssert.AreEqual(result, sortedList);




        }
    }
}
