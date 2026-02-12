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
        static void Main(string[] args)
        {
            Task1();
        }
    }
}