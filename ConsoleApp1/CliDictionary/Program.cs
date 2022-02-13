﻿using System;
using DictionaryCore;

namespace CliDictionary
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var path = @"dictionary.txt";
			var datafile = new FileReader().ReadLines(path);
			var dictionary = new StringsDictionary(10);
			dictionary.Fill(datafile,dictionary);

			while (true)
			{
				var n = Console.ReadLine();
				var def = dictionary.Get(n.ToUpper());
				Console.WriteLine(def);
			}
		}
	}
}