using System.Text;

namespace Utilities.LinkedLists
{
  public static class Display
  {
		public static string List(Node head) {
			if (head == null) return "<null>";

			var result = new StringBuilder();
			var current = head;
			while (current.Next != null) {
				result.Append(current.Data);
				result.Append(", ");
				current = current.Next;
			}
			result.Append(current.Data);

			return result.ToString();
		}

		public static string Node(Node head) {
			if (head == null) return "<null>";

			return head.Data.ToString();
		}
  }
}
