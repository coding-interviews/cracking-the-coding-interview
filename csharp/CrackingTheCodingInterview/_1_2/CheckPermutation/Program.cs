using System;

namespace CheckPermutation
{
  /// <summary>
  /// Given two strings, write a method to decide whether one is a permutation of another.
  /// </summary>
  class Program
  {
    static void Main(string[] args) {
      string[][] inputs = {
        new string[] {null, null},
        new string[] {null, ""},
        new string[] {"", ""},
        new string[] {"a", "a"},
        new string[] {"a", "b"},
        new string[] {"ab", "ab"},
        new string[] {"ab", "ba"},
        new string[] {"ab", "bac"},
        new string[] {"abc", "bac"},
      };

      Console.WriteLine("A        | B        | By Sorting | By Char Count");
      for (int i = 0; i < inputs.Length; i++) {
        string a = inputs[i][0];
        string b = inputs[i][1];
        Console.WriteLine($"{Display(a),-8} | {Display(b),-8} | {Solutions.AreIdenticalSorted(a, b),-10} | {Solutions.HaveIdenticalCharCount(a, b),-10} ");
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
