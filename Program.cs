using System;
using System.Collections.Generic;
using System.Linq;

namespace DynamicArrayAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = string.Empty;
            List<int> numbers = new List<int>();
            bool isWork = true;

            while (isWork)
            {
                Console.Write($"Введите число или команду (sum, exit) и нажмите Enter: ");

                numbers.ForEach(x => Console.Write(x + ", "));
                userInput = Console.ReadLine();

                const string sum = "sum";
                const string exit = "exit";

                switch (userInput)
                {
                    case sum:
                        Sum(numbers);
                        break;

                    case exit:
                        isWork = false;
                        return;

                    default:
                        try
                        {
                            bool isNumber = int.TryParse(userInput, out int number);

                            if (isNumber == false)
                                throw new NotFiniteNumberException("Ошибка ввода числа. Введите число или команду (sum, exit)\nНажмите любую клавишу и повторите...");

                            Add(numbers, number);
                        }
                        catch (NotFiniteNumberException ex)
                        {
                            Console.Clear();
                            Console.Write($"Ошибка: {ex.Message}");

                            Console.ReadKey();
                        }
                        break;
                }

                Console.Clear();
            }
        }

        public static void Add(List<int> numbers, int number)
        {
            numbers.Add(number);
        }

        public static void Sum(List<int> numbers)
        {
            int sum = numbers.Sum();

            Console.Write($"\n\nСумма равна: {sum}");

            Console.ReadKey();

            numbers.Clear();
        }
    }
}
