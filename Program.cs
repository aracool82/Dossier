using System;
using System.Collections.Generic;

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
                        ShowAll(fullNameList, jobPositionList);
                        break;
                    case "3":
                        DeleteDossier(fullNameList, jobPositionList);
                        break;
                    default:
                        Console.Clear();
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            } while (selectMenu!="4");
        }

        public static void DeleteDossier(List<string> fullNameList,List<string> jobPositionList)
        {
            if (fullNameList.Count == 0)
            {
                Console.WriteLine("Нет ни одного досье");
                return;
            }

            Console.Clear();
            ShowAll(fullNameList, jobPositionList);
            Console.WriteLine("Какой № досье удалить?");
            int number =Convert.ToInt32( Console.ReadLine());
            
            if (number > 0 && number <= fullNameList.Count)
            {
                fullNameList.RemoveAt(number-1);
                jobPositionList.RemoveAt(number-1);
                Console.WriteLine("Досье удалено.");
            }
            else
            {
                Console.WriteLine("Не верно введен номер.");
            }
        }
        
        private static void ShowAll(List<string> fullNameList, List<string> jobPositionList)
        {
            if (fullNameList.Count > 0)
                for (int i = 0; i < fullNameList.Count; i++)
                    Console.WriteLine(i + 1 + ". " + fullNameList[i] + " - " + jobPositionList[i]);
            else
                Console.WriteLine("Нет ни кто");
        }

        public static void AddDossier(List<string> fullNameList,List<string> jobPositionList)
        {
            Console.Clear();
            Console.WriteLine("Введите ФИО : ");
            string inputFullName = Console.ReadLine();
            Console.WriteLine("Введите Должность : ");
            string inputJobPosition = Console.ReadLine();
            fullNameList.Add(inputFullName);
            jobPositionList.Add(inputJobPosition);
        }
    }
}