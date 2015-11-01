using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Sortirovka 
{
	class Program 
	{
		static void Main(string[] args) 
		{
			int sizeArray;
			int repeatCycle = 0;
			do 
			{
				Console.WriteLine("vved razm mas");
				sizeArray = Convert.ToInt32(Console.ReadLine());
				CreateArray(sizeArray);
				Console.WriteLine("for out press 1");
				repeatCycle = Convert.ToInt32(Console.ReadLine());
				Console.Clear();
			} while (repeatCycle != 1);
		}
		static void CreateArray(int sizeArray) 
		{
			Random rand = new Random();
			int[] Array = new int[sizeArray];
			for (int i = 0; i < Array.Length; i++) 
			{
				Array[i] = rand.Next(-sizeArray, sizeArray);
			}

			Console.WriteLine("Mas was created");

			PrintArray(Array);
			Console.WriteLine("Mas was sorted");
			quickSort(Array, 0, Array.Length - 1);
			PrintArray(Array);

		}
		static void PrintArray(int[] Array) 
		{
			for (int i = 0; i < Array.Length; i++) 
			{
				Console.Write(Array[i] + " ");
				if (i == Array.Length - 1) Console.WriteLine(" ");
			}
		}



		static void quickSort(int[] Array, int left, int right) 
		{
			int intValue;
			int x = Array[left + (right - left) / 2];

			int i = left;
			int j = right;

			while (i <= j) 
			{
				while (Array[i] < x) i++;
				while (Array[j] > x) j--;
				if (i <= j) 
				{
					intValue = Array[i];
					Array[i] = Array[j];
					Array[j] = intValue;
					i++;
					j--;
				}
			}
			if (i < right) quickSort(Array, i, right);

			if (left < j) quickSort(Array, left, j);
		}
	}
}
