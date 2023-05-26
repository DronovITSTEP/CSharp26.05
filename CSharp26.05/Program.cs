using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp26._05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String.Concat() + +=
            // ToLower() ToUpper()
            // Replace()
            // Contains()
            // Insert()
            // Remove()
            // PadLeft() PadRight()
            // Split()
            // String.Join()
            // TrimStart() TrimEnd() Trim()
            /*string str1 = "Я ";
            string str2 = "учу ";
            string str3 = "C#";
            string str4 = str1 + str2 + str3; 
            Console.WriteLine("{0}{1}{2}", str1, str2, str3);

            str4 = str4.Replace("учу", "изучаю");
            Console.WriteLine(str4);

            str4 = str4.Insert(2, "упорно ").ToUpper();
            Console.WriteLine(str4);

            if (str4.Contains("упорно"))
                Console.WriteLine("Учу очень усердно");            
            else 
                Console.WriteLine("учу как могу");

            str4 = str4.PadLeft(25, '*');
            str4 = str4.PadRight(32, '+');
            Console.WriteLine(str4);

            str4 = str4.TrimStart('*');
            Console.WriteLine(str4);

            //string[] strArr = str4.Split(' ', '+');
            //string[] strArr = str4.Split(new char[] { ' ', '+' });
            string[] strArr = str4.Split(" +".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (string str in strArr)
            {
                Console.WriteLine(str);
            }

            str4 = str4.Remove(9);
            Console.WriteLine(str4);*/

            // String.Format
            // ("текст {индекс, размер:спецификатор}", данные);
            // C c - для числовых. выводит символ валюты
            // D d - для целочисленных
            // E e - выводит число в экспоненциальной форме
            // F f - выводит число с фиксированной десятичной точкой
            // G g
            // N n
            // P p - выводит числа с %
            // X x - выводит в 16чном формате
            /*double test1 = 9999987.987;
            int test2 = 99999;
            Console.WriteLine(String.Format("c format: {0, 15:c}", test1));
            Console.WriteLine(String.Format("D format: {0:D9}", test2));
            Console.WriteLine(String.Format("E format: {0:E}", test1));
            Console.WriteLine(String.Format("G format: {0:G}", test1));
            Console.WriteLine(String.Format("N format: {0, 15:N}", test2));
            Console.WriteLine(String.Format("P format: {0:P}", test2));
            Console.WriteLine(String.Format("X format: {0:X}", test2));

            Console.WriteLine($"double {test1}, int " +
                $"{(test2 > 0? "положительное " : "отрицательное")}");*/

            //StringBuilder;
            //Append();
            //AppendFormat();
            //Insert();
            //Remove();
            //Replace();
            //CopyTo();
            //ToString();
            /*StringBuilder sb= new StringBuilder();
            sb.Append("hello");
            sb.AppendLine();
            sb.AppendLine();
            sb.Append("world");
            Console.WriteLine(sb);

            sb.Insert(7, "afaffaf");
            Console.WriteLine(sb);
            
            sb.Replace('a', 'f');
            Console.WriteLine(sb);

            sb.Remove(3, 10);
            Console.WriteLine(sb);

            Console.WriteLine($"{sb.Length} {sb.Capacity} {sb.MaxCapacity}");*/

            //CompareTo();
            //GetName();
            //Enum.GetNames();
            //Enum.GetValues();
            //Enum.IsDefined();
            //Enum.Parse();
            /*string earth = "Earth";
            if (!Enum.IsDefined(typeof(DistanceSun), earth))
            {
                Console.WriteLine($"значение {earth} не в перечислении");
            }
            foreach(DistanceSun distanceSun in Enum.GetValues(typeof(DistanceSun))){
                Console.WriteLine("{0, -10} {1, -10} {2, 20}",
                    Enum.Format(typeof(DistanceSun), distanceSun, "G"),
                    Enum.Format(typeof(DistanceSun), distanceSun, "D"),
                    Enum.Format(typeof(DistanceSun), distanceSun, "X"));
            }
            foreach(string str in Enum.GetNames(typeof(DistanceSun)))
            {
                Console.WriteLine(str);
            }*/

            /*
            Пользователь вводит предложение с клавиатуры. Вам
            необходимо перевернуть каждое слово предложения и
            отобразить результат на экран.
            Например:
            пользователь ввёл: sun cat dogs cup tea;
            после переворота: nus tac sgod puc aet.
            */
            /*string[] strArr = Console.ReadLine().Split(' ');
            for (int i = 0; i < strArr.Length; i++)
            {
                char[] chArr= strArr[i].ToCharArray();              
                Array.Reverse(chArr);
                strArr[i] = new string(chArr);
            }
            foreach (string str in strArr)
            {
                Console.WriteLine(str);
            }*/
            /*
            Пользователь вводит с клавиатуры предложение. 
            Приложение должно посчитать количество гласных букв в нём.
            */
            /*string glas = "уеыаоэяию";
            char[] str = Console.ReadLine().ToLower().ToCharArray();
            int countGlas = 0;
            foreach (char c in str)
            {
                if (glas.Contains(c)) countGlas++;
            }
            Console.WriteLine(countGlas);

            int count = Console.ReadLine().Split("цкнгшщзхфвпрлджчсмтб".ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine(count);*/

            /*
            Реализуйте приложение для подсчёта 
            количество вхождений подстроки в строку.
            */
            /*string str = "Кролики ехали на Роликах покупать роллы.";// Console.ReadLine();
            string subStr = "рол";
            int countSub = 0; // 3

            string[] strArr = str.ToLower().Split(' ');
            foreach (string str2 in strArr)
            {
                if (str2.Contains(subStr)) countSub++;
            }

            int index = -1;
            do
            {
                index = str.IndexOf(subStr, StringComparison.OrdinalIgnoreCase);
                if (index != -1) countSub++;
                str = str.Substring(index + subStr.Length,
                    str.Length - subStr.Length - index);
            } while (index != -1);
            Console.WriteLine(countSub);*/

            /*
             1 2 3
             2 4 5
             7 5 2

            0 2

            3 2 1
            5 4 2
            2 5 7   
             */
            const int M = 3, N = 4;
            int[,] intArr = new int[M, N]
            {
                { 7,9,5,4},
                { 8,6,3,7},
                { 1,2,5,8}
            };
            int j1 = 1, j2 = 3;
            for (int i = 0; i< intArr.GetLength(0); i++)
            {
                int temp = intArr[i, j1];
                intArr[i, j1] = intArr[i, j2];
                intArr[i, j2] = temp;
            }
            Print(intArr);

            Console.ReadKey();
        }
    static void Print(int[,] arr)
    {
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    }
}
