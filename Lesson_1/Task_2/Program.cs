using System;

namespace Task_2
{
    class Program
    {
        //Романовский Денис
        //Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.

        static void Main(string[] args)
        {
            double height;
            double weight;
            double summ;


            Console.Write("Введите Рост: ");
            height = double.Parse(Console.ReadLine());

            Console.Write("Введите Вес: ");
            weight = Convert.ToDouble(Console.ReadLine());

            while (height < 0 || weight < 0)
            {
                Console.WriteLine("отрицательное число: Введите положительно число \n");

                Console.Write("Введите Рост: ");
                height = double.Parse(Console.ReadLine());

                Console.Write("Введите Вес: ");
                weight = Convert.ToDouble(Console.ReadLine());

            }


            summ = (weight * 10000) / (height * height);

            Console.WriteLine("\nИМТ = " + Math.Round(summ, 2) + "\n");

            if (summ <= 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Дифицит массы тела");
            }
            else if (summ < 25)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Нормальная масса тела");
            }
            else if (summ < 30)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Повышенная масса тела, это ещё предожирение, но надо посмотреть над отношением массы жира и мышц.");
            }
            else if (summ < 35)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Это ожирение I степени, мой пухлячок, подумай над правильным питанием и регулярных тренировках.");
            }
            else if (summ < 40)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Это ожирение II степени, мой жирненький дружок. Задумайся всерьез над правильным питанием и усиленным тренингом.");
            }
            else if (summ < 150)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Это ожирение III степени, дружок, пора бы всерьез взяться за себя, иначе сдохнешь очень скоро.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Тебе уже ничего не поможет, мой слоник. :( покойся с миром");
            }

            Console.ReadLine();

        }


       
    }
   
}
