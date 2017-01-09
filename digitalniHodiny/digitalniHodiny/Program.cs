using System;
using System.Threading;

namespace digitalniHodiny
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] cisla = new string[11];
			cisla [0] = "_______   \n\\   _  \\  \n/  /_\\  \\ \n\\  \\_/   \\\n \\_____  /\n       \\/ ";
			cisla [1] = " ____ \n/_   |\n |   |\n |   |\n |___|\n      ";
			cisla [2] = "________  \n\\_____  \\ \n /  ____/ \n/       \\ \n\\_______ \\\n        \\/";
			cisla [3] = "________  \n\\_____  \\ \n  _(__  < \n /       \\\n/______  /\n       \\/ ";
			cisla [4] = "   _____  \n  /  |  | \n /   |  |_\n/    ^   /\n\\____   | \n     |__| ";
			cisla [5] = " .________\n |   ____/\n |____  \\ \n /       \\\n/______  /\n       \\/ ";
			cisla [6] = "  ________\n /  _____/\n/   __  \\ \n\\  |__\\  \\\n \\_____  /\n       \\/ ";
			cisla [7] = "_________ \n\\______  \\\n    /    /\n   /    / \n  /____/  \n          ";
			cisla [8] = "  ______  \n /  __  \\ \n >      < \n/   --   \\\n\\______  /\n       \\/ ";
			cisla [9] = " ________ \n/   __   \\\n\\____    /\n   /    / \n  /____/  \n          ";
			cisla [10] = "    \n /\\ \n \\/ \n /\\ \n \\/ \n    ";
			while (true) {
				string time = DateTime.Now.ToString ("hh:mm:ss");
				foreach (var s in time) {
					switch (s) {
					case '0':
						Console.WriteLine (cisla [0]);
						break;
					case '1':
						Console.WriteLine (cisla [1]);
						break;
					case '2':
						Console.WriteLine (cisla [2]);
						break;
					case '3':
						Console.WriteLine (cisla [3]);
						break;
					case '4':
						Console.WriteLine (cisla [4]);
						break;
					case '5':
						Console.WriteLine (cisla [5]);
						break;
					case '6':
						Console.WriteLine (cisla [6]);
						break;
					case '7':
						Console.WriteLine (cisla [7]);
						break;
					case '8':
						Console.WriteLine (cisla [8]);
						break;
					case '9':
						Console.WriteLine (cisla [9]);
						break;
					case ':':
						Console.WriteLine (cisla [10]);
						break;
					default:
						break;
					}
				}
				Thread.Sleep (1000);
				Console.Clear ();
			}
		}
	}
}
