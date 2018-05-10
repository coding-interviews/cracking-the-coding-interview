//
// Copyright (c) 2018 Ibrahim El Far. All Rights Reserved.
// Released under MIT License. See LICENSE file for details.
//

using System;
using System.Collections.Generic;

namespace PalindromePermutation
{
	static class Solution
	{
		public static bool IsAPermutationOfAPalindrome(string s) {
			if (String.IsNullOrEmpty(s) || s.Length == 1) return true;

			var odds = new HashSet<char>();
			foreach (char c in s) {
				if (odds.Contains(c)) odds.Remove(c); else odds.Add(c);
			}

			return odds.Count <= 1;
		}
	}
}
