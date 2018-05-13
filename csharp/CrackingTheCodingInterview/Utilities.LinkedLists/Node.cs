namespace Utilities.LinkedLists
{
  public class Node
  {
		public int Data { get; set; }
		public Node Next { get; set; }

		public Node() {}

		public Node(int data) {
			this.Data = data;
			this.Next = null;
		}
  }
}
