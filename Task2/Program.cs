/*Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создайте класс AbstractHandler. 
В теле класса создать методы void Open(), void Create(), void Chenge(), void Save(). 
Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler. 
Написать программу, которая будет выполнять определение документа и для каждого формата должны быть методы открытия, создания, редактирования, сохранения определенного формата документа.  
*/
using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler xmlHandler = new XMLHandler();
            AbstractHandler txtHandler = new TXTHandler();
            AbstractHandler docHandler = new DOCHandler();

            Console.ForegroundColor = ConsoleColor.Red;
            xmlHandler.Create();
            xmlHandler.Open();
            xmlHandler.Change();
            xmlHandler.Save();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            txtHandler.Create();
            txtHandler.Open();
            txtHandler.Change();
            txtHandler.Save();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            docHandler.Create();
            docHandler.Open();
            docHandler.Change();
            docHandler.Save();
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
