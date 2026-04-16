using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Dz26Nomay
{
    public class Menu
    {
        public bool start()
        {
            string choise;
            Console.Write("\nВыберите пункт\n1) Класс «Точка»\n2) Класс «Пользователь» \n3) Класс «Персональный компьютер»\n4) Класс «Ноутбук» " +
                "\n5) Задание про книги из второго ворда\nВвод: ");
            choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    int x, y, z;
                    Console.Write("\nВведите координату x для точки\nВвод: ");
                    x = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nВведите координату y для точки\nВвод: ");
                    y = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nВведите координату z для точки\nВвод: ");
                    z = Convert.ToInt32(Console.ReadLine());

                    Point objOne = new Point(x,y,z);
                    Console.Write($"\nКоординаты точки равны = {objOne.x}, {objOne.y}, {objOne.z}\n");

                    Console.Write("\nВведите координату x для сдвига\nВвод: ");
                    x = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nВведите координату y для сдвига\nВвод: ");
                    y = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nВведите координату z для сдвига\nВвод: ");
                    z = Convert.ToInt32(Console.ReadLine());

                    objOne.MoveBy(x,y,z);

                    Console.Write($"\nКоординаты точки равны = {objOne.x}, {objOne.y}, {objOne.z}\n");
                    break;
                case "2":
                    string name, clan, patronymic;
                    int age;
                    Console.Write("\nВведите ИМЯ пользователя\nВвод: ");
                    name = Console.ReadLine();

                    Console.Write("\nВведите ФАМИЛИЮ пользователя\nВвод: ");
                    clan = Console.ReadLine();

                    Console.Write("\nВведите ОТЧЕСТВО пользователя\nВвод: ");
                    patronymic = Console.ReadLine();

                    Console.Write("\nВведите ВОЗРАСТ пользователя\nВвод: ");
                    age = Convert.ToInt32(Console.ReadLine());

                    User obj = new User(name, clan, patronymic, age);
                    Console.Write($"\nФИО И ВОЗРАСТ ПОЛЬЗОВАТЕЛЯ: {obj.Act()}\n");
                    break;
                case "3":
                    string model;
                    int clockFrequency, ram, hardDiskCapacity;

                    Console.Write("\nВведите Модель ПК\nВвод: ");
                    model = Console.ReadLine();

                    Console.Write("\nВведите Частоту ПК\nВвод: ");
                    clockFrequency = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nВведите ОЗУ ПК\nВвод: ");
                    ram = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nВведите Объем hard-диска ПК\nВвод: ");
                    hardDiskCapacity = Convert.ToInt32(Console.ReadLine());

                    PC objEc = new PC(model, clockFrequency, ram, hardDiskCapacity);
                    objEc.printInfo();
                    break;
                case "4":
                    string modelBook;
                    double massaBook;
                    int clockFrequencyBook, ramBook, hardDiskCapacityBook;

                    Console.Write("\nВведите Модель Ноута\nВвод: ");
                    modelBook = Console.ReadLine();

                    Console.Write("\nВведите Частоту Ноута\nВвод: ");
                    clockFrequencyBook = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nВведите ОЗУ Ноута\nВвод: ");
                    ramBook = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nВведите Объем hard-диска Ноута\nВвод: ");
                    hardDiskCapacityBook = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nВведите Массу ПК\nВвод: ");
                    massaBook = Convert.ToDouble(Console.ReadLine());

                    SmartBook objBook = new SmartBook(modelBook, clockFrequencyBook,ramBook, hardDiskCapacityBook, massaBook);
                    objBook.printInfo();
                    break;
                case "5":
                    string choiseSecond;
                    Console.Write("\nВведите название Книги\nВвод:  ");
                    string nameBook = Console.ReadLine();

                    Console.Write("\nВведите автора Книги\nВвод:  ");
                    string autorBook = Console.ReadLine();

                    Console.Write("\nВведите год выпуска Книги\nВвод: ");
                    int year = int.Parse(Console.ReadLine());

                    Console.Write("\nВведите объем (в листах)\nВвод: ");
                    int volume = int.Parse(Console.ReadLine());

                    FeaturesBook book1 = new FeaturesBook(nameBook, autorBook, year, volume);
                    MethodBook book2 = new MethodBook(nameBook, autorBook, year, volume);

                    Console.Write("\nКак именно взайдмодействовать с Книгами?");
                    Console.Write("\nВыберите пункт\n1) Features\n 2)Method\nВвод: ");
                    choiseSecond = Console.ReadLine();
                    if (choiseSecond.Equals("1"))
                    {
                        Console.WriteLine("\n\nРАБОТА СО СВОЙСТВАМИ (Features):");
                        book1.Title = "Новое название (изменено через свойство)";
                        Console.WriteLine($"Измененное название: {book1.Title}");
                        Console.WriteLine($"Автор (только чтение): {book1.Author}");
                        Console.WriteLine($"Издательство (авто): {book1.Publisher}");
                        Console.WriteLine(book1.Information);
                    }
                    else if (choiseSecond.Equals("2"))
                    {
                        Console.WriteLine("\n\nРАБОТА С МЕТОДАМИ (Method):");
                        book2.SetTitle("Новое название (через метод)");
                        Console.WriteLine($"Название через GetTitle(): {book2.GetTitle()}");
                        Console.WriteLine($"Автор через GetAuthor(): {book2.GetAuthor()}");
                        Console.WriteLine($"Год: {book2.GetYear()}, Страниц: {book2.GetPages()}");
                        Console.WriteLine(book2.GetInformation());
                    }
                    

                    Console.WriteLine();
                    break;
                default:
                    Console.Write("\nВыход... ");
                    return false;
            }
            return true;
        }
    }
}