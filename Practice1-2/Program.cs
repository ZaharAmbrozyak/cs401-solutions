using System.Linq;

namespace Week2.project
{
    internal class Program
    {
        static string getText()
        {
            Console.WriteLine("Введіть текст:");
            string text = "", line;
            do
            {
                line = Console.ReadLine();
                text = text + " " + line;
            } while (line != "");

            return text;
        }

        static void task123(string text)
        {
            int charCount = text.Length;
            string[] words = text.Split(new char[] { ' ', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;
            int sentenceCount = 0;
            foreach (char c in text)
            {
                if (c == '.' || c == '!' || c == '?')
                {
                    sentenceCount++;
                }
            }
            Console.WriteLine("Characters: " + charCount);
            Console.WriteLine("Words: " + wordCount);
            Console.WriteLine("Sentences: " + sentenceCount);
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (string w in words)
            {
                string word = w.ToLower();

                if (dict.ContainsKey(word))
                {
                    dict[word] = dict[word] + 1;
                }
                else
                {
                    dict[word] = 1;
                }
            }
            Console.WriteLine("Top 5 words:");
            for (int i = 0; i < 5; i++)
            {
                string maxWord = "";
                int max = 0;
                foreach (var pair in dict)
                {
                    if (pair.Value > max)
                    {
                        max = pair.Value;
                        maxWord = pair.Key;
                    }
                }
                if (maxWord == "")
                {
                    break;
                }
                Console.WriteLine(maxWord + " - " + max);
                dict.Remove(maxWord);
            }
            int total = 0;

            foreach (string w in words)
            {
                total = total + w.Length;
            }
            double average = 0;
            if (wordCount > 0)
            {
                average = (double)total / wordCount;
            }
            Console.WriteLine("Average word length: " + average);
        }
        static void task4(string text)
        {
            string[] symbols = new string[] { ".", "!", "?" };

            string[] sentences = text.Split(symbols, StringSplitOptions.RemoveEmptyEntries); // другий аргумент щоб прибрати пусті рядочки.
            string sentence;
            int max = -1, min = int.MaxValue, max_i = 0, min_i = 0;
            
            for (int i = 0; i < sentences.Length; i++)
            {
                sentence = sentences[i];
                string[] words = sentence.Split(" ");
                if (max < words.Length)
                {
                    max = words.Length;
                    max_i = i;
                }
                else if (min > words.Length)
                {
                    min = words.Length;
                    min_i = i;
                }
            }
            Console.WriteLine($"Найдовше речення: {sentences[max_i]}");
            Console.WriteLine($"Найменше речення: {sentences[min_i]}");
        }

        static void task5(string text, string searchFor, string replaceWith)
        {
            text = text.Replace(searchFor, replaceWith, StringComparison.OrdinalIgnoreCase); // ігноруєм регістр.
            
            Console.WriteLine(text);
        }

        static void task6(string text)
        {
            string[] symbols = new string[] { ".", "!", "?" };

            string[] sentences = text.Split(symbols, StringSplitOptions.RemoveEmptyEntries); // другий аргумент щоб прибрати пусті рядочки.
            foreach (string sentence in sentences)
            {
                string[] words = sentence.Split(" ");

                Array.Reverse(words);

                Console.WriteLine(string.Join(" ", words).Trim() + ".");
            }
        }
        static void Main(string[] args)
        {

            string text = getText();
            
            task123(text);
            task4(text);
            
            Console.WriteLine("Введіть слово, яке потрібно замінити: ");
            string searchFor = Console.ReadLine();
            
            Console.WriteLine("Введіть слово, на яке ми зробимо заміну: ");
            string replaceWith = Console.ReadLine();
            
            task5(text, searchFor, replaceWith);
            task6(text);
        }
    }
}
