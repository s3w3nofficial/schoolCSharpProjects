using System;

namespace pascalTriangle
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Zadejte počet generovaných řádků");

			int[][] triangle = new int[int.Parse (Console.ReadLine ())][];
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
			string mezera = "";
			int delkaMezery = triangle.Length + 1;
			for (int i = 0; i < triangle.Length; i++) {
				mezera = "";
				for (int a = 0; a < delkaMezery; a++) {
					mezera += " ";
				}
				delkaMezery -= 1;
				Console.Write (mezera);
				for (int j = 0; j < triangle[i].Length; j++) {
					Console.Write (triangle[i][j] + " ");
				}
				Console.WriteLine ();
			}
		}
	}
}
