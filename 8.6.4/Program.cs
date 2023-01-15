using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _8._6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа создает записную книжку в виде xml файла");

            Console.Write("Введите Ф.И.О.: ");
            string fullName = Convert.ToString(Console.ReadLine());

            XElement myPerson = new XElement("Person");
            XAttribute xAttributePersonName = new XAttribute("name", fullName);

            Console.Write("Введите название улицы: ");
            string street = Convert.ToString(Console.ReadLine());
            Console.Write("Введите номер дома: ");
            string houseNumber = Convert.ToString(Console.ReadLine());
            Console.Write("Введите квартиры: ");
            string flatNumber = Convert.ToString(Console.ReadLine());

            XElement myAdress = new XElement("Adress",
                                new XElement("Street", street),
                                new XElement("HouseNumber", houseNumber),
                                new XElement("FlatNumber", flatNumber));

            Console.Write("Введите номер мобильного телефона: ");
            string mobilePhone = Convert.ToString(Console.ReadLine());
            Console.Write("Введите номер домашнего телефона: ");
            string flatPhone = Convert.ToString(Console.ReadLine());

            XElement myPhones = new XElement("Phones",
                                new XElement("MobilePhone", mobilePhone),
                                new XElement("FlatPhone", flatPhone));

            myPerson.Add(myAdress, myPhones, xAttributePersonName);

            myPerson.Save("Person.xml");
        }
    }
}
