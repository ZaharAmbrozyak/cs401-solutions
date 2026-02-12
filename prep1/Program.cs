using System;

namespace prep1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            void Calculator()
            {
                Console.WriteLine("Введіть перше число: ");
                double.TryParse(Console.ReadLine(), out double number1);
            
                Console.WriteLine("Введіть друге число: ");
                double.TryParse(Console.ReadLine(), out double number2);
            
                Console.WriteLine("Введіть операцію: ");
                string operation = Console.ReadLine();
                
                double result = 0;
                
                switch (operation)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        if (number2 != 0)
                        {
                            result = number1 / number2;
                        }
                        else
                        {
                            Console.WriteLine("You can't divide by zero!");
                            result = -1;
                        }

                        break;
                    default:
                        Console.WriteLine("Unknown operation.");
                        result = -1;
                        break;
                }

                Console.WriteLine($"{number1} {operation} {number2} = {result}");
            }
            // Calculator

            void GuessTheNumber()
            {
                Random rand = new Random();
                int number = rand.Next(1, 101);
                Console.WriteLine("Вгадайте число від 1 до 100!");
                int guess = 0, tries = 0;
                while (number != guess)
                {
                    Console.WriteLine("Введіть число: ");
                    int.TryParse(Console.ReadLine(), out guess);
                    if (guess > number)
                    {
                        Console.WriteLine("Беріть менше число!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine("Беріть більше число!");
                    }

                    tries++;
                }

                Console.WriteLine($"Перемога! Загадане число: {number}, кількість спроб: {tries}!");
            }
            // GuessTheNumber();
            void ArrayWork()
            {
                Console.WriteLine("Введіть розмірність масиву: ");
                int.TryParse(Console.ReadLine(), out int n);
                int[] numbers = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Введіть число №{i}: ");
                    int.TryParse(Console.ReadLine(), out int number);
                    numbers[i] = number;
                }

                int min = int.MaxValue, max = int.MinValue, sum = 0;
                double avg;
                foreach (int num in numbers)
                {
                    if (min > num)
                    {
                        min = num;
                    }
                    if (max < num)
                    {
                        max = num;
                    }
                    sum += num;
                }

                avg = (double)sum / n;
                Console.WriteLine($"Найбільше число: {max}, Найменше число: {min}, Середнє: {avg}");
            }
            // ArrayWork();
            string PalindromCheck()
            {
                Console.WriteLine("Введіть текст для перевірки: ");
                string text = Console.ReadLine();
                for (int i = 0; i < text.Length / 2; i++)
                {
                    if (text[i] != text[text.Length - i - 1])
                    {
                        return "Не паліндром";
                    }
                }
                return "Паліндром";
            }
            // Console.WriteLine(PalindromCheck());
        }
    }
}