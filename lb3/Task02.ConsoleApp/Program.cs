using System;
using System.Collections.Generic;
using ClassLibraryProduct;

namespace Task02.ConsoleApp
{
  
    class Program
    {
        static List<Product> products = new List<Product>();

        static void Main(string[] args)
        {
            
            for (; ; )
                Interface();
        }

        static void Interface()
        {
            Console.WriteLine("Меню класса товара. Выберите номер операции:\n" +
                "1 - Создать весовой товар.\n" +
                "2 - Создать поштучный товар.\n" +
                "3 - Вывести все созданные экземпляры товаров.\n" +
                "4 - Вывести общую стоимость товаров.\n" +
                "\n" +
                "0 - Выйти из программы.\n" +
                "\n" +
                "Выбор: ");

            short choice = -1;
            try
            {
                choice = short.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат записи!");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Число слишком большое!");
            }
            Console.Clear();
            switch (choice)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    WeightProductMenu();
                    break;
                case 2:
                    CountProductMenu();
                    break;
                case 3:
                    ForEachShow();
                    break;
                case 4:
                    Journal();
                    break;
                default:
                    Console.WriteLine("Неверный выбор! Введите число еще раз...");
                    break;
            }
            Console.ReadLine();
            Console.Clear();
        }


        static void WeightProductMenu()
        {
            Product product;

            Console.WriteLine("Создан новый экземпляр подкласса \"весовой товар\". Введите данные:");
            Console.WriteLine("Именование:");
            string name = Console.ReadLine();
            Console.WriteLine("Производитель:");
            string producer = Console.ReadLine();
            Console.WriteLine("Дата изготовления:");
            string date = Console.ReadLine();
            Console.WriteLine("Цена:");
            float.TryParse(Console.ReadLine(), out float price);
            Console.WriteLine("Комментарий:");
            string comment = Console.ReadLine();

            Console.WriteLine("Масса:");
            float.TryParse(Console.ReadLine(), out float weight);
            Console.WriteLine("Страна производитель:");
            string manufacturerСountry = Console.ReadLine();
            Console.WriteLine("Страна импортёр:");
            string importingСountry = Console.ReadLine();

            product = new WeightProduct(name, producer, date, price, comment, weight, manufacturerСountry, importingСountry);
            Console.Clear();

            Console.WriteLine("Создан новый экземпляр подкласса:\n" + product.GetInfo());
            products.Add(product);
        }

        static void CountProductMenu() 
        {
            Product product;

            Console.WriteLine("Создан новый экземпляр подкласса \"поштучный товар\". Введите данные:");
            Console.WriteLine("Именование:");
            string name = Console.ReadLine();
            Console.WriteLine("Производитель:");
            string producer = Console.ReadLine();
            Console.WriteLine("Дата изготовления:");
            string date = Console.ReadLine();
            Console.WriteLine("Цена:");
            float.TryParse(Console.ReadLine(), out float price);
            Console.WriteLine("Комментарий:");
            string comment = Console.ReadLine();

            Console.WriteLine("Количество:");
            int.TryParse(Console.ReadLine(), out int count);
            Console.WriteLine("Цвет:");
            string color = Console.ReadLine();

            product = new CountProduct(name, producer, date, price, comment, count, color);
            Console.Clear();

            Console.WriteLine("Создан новый экземпляр подкласса:\n" + product.GetInfo());
            products.Add(product);
        }

        static void ForEachShow() {
            if (products.Count != 0)
            {
                Console.WriteLine("Все товары:\n");
                foreach (var product in products) {
                    Console.WriteLine(product.GetInfo() + "\n");
                }
            }
            else
                Console.WriteLine("Массив товаров пуст.");
        }

        static void Journal()
        {
            if (products.Count != 0)
            {
                Console.WriteLine("Все товары:\n");
                foreach (var product in products)
                {
                    Console.WriteLine(product.AddToJournal() + "\n");
                }
            }
            else
                Console.WriteLine("Массив товаров пуст для вывода информации о стоимости.");
        }
    }
}
