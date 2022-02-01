using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	public class Boxes
	{
		public List<Tuple<int, string>> TupleList = new();

		public void AddElement(int hash, string description)
		{
			TupleList.Add(new Tuple<int, string>(hash, description));
		}

		public string GetValue(int hash)
		{
			foreach (var (key, value) in TupleList)
				if (hash.Equals(key))
					return value;
			return "shhes";
		}
	}
}