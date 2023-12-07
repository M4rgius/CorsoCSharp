// See https://aka.ms/new-console-template for more information
namespace Corso
{
    class Program
    {
static void Main(string[] args)
        {
            //casting implicito
            int prova = 345;
            long prova2 = prova;

            //casting esplicito
            double b = 35.26;
            int b2 = (int)b;

            //quando i dati non sono uguali e non possono essere castati utilizziamo i metodi di conversione
            int prova3 = 35;
            double doppio=35.50; //.0 a .49 arrotonda per difetto da .50 per eccesso
            string stringa = Convert.ToString(prova3);

            Console.WriteLine(Convert.ToInt32(doppio));

        }

    }

}
