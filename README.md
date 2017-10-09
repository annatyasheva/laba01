using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-1
            sbyte a = 1;
            byte aa = 1;
            short c = 1;
            ushort d = 1;
            int e = 1;
            uint f = 1;
            long g = 1;
            ulong h = 1;
            char j = '1';
            float k = 1;
            double l = 1;
            bool m = true;
            decimal n = 1;
            string o = "1";
            object p = 1;
            dynamic r = 1;
            //1-2
            //Неявное приведение:
            l += e;
            c += a;
            e += d;
            k -= a;
            n *= h;
            //Явное приведение:
            c += (short)e;
            j += (char)a;
            a += (sbyte)j;
            r -= (dynamic)a;
            k += (float)l;
            //1-3
            Object O = e;
            int eO = (int)O;
            //1-4
            var avar = 3;
            o += avar;
            //1-5
            int? anull_1 = null;
            int anull_2 = anull_1 ?? 3;
            Console.WriteLine("Задание 2\n----------\n");
            //2-1
            String str1 = "EEEE";
            String str2 = "E";
            int stroka;
            stroka = String.Compare(str1, str2);
            Console.WriteLine("Результат сравнения строк:" + stroka);
            Console.WriteLine("Сравнивает два указанных объекта String и возвращает " +
                "целое число, которое показывает их относительное положение в порядке сортировки.");
            //2-2
            String str01 = "AAAAA";
            String str02 = "BBBBB";
            String str03 = "CCCCC";
            Console.WriteLine("1ая строка: " + str01);
            Console.WriteLine("2ая строка: " + str02);
            Console.WriteLine("3я строка: " + str03);
            Console.WriteLine("\n Сцепление");
            String strcon = String.Concat(str01, str02);
            Console.WriteLine(strcon);
            Console.WriteLine("\n Копирование");
            String strcop = String.Copy(str03);
            Console.WriteLine(strcop);
            Console.WriteLine("\n Извлечение подстроки");
            string strpod = str02.Substring(2);
            Console.WriteLine("Подстрока 2ой строки:  " + strpod);
            Console.WriteLine("\nРазделение подстроки на слова");
            string slova = "AA BB CC";
            Console.WriteLine("Строка:  " + slova);
            string[] words = slova.Split(' ');
            Console.WriteLine("Разделенная строка:  ");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("\nВставка подстроки в заданную позицию");
            Console.WriteLine("Строка: " + slova + "; Подстрока: " + strpod);
            slova = slova.Insert(2, strpod);
            Console.WriteLine("Новая строка " + slova);
            Console.WriteLine("\nУдаление заданной подстроки ");
            slova = slova.Remove(2, 5);
            Console.WriteLine("Новая строка " + slova);
            Console.WriteLine("\n");
            //2-3
            String strempty = "";
            String strnull = null;
            int dlina = strempty.Length;
            Console.WriteLine("длина пустой строки = " + dlina);
            //2-4
            StringBuilder strb = new StringBuilder("ABC", 50);
            Console.WriteLine(strb);
            strb.Append("DDD");
            Console.WriteLine(strb);
            strb.Insert(0, "Начало");
            int dlina1 = strb.Length;
            strb.Insert(dlina1, "конец");
            Console.WriteLine(strb);
            strb.Remove(0, 3);
            Console.WriteLine(strb + "\n");
            //3-1
            int[,] arr1 = new int[,] { { 1, 1, 1 }, { 2, 2, 2 }, { 3, 3, 3 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j1 = 0; j1 < 3; j1++)
                {
                    Console.Write(arr1[i, j1] + "  ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
                   
    }
}
