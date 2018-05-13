using System;
using Utilities.LinkedLists;

namespace KthToTheLast
{
  public static class KthToLastComputer
  {
		public static Node Compute (Node head, int k) {
			if (head == null || k < 0) return null;

			var p = head;
			var q = head;
			for (int i = 0; i < k && q != null; i++) {
				q = q.Next;
			}

			if (q == null) return null;

			while (q.Next != null) {
				p = p.Next;
				q = q.Next;
			}

			return p;
		}
  }
}
