// See https://aka.ms/new-console-template for more information
namespace Corso
{
    class Program
    {
static void Main(string[] args)
        {
            //Lavorare con le stringhe
            string stringa = "prova";
            string stringb = "citazione:\nsi vive una volta sola "; // \n new line testo a capo
            string stringc = "citazione:\"si vive una volta sola\" "; // \ ...\ fa si che prenda anche gli apici interni

            //format
            string nome = "Luca";
            string cognome = "Rossi";
            Console.WriteLine("buongiorno sono {0} {1}", nome, cognome);
            Console.WriteLine("buongiorno sono {1} {0}", nome, cognome);
            string stringad = string.Format("buongiorno sono {0} {1}", nome, cognome); //metodo alternativo al format per inserirlo in varibile

            //interpolazione
            Console.WriteLine($"buongiorno sono {nome} {cognome}");

            //metodi
            string str = nome.ToLower();//tutto minuscolo
            string str2 = nome.ToUpper();//tutto maiuscolo
            Console.WriteLine(nome.IndexOf("L"));//cercare posizone
            Console.WriteLine(nome.Substring(1));//troncare da una posizione
            Console.WriteLine(nome.Substring(nome.Length-3));//stesso ma al contrario
        }

    }

}
