using System;
using System.Collections.Generic;
using Utilities.LinkedLists;

namespace Partition
{
	class Program
	{
		static IEnumerable<Node> BuildLists() {
      yield return ListBuilder.Build();
      yield return ListBuilder.Build(1);
			yield return ListBuilder.Build(1, 2, 3);
			yield return ListBuilder.Build(6, 7, 8);
			yield return ListBuilder.Build(5, 1, 2, 3);
			yield return ListBuilder.Build(1, 5, 2, 3);
			yield return ListBuilder.Build(1, 2, 5, 3);
			yield return ListBuilder.Build(1, 2, 3, 5);
			yield return ListBuilder.Build(5, 6, 7, 8);
			yield return ListBuilder.Build(6, 5, 7, 8);
			yield return ListBuilder.Build(6, 7, 5, 8);
			yield return ListBuilder.Build(6, 7, 8, 5);
			yield return ListBuilder.Build(1, 2, 3, 5, 6, 7, 8);
			yield return ListBuilder.Build(1, 5, 6, 2, 3, 7, 8);
			yield return ListBuilder.Build(1, 5, 2, 3, 5, 6, 7, 8, 5, 6, 5, 4, 9);
    }

		static void Main(string[] args) {
			foreach (var list in BuildLists()) {
				Console.WriteLine($"before: {Display.List(list)}");
				var partitioned = Partitioner.Partition(list, 5);
				Console.WriteLine($"after:  {Display.List(partitioned)}");
			}
		}
	}
}
