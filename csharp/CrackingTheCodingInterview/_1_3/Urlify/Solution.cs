//
// Copyright (c) 2018 Ibrahim El Far. All Rights Reserved.
// Released under MIT License. See LICENSE file for details.
//

namespace Urlify
{
	static class Solution
	{
		public static void Urlify(char[] s, int n) {
			if (n < 1 || n > s.Length || s == null || s.Length == 0) return;

			// How many spaces are there in the string?
			int spaces = 0;
			for (int i = 0; i < n; i++) {
				if (s[i] == ' ') spaces++;
			}

			// Are there spaces and is there enough space to urlify?
			if (spaces < 1 || s.Length - n < 2 * spaces) return;

			// Replace the spaces.
			int remaining = spaces;
			for (int i = n - 1; i >= 0 && remaining > 0; i--) {
				if (s[i] == ' ') {
					s[i + 2 * remaining] = '0';
					s[i + 2 * remaining - 1] = '2';
					s[i + 2 * remaining - 2] = '%';
					remaining--;
				} else {
					s[i + 2 * remaining] = s[i];
				}
			}
		}
	}
}
