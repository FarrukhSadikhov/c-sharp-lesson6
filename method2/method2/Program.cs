using System;

namespace method2
{
    class Program
    {
        static string CheckName()
        {           
            string name;
            uint countofInvalid;
            string symbolInvalid = "1234567890/} {)(|@%$&*!?,.`~=-#";
            do
            {
                countofInvalid = 0;
                name = Console.ReadLine();
                foreach (char numb1 in name)
                {
                    foreach (char numb2 in symbolInvalid)
                        if (numb1 == numb2)
                        {
                            countofInvalid++;
                        }
                }
                if (countofInvalid > 0)
                {
                    Console.WriteLine("Имя введенно не корректно,ведите имя повторно");
                }
            }
            while (countofInvalid > 0);
            return name;
        }
        static uint CheckAge()
        {
            uint years;
            UInt32.TryParse(Console.ReadLine(), out years);
            if (years < 1 || years > 99)
            {
                while (years < 1 || years > 99)
                {
                    Console.WriteLine("Ведено недопустимое значение, пожалуйста повторите ввод:");
                    UInt32.TryParse(Console.ReadLine(), out years);
                }
            }
            return years;
        }
        static void Solution(string name,string name2,uint years,uint years2)
        {
            uint difference;
            string nameverification;
            if (years > years2)
            {               
                nameverification = Console.ReadLine();
                if (nameverification == name)
                {
                    difference = years - years2;
                    Console.WriteLine($"Правильно. Человек по имени {name} старше на {difference} год.");
                }
                else if (nameverification != name && nameverification != name2)
                {
                    Console.WriteLine("Ошибка! Такого имени нет в базе.");
                }
                else if (nameverification != name)
                {
                    difference = years - years2;
                    Console.WriteLine($"Неправильно. Человек по имени {name} старше на {difference} год.");
                }
            }
            else if (years2 > years)
            {
                nameverification = Console.ReadLine();
                if (nameverification != name2 && nameverification != name)
                {
                    while (nameverification != name2 && nameverification != name)
                    {
                        Console.WriteLine("Ошибка! Такого имени нет в базе. Попробуйте ввести еще раз:");
                        nameverification = Console.ReadLine();
                    }
                }
                if (nameverification == name2)
                {
                    difference = years2 - years;
                    Console.WriteLine($"Правильно. Человек по имени {name2} старше на {difference} год .");
                }
                else if (nameverification != name2 && nameverification != name)
                {
                    Console.WriteLine("Ошибка! Такого имени нет в базе.");
                }
                else if (nameverification != name2)
                {
                    difference = years2 - years;
                    Console.WriteLine($"Неправильно. Человек по имени {name2} старше на {difference} год.");
                }
            }
            else if (years == years2)
            {
                Console.WriteLine($"{name} и {name2} ровесники!");
            }           
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя первого человека:");
            string name = CheckName();
            Console.WriteLine("Введите возраст первого человека");
            uint years = CheckAge();
            Console.WriteLine("Введите имя второго человека:");
            string name2 = CheckName();
            Console.WriteLine("Введите возраст второго человека");
            uint years2 = CheckAge();
            Console.WriteLine("Введите имя человека, который по вашему мнению старший:");
            Solution(name,name2,years,years2);
            Console.ReadKey();
        }
    }
}
