using System;

namespace Task_4
{
    class Program
    {
        //Романовский Денис

        /*Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
        а) с использованием третьей переменной;
        б) *без использования третьей переменной. */

        static void Main(string[] args)
        {
            int temp = 0;

            Console.Write("Введите пременную а: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите пременную b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("\ntemp = " + temp + "\na = " + a);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\na = " + a + " \nb = " + b);
            Console.ResetColor();

            Console.WriteLine("\nb = " + b + " \ntemp = " + temp);


            revertNum();

            Console.ReadLine();
        }

        static void revertNum()
        {
            Console.Write("\nВведите пременную а: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите пременную b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\na = " + a + " b = " + b);
            Console.ResetColor();

        }

        //static void revertNum()
        //{
        //    Console.Write("\nВведите пременную а: ");
        //    int a = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("Введите пременную b: ");
        //    int b = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("Введите пременную c: ");
        //    int c = Convert.ToInt32(Console.ReadLine());


        //    int temp = 0;

        //    temp = a;
        //    a = b;
        //    b = c;
        //    c = temp;

        //    Console.WriteLine("\ntemp = " + temp + "\na = " + a);

        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("\na " + a + " = b " + b);
        //    Console.WriteLine("\nb " + b + " = c " + c + "\n");

        //    Console.ForegroundColor = ConsoleColor.Cyan;
        //    Console.WriteLine($"a = {a}, b = {b}, c = {c}");
        //    Console.ResetColor();

        //}
    }
}
