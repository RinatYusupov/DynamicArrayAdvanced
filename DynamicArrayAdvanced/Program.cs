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
            bool isWork = userInput != "exit";

            while (isWork)
            {
                Console.Write($"Введите число или команду (sum, exit) и нажмите Enter: ");

                numbers.ForEach(x => Console.Write(x + ", "));
                userInput = Console.ReadLine();
                bool isNumber = int.TryParse(userInput, out int number);

                if (isNumber)
                    numbers = Add(numbers, number);

                else if (userInput == "sum")
                    Sum(numbers);

                else if (userInput == "exit")
                    isWork = false;

                else
                {
                    Console.Clear();
                    Console.Write("Введите числа или команды (sum, exit)\nНажмите любую клавишу и повторите...");

                    Console.ReadKey();
                }

                Console.Clear();
            }
        }

        public static List<int> Add(List<int> numbers, int number)
        {
            numbers.Add(number);
            return numbers;
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
