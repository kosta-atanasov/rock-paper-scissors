namespace rock_papeр_scissors
{
    using System;

    class Program
    {
        static void Main()
        {
            string[] options = { "Камък", "Ножица", "Хартия" };
            Random random = new Random();

            while (true)
            {
                Console.WriteLine("Изберете: Камък, Ножица или Хартия (или напишете 'изход' за край)");
                string userChoice = Console.ReadLine();

                if (userChoice.Equals("изход", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Благодаря за играта! Довиждане!");
                    break;
                }

                if (!Array.Exists(options, option => option.Equals(userChoice, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine("Невалиден избор. Моля, опитайте отново.");
                    continue;
                }
                string computerChoice = options[random.Next(options.Length)];
                Console.WriteLine($"Компютърът избра: {computerChoice}");

                string result = DetermineWinner(userChoice, computerChoice);
                Console.WriteLine(result);
               
                Console.WriteLine();

            }
        }

        static string DetermineWinner(string user, string computer)
        {
            if (user.Equals(computer, StringComparison.OrdinalIgnoreCase))
            {
                return "Равенство!";
            }

            if ((user.Equals("Камък", StringComparison.OrdinalIgnoreCase) && computer.Equals("Ножица", StringComparison.OrdinalIgnoreCase)) ||
                (user.Equals("Ножица", StringComparison.OrdinalIgnoreCase) && computer.Equals("Хартия", StringComparison.OrdinalIgnoreCase)) ||
                (user.Equals("Хартия", StringComparison.OrdinalIgnoreCase) && computer.Equals("Камък", StringComparison.OrdinalIgnoreCase)))
            {
                return "Вие печелите!";
            }
            else
            {
                return "Компютърът печели!";
            }
            
        }
    }
}