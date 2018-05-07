using System;
namespace RotateMatrix
{
	static class Solution
  {
		public static void Rotate(int[,] matrix) {
			int size = matrix.GetLength(0);

			for (int layer = 0; layer < size/2; layer++) { // layer depth
				int first = layer;
				int last = size - layer - 1; // layer length

				for (int i = first; i < last; i++) {
					// Calculate offset
					int offset = i - first;

					// Save the top
					int top = matrix[first, i];

					// Rotate left into top
					matrix[first, i] = matrix[last - offset, first];

					// Rotate bottom into left
					matrix[last - offset, first] = matrix[last, last - offset];

					// Rotate right into bottom
					matrix[last, last - offset] = matrix[i, last];

					// Rotate saved top into right
					matrix[i, last] = top;
				}

			}
		}
  }
}
