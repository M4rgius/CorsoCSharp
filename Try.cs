// See https://aka.ms/new-console-template for more information
namespace Corso
{
    class Program
    {
static void Main(string[] args)
        {

          //Try&Catch
            Console.WriteLine("Inserisci numero 1: ");
            string inputUtente = Console.ReadLine();
            int num1 = 0;
            try//prova ad eseguire il blocco
            {
                num1 = int.Parse(inputUtente);
            }
            catch (FormatException)//gestisci l'errore
            {

               Console.WriteLine("Inserisci un numero valido");
            }
            catch(OverflowException) 
            {
                Console.WriteLine("Il numero non deve essere long");
            }
            finally//esegui chiusura a priori
            {
                Console.WriteLine("Lo scrivo a prescindere");
            }
             Console.WriteLine(num1+2);

            Console.Read();

        }

    }

}
