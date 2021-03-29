using System;
using System.Linq;

namespace StringFormat
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] inputs = new string[] { "3", "1/1", "1 3/4" };  // replace array by list to expand for an unknown number of strings to be splitted

			foreach (string input in inputs)
			{
				string[] splittedValue = input.Split('/', ' ');

				/*Expected result 03-00/00 */
				if (splittedValue.Count() == 1)
				{
					String test = splittedValue[0].PadLeft(2, '0') + "-00/00";
					Console.WriteLine(test);
				}

				/*Expected result 00-01/01*/
				if (splittedValue.Count() == 2)
				{
					String format = "00-00";
					String test = Convert.ToInt32(splittedValue[0]).ToString(format) + "/" + splittedValue[1].PadLeft(2, '0');
					Console.WriteLine(test);
				}


				/*Expected result 01-03/04*/
				if (splittedValue.Count() == 3)
				{

					String test = splittedValue[0].PadLeft(2, '0') + "-" + splittedValue[1].PadLeft(2, '0') + "/" + splittedValue[2].PadLeft(2, '0');
					Console.WriteLine(test);
				}
			}
		}
	}
}
