using System;
using Utilities;

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

        Console.WriteLine($"{Display.String(input.ToCharArray()),-16} | {Display.String(array),-16}");
      }
    }
  }
}
