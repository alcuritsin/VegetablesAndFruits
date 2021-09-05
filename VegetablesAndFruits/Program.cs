using System;
using System.IO;
using Lib;

namespace VegetablesAndFruits
{
    class Program
    {
        static void Main()
        {
            var db = new DataBase();
            
            var exit = false;

            do
            {
                CLI.ShowMenu();
                var select = Console.ReadLine();
                switch (select)
                {
                    case "1": //  1. Показать данные всех продуктов
                        db.Open();
                        CLI.ShowProducts(db.GetProducts());
                        db.Close();
                        break;

                    case "2":  //  2. Показать названия всех продуктов
                        db.Open();
                        CLI.ShowListValue(db.GetNameProduct(), "Наименование прдуктов:");
                        db.Close();
                        break;
                    
                    case "3":  //  3. Показать названия всех цветов продуктов
                        db.Open();
                        CLI.ShowListValue(db.GetColorProduct(),"Цвета продуктов:"); 
                        db.Close();
                        break;
                    case "4":  //  4. Показать максимальную колорийность в таблице
                        db.Open();
                        CLI.ShowValue(db.GetMaxEnergyValue(),"Максимальное значение колорийности: ");
                        db.Close();
                        break;
                    case "5":  //  5. Показать минимальную колорийность в таблице
                        db.Open();
                        CLI.ShowValue(db.GetMinEnergyValue(),"Минимальное значение колорийности: ");
                        db.Close();
                        break;
                    case "6":  //  6. Показать среднюю колорийность в таблице
                        db.Open();
                        CLI.ShowValue(db.GetAvgEnergyValue(),"Среднее значение колорийности: ");
                        db.Close();
                        break;
                    case "7":  //  7. Добавление нового продукта
                        db.Open();
                        db.IsertProduct(CLI.InoutProduct());
                        db.Close();
                        break;
                    case "0": // 0. Выход
                        exit = true;
                        break;
                    default:
                        break;
                }
            } while (!exit);
            
        }
    }
}