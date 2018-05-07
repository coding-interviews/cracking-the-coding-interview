using System;

namespace StringCompression
{
  class Program
  {
    static void Main(string[] args)
    {
			var inputs = new string[] {
        null,
        "",
        "a",
        "ab",
        "abc",
        "aab",
        "abb",
        "aabb",
        "aaaaaaaaaab",
        "abbbbbbbbbb",
        "abbbbbcbbbb"
			};

			foreach (var input in inputs) {
				var output = Solution.Compress(input);
				Console.WriteLine($"{input,-16} | {output,-16}");
			}
    }
  }
}
