using System;
namespace Utilities.LinkedLists
{
  public static class ListBuilder
  {
		public static Node Build(params int[] data) {
			if (data == null || data.Length == 0) return null;

			Node head = null;
			Node previous = null;
			foreach (var d in data) {
				var current = new Node(d);
				if (previous == null) {
					head = current;
				} else {
					previous.Next = current;
				}
				previous = current;
			}

			return head;
		}
  }
}
