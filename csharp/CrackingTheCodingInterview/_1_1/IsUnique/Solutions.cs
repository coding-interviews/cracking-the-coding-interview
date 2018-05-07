using System.Collections.Generic;
namespace IsUnique {
  static class Solutions {
    public static bool UsingASet(string input) {
      if (string.IsNullOrEmpty(input)) return true;

      HashSet<char> set = new HashSet<char>();

      for (int i = 0; i < input.Length; i++) {
        if (set.Contains(input[i])) {
          return false;
        }

        set.Add(input[i]);
      }

      return true;
    }
  }
}
