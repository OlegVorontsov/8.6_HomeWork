using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._6_HomeWork
{
    class Program
    {
        static private void fillList (List<int> list)
        {
            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                list.Add(rand.Next(100));
            }
        }

        static private void printList (List<int> list)
        {
            int j = 1;
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]}\t");
                if (j % 10 == 0)
                {
                    Console.WriteLine();
                }
                j++;
            }
        }

        static private void clearList(int downNumber, int upNumber, List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if ((downNumber < list[i]) && (list[i] < upNumber))
                {
                    list.Remove(list[i]);
                    i--;
                }
            }
        }
        static void Main(string[] args)
        {
            List<int> listOfNumbers = new List<int>();

            fillList(listOfNumbers);
            printList(listOfNumbers);

            Console.Write("Введите нижний предел (от 0 до 100): ");
            int fromNumber = int.Parse(Console.ReadLine());
            Console.Write("Введите верхний предел (от 0 до 100): ");
            int toNumber = int.Parse(Console.ReadLine());

            clearList(fromNumber, toNumber, listOfNumbers);
            printList(listOfNumbers);

            Console.ReadLine();
        }
    }
}
