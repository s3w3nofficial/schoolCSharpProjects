using System;

namespace pascalTriangle
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[][] triangle = new int[5][];
			triangle [0] = new int[]{ 1 };
			triangle [1] = new int[]{ 1, 1 };
			for (int i = 2; i < triangle.Length; i++) {
				int delka = triangle [i - 1].Length + 1;
				int[] newRow = new int[delka];
				newRow [0] = 1;
				for (int j = 1; j < delka-1; j++) {
					newRow [j] = triangle [i - 1] [j - 1] + triangle [i - 1] [j];
				}
				newRow [delka - 1] = 1;
				triangle [i] = newRow;
			}

			//Vypis
			for (int i = 0; i < triangle.Length; i++) {
				for (int j = 0; j < triangle[i].Length; j++) {
					Console.Write (triangle[i][j] + " ");
				}
				Console.WriteLine ();
			}
		}
	}
}
