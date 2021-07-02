using System;

namespace Task_5
{
    class Program
    {
        //Романовский Денис

        /* а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
           б) Сделать задание, только вывод организовать в центре экрана.
           в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y). */

        static void Main(string[] args)
        {
            string name;
            string lastName;
            string sity;


            Console.Write("Введите Имя: ");
            name = Console.ReadLine();

            Console.Write("Введите Фамилию: ");
            lastName = Console.ReadLine();

            Console.Write("Введите Город проживания: ");
            sity = Console.ReadLine();


            Print(name, lastName, sity);

            Console.ReadLine();
        }

        static void Print(string name, string last, string sity)
        {
            int centerX = (Console.WindowWidth / 2) - (name.Length / 2) - (last.Length / 2) - (sity.Length / 2);
            int centerY = (Console.WindowHeight / 2) - 1;

            Console.SetCursorPosition(centerX, centerY);
            Console.WriteLine(name + " " + last + " " + sity);
        }
    }
}
