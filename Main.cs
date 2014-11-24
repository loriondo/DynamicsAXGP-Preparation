using System;

namespace Introduction
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Writing to console.
			Console.WriteLine ("Hello World!");
			Console.Write ("Line break testing.\nLine break.\n");
			char a = 'a';
			char b = 'b';
			char c = 'c';
			Console.WriteLine ("Alphabets start with {0}, {1}, {2}.", a, b, c); //like java printf

			//Language very similar to Java
			int[] numbers = new int[10];
			for(int i = 1; i <= numbers.Length; i++){
				numbers[i-1] = i;
				Console.WriteLine (numbers[i-1]);
			}

			//Multi-dimensional arrays
			string[,] names = new string[3, 1];
			for (int i = 0; i < names.Length; i++) {
				for(int j = 0; j < names.Length; j++) {
					Console.Write("| x ");
				}
				Console.Write ("|\n");
			}
			int[,] numbersArray = new int[3, 1] {{1}, {2}, {3}};
			int[,] numbersArray2 = new int[1, 3] {{1, 2, 3}};

		}
	}
}
