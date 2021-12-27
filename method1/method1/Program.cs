using System;

namespace method1
{
    class Program
    {
        static string PrintMethod()
        {
            Console.WriteLine("Выберите метод для обработки массива \n");
            Console.WriteLine("1. Найти минимальный элемент массива.");
            Console.WriteLine("2. Найти максимальный элемент массива.");
            Console.WriteLine("3. Найти индекс минимального элемента массива.");
            Console.WriteLine("4. Найти индекс максимального элемента массива.");
            Console.WriteLine("5. Посчитать сумму элементов массива с нечетными индексами.");
            Console.WriteLine("6. Сделать реверс массива (массив в обратном направлении).");
            Console.WriteLine("7. Посчитать количество нечетных элементов массива.");
            Console.WriteLine("8. Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2");
            string number = Console.ReadLine();
            return number;
        }
        static void Check(string number, double[] arr)
        {
            switch (number)
            {
                case "1":
                    MinArr(arr);
                    break;
                case "2":
                    MaxArr(arr);
                    break;
                case "3":
                    IndexMinArr(arr);
                    break;
                case "4":
                    IndexMaxArr(arr);
                    break;
                case "5":
                    SumElementNotEven(arr);
                    break;
                case "6":
                    Reverse(arr);
                    break;
                case "7":
                    CountElementNotEven(arr);
                    break;
                case "8":
                    Replacement(arr);
                    break;
            }
        }
        static double[] Array(uint nums)
        {
            double[] arr = new double[nums];
            for (int i = 0; i < nums; i++)
            {
                Console.Write("Введите элементы :");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }
        static void MinArr(double[] arr)
        {
            double min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"Mинимальный элемент массива :{min}");
        }
        static void MaxArr(double[] arr)
        {
            double max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"Максимальный элемент массива :{max}");
        }
        static void IndexMinArr(double[] arr)
        {
            double min = arr[0];
            int index = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    index = i;
                }
            }
            Console.WriteLine($"Индекс минимального элемента массива :{index}");
        }
        static void IndexMaxArr(double[] arr)
        {
            double indexmax = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > indexmax)
                {
                    indexmax = i;
                }
            }
            Console.WriteLine($"Индекс максимального элемента массива :{indexmax}");
        }
        static void SumElementNotEven(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + arr[i];
                }
            }
            Console.WriteLine($"Cумму элементов массива с нечетными индексами :{sum}");
        }
        static void Reverse(double[] arr)
        {
            Console.WriteLine($"Массив в обратном направлении :");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void CountElementNotEven(double[] arr)
        {
            int count = 0;
            foreach (int x in arr)
                if (x % 2 == 1)
                    count++;
            Console.WriteLine("Количество нечетных элементов: " + count);
        }
        static void Replacement(double[] arr)
        {
            Console.WriteLine($"Поменять местами первую и вторую половину массива:");
            int nums;
            nums = arr.Length / 2;
            if (arr.Length % 2 != 0)
            {
                nums++;
            }
            for (int i = nums; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            if (arr.Length % 2 != 0)
            {
                Console.Write(arr[arr.Length / 2]);
            }
            for (int i = 0; i < arr.Length / 2; i++)
            {
                Console.Write(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну массива :");
            uint nums;
            nums = Convert.ToUInt32(Console.ReadLine());
            double[] array = Array(nums);
            string number = PrintMethod();
            Check(number, array);
            Console.ReadKey();
        }
    }
}
    

