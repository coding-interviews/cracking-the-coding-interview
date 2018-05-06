using System;
using System.Text;

namespace Urlify
{
  /// <summary>
  /// Write a method that urlifies a string assuming it has enough space to replace each space with a %20.
  /// </summary>
  class Program
  {
    static void Main(string[] args) {
      string[] inputs = {
        null,
        "",
        " ",
        "a",
        "abc",
        "a b",
        " ab",
        "ab ",
        "ab c ",
        "abc  ",
        " abc ",
        " a c ",
        " x z    ",
      };

      for (int i = 0; i < inputs.Length; i++) {
        string input = inputs[i] + "      ";
        char[] array = input.ToCharArray();
        Solution.Urlify(array, inputs[i] == null ? 0 : inputs[i].Length);

        Console.WriteLine($"{Display(input.ToCharArray()),-16} | {Display(array),-16}");
      }
    }

    private static string Display(char[] input) {
      if (input == null) return "<null>";
      if (input.Length == 0) return "<empty>";

      var sb = new StringBuilder();
      foreach (var c in input) {
        if (c == ' ') {
          sb.Append('~');
        } else {
          sb.Append(c);
        }
      }

      return sb.ToString();
    }
  }
}
