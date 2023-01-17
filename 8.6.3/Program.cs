using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> mySet = new HashSet<int>(new int[] { });

            char key = 'д';
            do
            {
                Console.Write("Введите число, которое хотите добавить в коллекцию уникальных чисел: ");
                int numberToAdd = int.Parse(Console.ReadLine());

                if (!mySet.Add(numberToAdd))
                {
                    Console.Write($"Число {numberToAdd} уже есть в коллекции уникальных чисел\n");
                }
                else
                {
                    mySet.Add(numberToAdd);
                    Console.Write($"Число {numberToAdd} добавлено в коллекцию уникальных чисел\n");
                }

                Console.Write($"Добавить еще число (н/д): ");
                key = Console.ReadKey(true).KeyChar;
            } while (char.ToLower(key) == 'д');

            Console.Write("Ваша коллекция уникальных чисел: ");
            foreach (var e in mySet) { Console.Write($"{e} "); }

            Console.ReadLine();
        }
    }
}
