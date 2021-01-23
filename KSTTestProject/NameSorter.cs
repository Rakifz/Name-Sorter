using System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace KSTTestProject
{
	public class NameSorter
	{
		public void NameSort(string inputFile)
		{
			//initiate file reader and writer classes
			FileInputClass input = new FileInputClass();
			FileOutputClass output = new FileOutputClass();

			//getting the name lists from file unsorted-names-list.txt
			List<string>list = input.InputList(inputFile);

			// sort alphabetically first, as the first name needs to be sorted
			var alphabetSort = list.OrderBy(x => x);

			// sort last name alphabetically after the first names sorted 
			var LastNameSort = alphabetSort.OrderBy(x => x.Split(' ').Last()).ToList();

			//writting the name lists to file sorted-names-list.txt
			output.WriteOutputFile(LastNameSort, "sorted-names-list.txt");
			
		}
	}
}
