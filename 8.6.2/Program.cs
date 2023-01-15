using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._6._2
{
    class Program
    {
        static private void FillPhoneNote(Dictionary<string, string> phoneNote)
        {
            char keyName = 'д';
            do
            {
                Console.Write("Введите Ф.И.О.: ");
                string fullName = Convert.ToString(Console.ReadLine());

                char keyNumber = 'д';
                do
                {
                    Console.Write($"Введите номер телефона {fullName}: ");
                    string phoneNumber = Convert.ToString(Console.ReadLine());
                    phoneNote.Add(phoneNumber, fullName);

                    Console.WriteLine($"Добавить номер телефона {fullName} (н/д): ");
                    keyNumber = Console.ReadKey(true).KeyChar;
                } while (char.ToLower(keyNumber) == 'д');

                Console.WriteLine($"Добавить контакт (н/д): ");
                keyName = Console.ReadKey(true).KeyChar;
            } while (char.ToLower(keyName) == 'д');
        }

        static private void PrintPhoneNote(Dictionary<string, string> phoneNote)
        {
            Console.WriteLine("Ваша телефонная книга");
            foreach (KeyValuePair<string, string> e in phoneNote) Console.WriteLine($"{e} ");
        }

        static private void FindNameByPhoneNumber(Dictionary<string, string> phoneNote)
        {
            Console.Write($"Введите номер телефона: ");
            string phoneNumber = Convert.ToString(Console.ReadLine());

            string name = "";
            if (phoneNote.TryGetValue(phoneNumber, out name))
            {
                Console.WriteLine($"Владельцем номера {phoneNumber} является {name}");
            }
            else
            {
                Console.WriteLine($"У номера {phoneNumber} нет владельца");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Добавьте номера в Телефонную книгу");
            Dictionary<string, string> myPhoneNote = new Dictionary<string, string>();
            FillPhoneNote(myPhoneNote);

            Console.Write("Введите '0', чтобы вывести Вашу телефонную книгу\n" +
                          "Введите '1', чтобы найти владельца по введенному номеру телефона: ");

            var input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    PrintPhoneNote(myPhoneNote);
                    break;
                case "1":
                    FindNameByPhoneNumber(myPhoneNote);
                    break;
                default:
                    Console.Write("Вы ввели недопустимый символ");
                    break;
            }
            Console.ReadLine();
        }
    }
}
