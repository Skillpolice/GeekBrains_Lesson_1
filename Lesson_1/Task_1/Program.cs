using System;

namespace Task_1
{
    class Program
    {
        //Романовский Денис  

        // Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
        //а) используя склеивание;
        //б) используя форматированный вывод;
        //в) используя вывод со знаком $.
        static void Main(string[] args)
        {
            string name;
            string lastname;
            int age;
            int height;
            int weight;

            Console.Write("Введите Имя: ");
            name = Console.ReadLine();

            Console.Write("Введите Фамилию: ");
            lastname = Console.ReadLine();

            Console.Write("Введите Возраст: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Введите Рост: ");
            height = int.Parse(Console.ReadLine());

            Console.Write("Введите Вес: ");
            weight = int.Parse(Console.ReadLine());


            Console.WriteLine("\n" + name + "" + lastname + "" + age + "" + height + "" + weight); // используя склеивание;
            Console.WriteLine("\n");

            Console.WriteLine($"{name}{lastname}{age}{ height}{ weight}"); // используя вывод со знаком $.
            Console.WriteLine("\n");

            Console.WriteLine("{0}{1}{2}{3}{4}", name, lastname, age, height, weight); //используя форматированный вывод;

            Console.ReadLine();

        }
    }
}
