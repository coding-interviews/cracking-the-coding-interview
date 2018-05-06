using System;

namespace IsUnique
{
  /// <summary>
  /// Implement an algorithm to determine if a string has all unique characters.
  /// </summary>
  static class Program
  {
    static void Main(string[] args) {
      string[] inputs = {
        null,
        String.Empty,
        "a",
        "ab",
        "abc",
        "aba",
        "aab",
        "abcabc"
      };

      Console.WriteLine("Input    | Output");
      Console.WriteLine("-------- | ------");
      foreach (string input in inputs) {
        Console.WriteLine($"{Display(input), -8} | {Solutions.UsingASet(input)}");
      }
    }

    private static string Display(string input) {
      switch (input) {
        case null:
          return "<null>";

        case "":
          return "<empty>";

        default:
          return input;
      }
    }
  }
}
