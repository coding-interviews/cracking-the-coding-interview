//
// Copyright (c) 2018 Ibrahim El Far. All Rights Reserved.
// Released under MIT License. See LICENSE file for details.
//

using System.Collections.Generic;

namespace CheckPermutation
{
	static class Solutions
	{
		internal static bool AreIdenticalSorted(string a, string b) {
			if (string.IsNullOrEmpty(a) && string.IsNullOrEmpty(b)) return true;
			if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b)) return false;
			if (a.Length != b.Length) return false;

			var aList = new List<char>(a);
			var bList = new List<char>(b);
			aList.Sort();
			bList.Sort();

			var n = a.Length;

			for (int i = 0; i < n; i++) {
				if (aList[i] != bList[i]) return false;
			}

			return true;
		}

		internal static bool HaveIdenticalCharCount(string a, string b) {
			if (string.IsNullOrEmpty(a) && string.IsNullOrEmpty(b)) return true;
			if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b)) return false;
			if (a.Length != b.Length) return false;

			var n = a.Length;
			var counts = new Dictionary<char, int>();

			for (int i = 0; i < n; i++) {
				if (counts.ContainsKey(a[i])) counts[a[i]]++; else counts.Add(a[i], 1);
				if (counts.ContainsKey(b[i])) counts[b[i]]--; else counts.Add(b[i], -1);
			}

			foreach (char key in counts.Keys) {
				if (counts[key] != 0) return false;
			}

			return true;
		}
	}
}
