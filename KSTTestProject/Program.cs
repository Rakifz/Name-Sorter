using System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace KSTTestProject
{

    public class Program
	{
		public static void Main()
		{
			NameSorter sorter = new NameSorter();
			sorter.NameSort("unsorted-names-list.txt");
		}
	}
}
