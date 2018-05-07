using System.Text;

namespace Utilities
{
  public static class Display
  {
    public static string String(char[] input) {
      return Display.String(new string(input));
    }

    public static string String(string input) {
      return Display.String(input, DisplayOptions.ShowEmpty | DisplayOptions.ShowNull | DisplayOptions.ShowSpaces);
    }

    public static string String(string input, DisplayOptions options) {
      switch (input) {
        case null:
          if ((options & DisplayOptions.ShowNull) == 0) {
            return "";
          }

          return "<null>";

        case "":
          if ((options & DisplayOptions.ShowEmpty) == 0) {
            return "";
          }

          return "<empty>";

        default:
          if ((options & DisplayOptions.ShowSpaces) == 0) {
            return input;
          }

          var sb = new StringBuilder();
          foreach (char c in input) {
            if (char.IsWhiteSpace(c)) {
              sb.Append('~');
            } else {
              sb.Append(c);
            }
          }

          return sb.ToString();
      }
    }
  }
}
