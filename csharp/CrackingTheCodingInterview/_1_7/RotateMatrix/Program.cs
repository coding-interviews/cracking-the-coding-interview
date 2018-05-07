using System;

namespace RotateMatrix
{
  static class Program
  {
		static int[,] GenerateMatrix(int size) {
			var count = 1;
			var matrix = new int[size, size];
			for (var row = 0; row < size; row++) {
				for (var col = 0; col < size; col++) {
					matrix[row, col] = count++;
				}
			}

			return matrix;
		}

		static void WriteMatrixToConsole(int[,] matrix) {
			int size = matrix.GetLength(0);

			for (var row = 0; row < size; row++)
			{
				for (var col = 0; col < size; col++)
				{
					Console.Write($"{matrix[row, col],-2} ");
				}
				Console.WriteLine();
			}
		}

    static void Main(string[] args)
    {
			for (var size = 1; size <= 5; size++)
			{
				var matrix = GenerateMatrix(size);
				WriteMatrixToConsole(matrix);
				Console.WriteLine("----------");
				Solution.Rotate(matrix);
				WriteMatrixToConsole(matrix);
				Console.WriteLine("----------");
			}
    }
  }
}
