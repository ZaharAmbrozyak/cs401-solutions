using System;

namespace practice1
{
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("Введіть текст: ");
            string text = Console.ReadLine();
            Dictionary<string, int> output = new Dictionary<string, int>();
            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                if (output.ContainsKey(word))
                {
                    output[word] += 1;
                }
                else
                {
                    output[word] = 1;
                }
            }

            foreach (KeyValuePair<string, int> wordQuantity in output)
            {
                Console.WriteLine($"{wordQuantity.Key} - {wordQuantity.Value}");
            }
        }

        static void Task2()
        {
            string CheckGuess(int secret, int guess)
            {
                string output;
                if (guess > secret)
                {
                    output = "Ваше число більше за те, яке ви вгадуєте";
                }
                else if (guess < secret)
                {
                    output = "Ваше число менше за те, яке ви вгадуєте";
                }
                else
                {
                   output = "Ви вгадали число!";
                }

                return output;
            }
            
            Random rand = new Random();
            
            int secret = rand.Next(1, 101);
            int guess = 0, tries = 0;
            
            Console.WriteLine("Вгадайте число, яке в проміжку від 1 до 100!");
            do
            {
                Console.WriteLine("Введіть число: ");
                int.TryParse(Console.ReadLine(), out guess);
                Console.WriteLine(CheckGuess(secret, guess));
                tries++;
            } while (secret != guess);
            
            Console.WriteLine($"Кількість витрачених спроб: {tries}");
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }
    }
}