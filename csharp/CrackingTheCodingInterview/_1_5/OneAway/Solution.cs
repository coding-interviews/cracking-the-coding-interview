using System;
namespace OneAway
{
	static class Solution
	{
		public static bool AreOneEditAway(string a, string b) {
			if (a == null && b == null) return false;
			if (a == null || b == null) return false;
			if (Math.Abs(a.Length - b.Length) > 1) return false;

			bool aIsShorter = a.Length < b.Length;
			string shorter = aIsShorter ? a : b;
			string longer = aIsShorter ? b : a;

			int s = 0;
			int l = 0;
			bool aDifferenceHasBeenFound = false;
			while (s < shorter.Length && l < longer.Length) {
				if (shorter[s] == longer[l]) {
					// There is no difference so far.
					s++;
					l++;
				} else {
					if (aDifferenceHasBeenFound) return false; // There is more than one edit.
					aDifferenceHasBeenFound = true;

					if (shorter.Length == longer.Length) {
						// We found an edit: a replace.
						s++;
						l++;
					} else {
						// We found an edit: an addition or a removal.
						// We advance one of the indexes, and the rest of the string should match.
						l++;
					}
				}
			}

			// Either there is no difference or there is one difference at this point.
			return true;
		}
	}
}
