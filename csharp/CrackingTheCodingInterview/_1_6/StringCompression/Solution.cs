using System;
using System.Text;

namespace StringCompression
{
	delegate void DoSomething(int consecutiveCount, char currentCharacter);

	public class Solution
	{
		private static void WalkString(string source, DoSomething action) {
			int consecutiveCount = 1;
			for (int i = 0; i < source.Length; i++) {
				if (i == source.Length - 1 || source[i + 1] != source[i]) {
					action(consecutiveCount, source[i]);
					consecutiveCount = 1;
				} else {
					consecutiveCount++;
				}
			}
		}
		public static string Compress(string source) {
			if (String.IsNullOrEmpty(source)) {
				return source;
			}

			// Check if it is worth compressing the source.
			int compressedLength = 0;
			WalkString(source, delegate (int consecutiveCount, char currentCharacter)
			{
				compressedLength += 1 + consecutiveCount.ToString().Length;
			});

			if (compressedLength >= source.Length) return source;

			// Compress the string.
			var result = new StringBuilder();
			WalkString(source, delegate (int consecutiveCount, char currentCharacter)
			{
				result.Append(consecutiveCount);
				result.Append(currentCharacter);
			});

			return result.ToString();
		}
	}
}
