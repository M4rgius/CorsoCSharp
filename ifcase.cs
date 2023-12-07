// See https://aka.ms/new-console-template for more information
namespace Corso
{
    class Program
    {
        static void Main(string[] args)
        {

            //if case

            Console.WriteLine("Inserisci il numero 1: ");
            string input1=Console.ReadLine();

            Console.WriteLine("Inserisci il numero 2: ");
            string input2= Console.ReadLine();

            int num1=int.Parse(input1);
            int num2=int.Parse(input2);    

            if (num1 > num2)
            {
                Console.WriteLine("A maggiore di B");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("A minore di B");
            }
            else
            {
                Console.WriteLine("A uguale a B");

            }

        }

    }
}
