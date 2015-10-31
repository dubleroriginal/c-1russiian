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


            int N;// razmer mas
            int ou=0;

            do
            {
            Console.WriteLine("vv razm mas");
            N = Convert.ToInt32(Console.ReadLine());

            CreateMas(N);

            Console.WriteLine("for out press 1");
             ou = Convert.ToInt32( Console.ReadLine());
             Console.Clear();
              }while(ou!=1);
       }


        static void CreateMas(int razMas)
        {
            Random rand = new Random();

            int[] Mas = new int[razMas];

            for (int i = 0; i < Mas.Length; i++)
            {
                Mas[i] = rand.Next(-razMas, razMas);
            }

            Console.WriteLine("Mas was created");

            Out(Mas);
            Console.WriteLine("Mas was sorted");
            quickSort(Mas,0,Mas.Length-1);
            Out(Mas);

        }
        static void Out(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
                if (i == mas.Length-1)
                    Console.WriteLine(" ");
            }
        }

        

        static void quickSort(int[] mas, int left, int right)
        {
            int temp;
            int x = mas[left + (right - left) / 2];
           
            int i = left;
            int j = right;
           
            while (i <= j)
            {
                while (mas[i] < x) i++;
                while (mas[j] > x) j--;
                if (i <= j)
                {
                    temp = mas[i];
                    mas[i] = mas[j];
                    mas[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < right)
                quickSort(mas, i, right);

            if (left < j)
                quickSort(mas, left, j);
        }
    }
}
