using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1_3_2_._._._
{
    class Program
    {
        static void Main(string[] args)
        {

            //3-2
            int[] arrey2 = new int[] { 1, 6, 5, 4, 8 };
            int arrlen = arrey2.Length;
            Console.WriteLine("Длина массива " + arrlen + " символа:");
            foreach (int x in arrey2)
            {
                Console.Write(x + "  ");
            }
            Console.WriteLine("\nВведите индекс элемента, который хотите изменить:");
            int in1 = Convert.ToInt32(Console.ReadLine());
            string[] arrey3 = new string[] { "raz", "dva", "tri" };//меняем произвольный элемент
            Console.WriteLine("Введите значение:");
            string in2 = Console.ReadLine();
            arrey3[in1] = in2;
            Console.WriteLine("Измененный массив строк длиной " + arrlen + " символа:");
            foreach (string x in arrey3)
            {
                Console.Write(x + "   ");
            }
            //3-3
            int[][] arrey4 = new int[3][];
            arrey4[0] = new int[2];
            arrey4[1] = new int[3];
            arrey4[2] = new int[4];
            for (int x = 0; x < 3; x++)
            {
                arrey4[0][x] = x;
                for (int y = 0; y < arrey4[x].Length; y++)
                {
                    Console.WriteLine("Введите элемент массива: ");
                    arrey4[x][y] = Convert.ToInt32(Console.ReadLine());
                }
                for (x = 0; x < 3; x++)
                {
                    for (int y = 0; y < arrey4[x].Length; y++)
                    {
                        Console.Write(arrey4[x][y] + "  ");

                    }

                    Console.Write("\n");
                }
                //3-4
                int[] aar = new int[] { 1, 3 };//неявно типизированные переменные для хранения массива и строки.
                var peremen = aar;
                String peremen2 = "bla bla";
                var strvar = peremen2;
                //4-1
                var korteg = Tuple.Create(per, per4, per3, per4, per7);
                Console.WriteLine(korteg);
                Console.WriteLine(korteg.Item1);
                Console.WriteLine(korteg.Item3);
                Console.WriteLine(korteg.Item4);
                char ttt = (char)korteg.Item3;//распаковка
                int t = 1, t2 = 2, t3 = 3, t4 = 5, t5 = 8, t6 = 9; ;
                var korteg2 = Tuple.Create(t, t2, t3);
                var korteg3 = Tuple.Create(t4, t5, t6);
                if (korteg2 == korteg3)
                {
                    Console.WriteLine("Кортежи равны");
                }
                else
                {
                    Console.WriteLine("Кортежи не равны");
                }

            }

        }
        static Tuple<int, int, int, char> bla(string h, int[] b)
        {
            int min = 0, max = 0, sum = 0; char d;
            foreach (int t in b)
            {
                if (t > max) { max = t; }
                if (t < min) { min = t; }
                sum += t;

            }
            d = h[0];
            var s = Tuple.Create<int, int, int, char>(min, max, sum, d);
            return s;

        }
    }
}

