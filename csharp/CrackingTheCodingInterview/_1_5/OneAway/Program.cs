//
// Copyright (c) 2018 Ibrahim El Far. All Rights Reserved.
// Released under MIT License. See LICENSE file for details.
//

using System;

namespace OneAway
{
	class Program
	{
		static void Main(string[] args) {
			var inputs = new string[] {
		"a", "",
		"", "a",
		"a", "x",
		"abc", "xbc",
		"abc", "axc",
		"abc", "abx",
		"abc", "iabc",
		"abc", "aibc",
		"abc", "abic",
		"abc", "abci",
		"abc", "abici",
		"abc", "abxi",
		"abc", "ixbc",
		"abc", "aixc",
	  };

			for (int i = 0; i < inputs.Length; i += 2) {
				var a = inputs[i];
				var b = inputs[i + 1];
				var output = Solution.AreOneEditAway(a, b);

				Console.WriteLine($"{a,-16} | {b,-16} | {output,-16}");
			}
		}
	}
}
