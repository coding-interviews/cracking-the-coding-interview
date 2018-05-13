using Utilities.LinkedLists;

namespace Partition
{
	public static class Partitioner
  {
		public static Node Partition(Node head, int p) {
			if (head == null || head.Next == null) return head;

			Node beforeHead = null;
			Node beforeTail = null;
			Node afterHead = null;
			Node afterTail = null;

			var current = head;
			while (current != null) {
				if (current.Data <= p) {
					// Add it to the "before" list
					if (beforeHead == null) {
						beforeHead = current;
						beforeTail = current;
						current = current.Next;
						beforeTail.Next = null;
					} else {
						beforeTail.Next = current;
						beforeTail = current;
						current = current.Next;
						beforeTail.Next = null;
					}
				} else {
					// Add it to the "after" list
					if (afterHead == null) {
            afterHead = current;
            afterTail = current;
            current = current.Next;
            afterTail.Next = null;
          } else {
            afterTail.Next = current;
            afterTail = current;
            current = current.Next;
            afterTail.Next = null;
          }
				}
			}

			if (beforeHead == null) return afterHead;
			beforeTail.Next = afterHead;
			return beforeHead;
		}
  }
}
