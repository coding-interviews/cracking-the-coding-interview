using System;
namespace Utilities
{
  public static class Display
  {
    public static string String(string input) {
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
