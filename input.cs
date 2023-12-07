// See https://aka.ms/new-console-template for more information
namespace Corso
{
    class Program
    {
static void Main(string[] args)
        {

            //input
            Console.WriteLine("Inserisci numero 1: ");
            string inputUtente = Console.ReadLine();

            Console.WriteLine("Inserisci numero 2: ");
            string inputUtente2 = Console.ReadLine();
            Console.WriteLine(inputUtente);

            int num1 = int.Parse(inputUtente);
            int num2 = int.Parse(inputUtente2);

            int risultato=num1+ num2;

            Console.WriteLine(risultato);

            Console.Read();

        }

    }

}
