using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueen_nemrek
{
	class Program
	{
		static bool Rossz(int i, int j, int[]J)
		{

		}
		static (bool, int) Oszlopban_keres(int i, int[] J)
		{
			int j = J[i] + 1; // -1-es inicializálásból itt lesz 0-ás index!
			while (j<J.Length && Rossz(i,j,J)) // a rossz-ban lesz szó egyedül a sakkról!
			{
				j++;
			}
			return (j < J.Length, j);
		}

		static int[] NQueens(int N)
		{
			int[] J = new int[N];
			for (int ix = 0; ix < N; ix++)
				J[ix] = -1;

			// Jobbra-balra keres
			int i = 0;
			while (0 <= i && i < N)
			{
				(bool van, int j) = Oszlopban_keres(i, J);
				if (van)
					J[i++] = j;
				else
					J[i--] = -1;
			}


			return J;
		}
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			int N = int.Parse(input);
			string stringforma = string.Join(" ", NQueens(N));
			Console.WriteLine(stringforma);
			Console.ReadKey();
		}
	}
}
