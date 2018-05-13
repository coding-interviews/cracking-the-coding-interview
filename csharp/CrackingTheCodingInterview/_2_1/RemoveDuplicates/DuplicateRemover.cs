using System.Collections.Generic;
using Utilities.LinkedLists;

namespace RemoveDuplicates
{
	static class DuplicateRemover
  {
		public static void RemoveUsingHashSet(Node head) {
			if (head == null || head.Next == null) return;

			var set = new HashSet<int>();
			Node previous = head;
			var current = head.Next;
			while (current != null) {
				if (set.Contains(current.Data)) {
					previous.Next = current.Next;
          current = current.Next;
				} else {
					set.Add(current.Data);
					current = current.Next;
				}
			}
		}

		public static void RemoveWithMultiplePasses(Node head) {
			if (head == null || head.Next == null) return;

			var main = head;

			while (main != null && main.Next != null) {
				var previous = main;
				var current = main.Next;

				while (current != null) {
					if (current.Data == main.Data) {
						previous.Next = current.Next;
						current = current.Next;
					} else {
						previous = current;
						current = current.Next;
					}
				}

				main = main.Next;
			}
		}

		public static bool hasDuplicates(Node head) {
			var set = new HashSet<int>();

			var current = head;

			while (current != null) {
				if (set.Contains(current.Data)) return true;
				set.Add(current.Data);
				current = current.Next;
			}

			return false;
		}
  }
}
