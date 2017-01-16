using System;

namespace vypatlator
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//string s = Console.ReadLine ().ToLower();
			string s = "Lorem ipsum dolor sit amet constructor s w".ToLower();
			string puvs = s;
			string res = "";
			Random r = new Random ();
			for (int i = 0; i < s.Length; i++) {
				int n = r.Next (0, 2);
				if (n == 1) {
					res += s [i].ToString ().ToUpper();
				} else {
					res += s [i].ToString ();
				}
			}
			s = res;
			res = "";
			for (int i = 0; i < s.Length; i++) {
				
			}
			Console.WriteLine (puvs);
			Console.WriteLine (res);
		}
	}
}
