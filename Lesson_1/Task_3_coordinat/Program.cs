using System;

namespace Task_3_coordinat
{
    class Program
    {
        // Романовский Денис
        // а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
        // б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

        static void Main(string[] args)
        {
            double x1 = 0;
            double y1 = 0;
            double x2 = 0;
            double y2 = 0;

            double distance = 0;
            Console.Write("Input x1: ");
            x1 = double.Parse(Console.ReadLine());

            Console.Write("Input y1: ");
            y1 = double.Parse(Console.ReadLine());

            Console.Write("Input x2: ");
            x2 = double.Parse(Console.ReadLine());

            Console.Write("Input y2: ");
            y2 = double.Parse(Console.ReadLine());


            DoDistance(distance, x1, y1, x2, y2);

            Console.ReadLine();
        }

        static double DoDistance(double dis, double x1, double y1, double x2, double y2)
        {
            dis = Math.Sqrt(Math.Pow(x1 - y1, 2) + Math.Pow(x2 - y2, 2));

            Console.WriteLine("\nDistance: " + Math.Round(dis, 2));

            return (dis);
        }
    }

}
