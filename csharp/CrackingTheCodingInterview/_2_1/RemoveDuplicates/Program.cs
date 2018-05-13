using System;
using System.Collections.Generic;
using Utilities.LinkedLists;

namespace RemoveDuplicates
{
	class Program
	{
		static IEnumerable<Node> BuildLists() {
			yield return ListBuilder.Build();
			yield return ListBuilder.Build(1);
			yield return ListBuilder.Build(1, 2);
			yield return ListBuilder.Build(1, 2, 3);
			yield return ListBuilder.Build(1, 1, 2, 3);
			yield return ListBuilder.Build(1, 2, 1, 3);
			yield return ListBuilder.Build(1, 2, 3, 1);
			yield return ListBuilder.Build(1, 2, 2, 3);
			yield return ListBuilder.Build(1, 2, 3, 2);
			yield return ListBuilder.Build(1, 2, 3, 3);
			yield return ListBuilder.Build(1, 2, 3, 3, 3, 3);
			yield return ListBuilder.Build(1, 1, 1, 1, 2, 3);
			yield return ListBuilder.Build(1, 2, 2, 2, 2, 3);
		}

		static void Main(string[] args) {
			var lists = BuildLists();

			Console.WriteLine("Using the first method:");

			foreach (Node head in lists) {
				Console.WriteLine($"Before: {Display.List(head)} (duplicates? {DuplicateRemover.hasDuplicates(head)}).");
				DuplicateRemover.RemoveUsingHashSet(head);
				Console.WriteLine($"After : {Display.List(head)} (duplicates? {DuplicateRemover.hasDuplicates(head)}).");
			}

			Console.WriteLine();
			Console.WriteLine("Using the second method:");

			foreach (Node head in lists) {
        Console.WriteLine($"Before: {Display.List(head)} (duplicates? {DuplicateRemover.hasDuplicates(head)}).");
				DuplicateRemover.RemoveWithMultiplePasses(head);
        Console.WriteLine($"After : {Display.List(head)} (duplicates? {DuplicateRemover.hasDuplicates(head)}).");
      }

		}
	}
}
