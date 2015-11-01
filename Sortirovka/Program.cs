using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Sortirovka {
	class Program {
		static void Main(string[] args) {
			int sizeMas;
			int repeatCycle = 0;
			do {
				Console.WriteLine("vved razm mas");
				sizeMas = Convert.ToInt32(Console.ReadLine());
				CreateMas(sizeMas);
				Console.WriteLine("for out press 1");
				repeatCycle = Convert.ToInt32(Console.ReadLine());
				Console.Clear();
			} while (repeatCycle != 1);
		}
		static void CreateMas(int razMas) {
			Random rand = new Random();
			int[] Mas = new int[razMas];
			for (int i = 0; i < Mas.Length; i++) {
				Mas[i] = rand.Next(-razMas, razMas);
			}

			Console.WriteLine("Mas was created");

			PrintMas(Mas);
			Console.WriteLine("Mas was sorted");
			quickSort(Mas, 0, Mas.Length - 1);
			PrintMas(Mas);

		}
		static void PrintMas(int[] mas) {
			for (int i = 0; i < mas.Length; i++) {
				Console.Write(mas[i] + " ");
				if (i == mas.Length - 1) Console.WriteLine(" ");
			}
		}



		static void quickSort(int[] mas, int left, int right) {
			int prom;
			int x = mas[left + (right - left) / 2];

			int i = left;
			int j = right;

			while (i <= j) {
				while (mas[i] < x) i++;
				while (mas[j] > x) j--;
				if (i <= j) {
					prom = mas[i];
					mas[i] = mas[j];
					mas[j] = prom;
					i++;
					j--;
				}
			}
			if (i < right) quickSort(mas, i, right);

			if (left < j) quickSort(mas, left, j);
		}
	}
}
