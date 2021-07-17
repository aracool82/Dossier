using System;
using System.Collections.Generic;

// В функциях вы выполняли задание "Кадровый учёт"
    // Используя одну из изученных коллекций, вы смогли бы сильно себе упростить код выполненной 
    // программы, ведь у нас данные, это ФИО и позиция.
    // Поиск в данном задании не нужен.
    //
    // 1) добавить досье
    //
    // 2) вывести все досье (в одну строку через “-” фио и должность)
    //
    // 3) удалить досье
    //
    // 4) выход
namespace Dossier
{
    internal class Program
    {
        public static void Main()
        {
            string selectMenu;
            List<string> fullNameList = new List<string>();
            List<string> jobPositionList = new List<string>();  
            do
            {
                Console.WriteLine("1.Добавть досье. \n2.Вывести все досье. \n3.Удалить досье. \n4.Выход");
                selectMenu = Console.ReadLine();
                switch (selectMenu)
                {
                    case "1":
                        AddDossier(fullNameList,jobPositionList);
                        break;
                    case "2":
                        if(fullNameList.Count > 0)
                            for (int i = 0; i < fullNameList.Count; i++)
                            {
                                Console.WriteLine(i+1  + ". "+ fullNameList[i] + " - " +jobPositionList[i]);
                            }
                        else
                            Console.WriteLine("Нет ни кто");
                        break;
                    case "3":

                        break;
                    default:
                        Console.Clear();
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            } while (selectMenu!="4");
        }

        public static void AddDossier(List<string> fullName,List<string> jobPosition)
        {
            Console.Clear();
            Console.WriteLine("Введите ФИО : ");
            string inputFullName = Console.ReadLine();
            Console.WriteLine("Введите Должность : ");
            string inputJobPosition = Console.ReadLine();
            fullName.Add(inputFullName);
            jobPosition.Add(inputJobPosition);
        }
    }
}