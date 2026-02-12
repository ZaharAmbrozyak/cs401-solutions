using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, C#!");
            
            int a = 1; // Comment

            var age = 20;
            var her_name = "Alice";
            // age = "twenty"; lol you can't
            const double Pi = 3.14159;
            // Pi = 3.14 - lol you can't
            byte level = 255;
            int score = 100000;
            long timestamp = 1707070707707070L;

            int b = 3;
            int div = a / b;
            int mod = a % b;

            a++;
            b--;

            int bitwiseAnd = a & b;
            int shifted = a << 1;

            double d1 = 0.1, d2 = 0.2;
            Console.WriteLine(d1 + d2 == 0.3); // False

            decimal p1 = 0.1m, p2 = 0.2m;
            Console.WriteLine(p1 + p2 == 0.3m); // True

            float velocity = 10.5f;

            bool isValid = true;
            bool isNew = false;
            bool result = isValid && !isNew; // true
            bool either = isValid || isNew; // true

            char letter = 'A';
            string s = "Hello C#";

            string lower = s.ToLower(); // .lower()
            bool has = s.Contains("C#"); // "C#" in s
            string sub = s.Substring(0, 5); // s[0:5]

            string name = "Dmytro";
            string greeting = "Hi, " + name; // Конкатенація
            string modern = $"Hi, {name}!"; // інтерполяція

            long big = 100;
            int small = (int)big;

            string input = "42";
            int my_number = int.Parse(input); // int("42")
            double val = double.Parse("3,14"); // float("3.14")

            
            if (int.TryParse("123", out int res))
            {
                Console.WriteLine("done" + res);
            }

            int my_age = 20;
            if (age >= 18)
            {
                Console.WriteLine("Access allowed");
            }
            else if (age == 17)
            {
                Console.WriteLine("One more year pal");
            }
            else
            {
                Console.WriteLine("Access denied");
            }

            string status = (my_age >= 18) ? "Adult" : "Minor";

            string day = "Monday";
            switch (day)
            {
                case "Monday":
                    Console.WriteLine("Start of the week");
                    break;
                case "Saturday":
                case "Friday":
                    Console.WriteLine("End of the week");
                    break;
                default:
                    Console.WriteLine("Casual day");
                    break;
            }

            List<string> courses = new List<string> { "CS401", "SE100", "CS200" };
            foreach (string course in courses)
            {
                Console.WriteLine($"I love {course}");
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Iteration: {i}");
            }

            int count = 0;
            while (count < 3)
            {
                // may not work
                Console.WriteLine(count);
                count++;
            }

            do
            {
                // this code works at least one time
                Console.WriteLine("Done!");
            } while (false);

            List<string> students = new List<string>();
            
            students.Add("Oleksii"); // .append()
            students.AddRange(new[] { "Artem", "Ivan" }); // .extend()
            students.Remove("Ivan"); // .remove()
            students.Insert(0, "Hanna"); // .insert()

            bool hasIvan = students.Contains("Ivan"); // "Ivan" is in students
            int another_count = students.Count;

            int[] numbers = new int[3];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;

            string[] cars = { "Volvo", "BMW", "Tesla" };
            int length = cars.Length; // 3 

            Dictionary<string, int> ages = new Dictionary<string, int>()
            {
                { "Alice", 25 },
                { "Bob", 30 }
            };

            ages["Charlie"] = 35;
        } 
    }
}