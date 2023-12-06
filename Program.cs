using System;
using System.ComponentModel.DataAnnotations;

namespace CorsoCSharp
{


    class Program
    {
        static void Main(string[] args)
        {
            //inizializzazione
            string nome = "Luca";

            //dichiarazione 
            string cognome;

            //assegnazione 
            cognome = "Rossi";

            //riassegnazione 
            nome = "Marco";

            int eta = 19;

           

            Console.WriteLine("Ciao mi chiamo " + nome + cognome + "ed ho " + eta + " anni");
            Console.Read();


        }




    }
}