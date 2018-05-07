using System;
namespace ZeroMatrix
{
	static class Solution
	{
		public static void ZeroMatrix(int[,] matrix)
		{
			int rows = matrix.GetLength(0);
			int cols = matrix.GetLength(1);

			bool firstColumnHasAZero = false;
			for (int row = 0; row < rows; row++)
			{
				if (matrix[row, 0] == 0) { firstColumnHasAZero = true; break; }
			}

			bool firstRowHasAZero = false;
			for (int col = 0; col < cols; col++)
			{
				if (matrix[0, col] == 0)
				{
					firstRowHasAZero = true; break;
				}
			}

			for (int row = 1; row < rows; row++)
			{
				for (int col = 1; col < cols; col++)
				{
					if (matrix[row, col] == 0)
					{
						matrix[row, 0] = 0;
						matrix[0, col] = 0;
					}
				}
			}
      
			for (int row = 1; row < rows; row++)
			{
				if (matrix[row, 0] == 0) ZeroRow(matrix, row);
			}

      
			for (int col = 1; col < cols; col++)
			{
				if (matrix[0, col] == 0) ZeroColumn(matrix, col);
			}

      
			if (firstColumnHasAZero) ZeroColumn(matrix, 0);
			if (firstRowHasAZero) ZeroRow(matrix, 0);
		}

		private static void ZeroColumn(int[,] matrix, int col)
		{
			int rows = matrix.GetLength(0);

			for (int row = 0; row < rows; row++)
			{
				matrix[row, col] = 0;
			}
		}

		private static void ZeroRow(int[,] matrix, int row)
		{
			int cols = matrix.GetLength(1);

			for (int col = 0; col < cols; col++)
			{
				matrix[row, col] = 0;
			}
		}
	}
}