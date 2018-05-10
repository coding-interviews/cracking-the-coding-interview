using System;
using Utilities;

namespace PalindromePermutation
{
	/// <summary>
	/// Write a function that determines whether a string is a permutation of a palindrome.
	/// </summary>
	class Program
	{
		static void Main(string[] args) {
			var inputs = new string[] {
		null,
		"",
		"a",
		"ab",
		"aba",
		"baa",
		"aab",
		"abba",
		"bbaa",
		"abab",
		"aabbcd"
	  };

			foreach (var input in inputs) {
				var output = Solution.IsAPermutationOfAPalindrome(input);

				Console.WriteLine($"{Display.String(input),-16} {output,-16}");
			}
		}
	}
}
