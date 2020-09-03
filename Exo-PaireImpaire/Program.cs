using System;

namespace Exo_PaireImpaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez introduire un nombre:");
            if(int.TryParse(Console.ReadLine(), out int number))
            {
                if((number/2) + (number/2) == number)
                    Console.WriteLine("Votre nombre est pair.");
                else
                    Console.WriteLine("votre nombre est impair.");
            }
            else
                Console.WriteLine("Tu ne sais pas lire, on a dis un nombre!");
        }
    }
}
