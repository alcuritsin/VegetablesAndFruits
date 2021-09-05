using System;
using System.Collections.Generic;
using Lib;

namespace VegetablesAndFruits
{
    public static class CLI
    {
        public static void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("::  База Данных: Продукты  ::");
            Console.WriteLine("Выберите режим работы:");
            Console.WriteLine("1. Показать данные всех продуктов");
            Console.WriteLine("2. Показать названия всех продуктов");
            Console.WriteLine("3. Показать названия всех цветов продуктов");
            Console.WriteLine("4. Показать максимальную колорийность в таблице");
            Console.WriteLine("5. Показать минимальную колорийность в таблице");
            Console.WriteLine("6. Показать среднюю колорийность в таблице");
            Console.WriteLine("7. Добавление нового продукта");
            Console.WriteLine("0. Выход");
            Console.ResetColor();
        }

        public static void ShowProducts(List<Product> products)
        {
            foreach (Product product in products)
            {
                ShowProduct(product);
            }
        }

        public static void ShowProduct(Product product)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("*** *** ***");
            Console.WriteLine(
                $"{product.Id}: {product.Name} {product.Type} {product.Color} {product.EnergyValue} кКал/100 гр.");
            Console.WriteLine("*** *** ***");
            Console.WriteLine();
            Console.ResetColor();
        }

        public static Product InoutProduct()
        {
            Product product = new Product() { Id = 0 };

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("::  Ввод данных продукте  ::");
            Console.Write("Введите наименование: ");
            product.Name = Console.ReadLine();
            Console.Write("Введите тип (овощ; фрукт): ");
            product.Type = Console.ReadLine();
            Console.Write("Введите цвет: ");
            product.Color = Console.ReadLine();
            Console.Write("Введите калорийность: ");
            product.EnergyValue = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            return product;
        }

        public static void ShowListValue<T>(List<T> list, string title = "")
        {
            if (title != "")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{title}:");
                Console.WriteLine("-------------------------");
            }

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.ResetColor();
        }

        public static void ShowValue<T>(T value, string msg = "")
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            if (msg != "")
            {
                Console.Write(msg);
            }

            Console.WriteLine(value);
            Console.WriteLine();

            Console.ResetColor();
        }
        
        
    }
}