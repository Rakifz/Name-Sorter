using System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace KSTTestProject
{
	public class NameSorter
	{
		public void NameSort()
		{
			FileInputClass input = new FileInputClass();
			FileOutputClass output = new FileOutputClass();
			List<string> f = input.InputList("unsorted-names-list.txt");

			var alpabethSort = f.OrderBy(x => x);

			var LastNameSort = alpabethSort.OrderBy(x => x.Split(' ').Last()).ToList();

			output.WriteOutputFile(LastNameSort, "sorted-names-list.txt");
			
		}
	}
}
