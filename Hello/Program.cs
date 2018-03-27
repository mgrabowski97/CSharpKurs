using System;

namespace Hello
{
    class Program
    {

        static void Main(string[] args)

        { 
            for (; ;)
            {
                Przywitanie();

                Wiek();

                Ustawienia();

            }
        }

        

        /// <summary>
        /// Ustawienia
        /// </summary>
        private static void Ustawienia()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        /// <summary>
        /// Wypisujemy komunikat zależny od wpisanego wieku / sprawdzamy czy wiek został podany w poprawny sposób
        /// </summary>
        private static void Wiek()
        {
            Console.Write("Ile masz lat przyjacielu?: ");
            int wiek;
            bool result = int.TryParse(Console.ReadLine(), out wiek);


            if (wiek > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Brawo, jesteś pełnoletni więc możemy przejść do dalszej części naszej ankiety ");
            }
            else if (result == false)
            {
                Console.WriteLine("Wprowadziłeś niepoprawny wiek. ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Przykro mi ale nie jesteś pełnoletni więc" +
                    " nie możesz brać dalszego udziału w ankiecie");
            }
        }

        /// <summary>
        /// Wypisujemy powitanie użytkownika
        /// </summary>
        private static void Przywitanie()
        {
            Console.Write("Witam Cię, jak sie nazywasz?: ");
            string name = Console.ReadLine();
            Console.WriteLine("Witaj, " + name);
        }
    }
}


