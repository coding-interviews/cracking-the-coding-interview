using System;
using System.Collections.Generic;
using Utilities.LinkedLists;

namespace KthToTheLast
{
  class Program
  {
		static IEnumerable<Node> BuildLists() {
      yield return ListBuilder.Build();
      yield return ListBuilder.Build(1);
      yield return ListBuilder.Build(1, 2);
			yield return ListBuilder.Build(1, 2, 3);
			yield return ListBuilder.Build(1, 2, 3, 4, 5);
    }

		static void Main(string[] args)
    {
			for (int k = 0; k < 7; k++) {
				foreach (var list in BuildLists()) {
					Console.WriteLine($"k={k,2} | result={Display.Node(KthToLastComputer.Compute(list, k)),6} | {Display.List(list)}");
				}
			}
    }
  }
}
