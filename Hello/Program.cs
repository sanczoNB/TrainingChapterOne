using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jak Ci na imię?");
            Console.WriteLine("Napisz tutaj swoje imię: ");
            var imie = Console.ReadLine();
            if (imie.Length == 0)
            {
                Console.Error.WriteLine("\n\n\t*** Błąd: nie podano imienia!\n\n");
                return;
            }
            var niewiasta = (imie.ToLower()[imie.Length - 1] == 'a');
            if (imie == "Kuba" || imie == "Barnaba") niewiasta = false;
            Console.WriteLine("Niech zgadnę, jesteś {0} !", (niewiasta ? "dziewczyną" : "chłopakiem"));
            Console.WriteLine("Naciśnij Enter...");
            Console.In.ReadLine();
        }
    }
}
