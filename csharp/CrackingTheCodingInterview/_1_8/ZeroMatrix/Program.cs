//
// Copyright (c) 2018 Ibrahim El Far. All Rights Reserved.
// Released under MIT License. See LICENSE file for details.
//

using System;

namespace ZeroMatrix
{
	class Program
	{
		static int[,] GenerateMatrix(int rows, int cols) {
			var count = 1;
			var matrix = new int[rows, cols];
			for (var row = 0; row < rows; row++) {
				for (var col = 0; col < cols; col++) {
					matrix[row, col] = count++;
				}
			}

			return matrix;
		}

		static void WriteMatrixToConsole(int[,] matrix) {
			int rows = matrix.GetLength(0);
			int cols = matrix.GetLength(0);

			for (var row = 0; row < rows; row++) {
				for (var col = 0; col < cols; col++) {
					Console.Write($"{matrix[row, col],-2} ");
				}
				Console.WriteLine();
			}
		}

		static void Main(string[] args) {
			for (var size = 1; size <= 5; size++) {
				for (int i = 0; i < size; i++) {
					var matrix = GenerateMatrix(size, size);
					matrix[i, i] = 0;
					WriteMatrixToConsole(matrix);
					Console.WriteLine("----------");
					Solution.ZeroMatrix(matrix);
					WriteMatrixToConsole(matrix);
					Console.WriteLine("----------");
				}
			}
		}
	}
}
