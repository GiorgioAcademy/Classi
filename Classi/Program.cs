using System;

namespace Classi
{
    class Program
    {
        static string OttieniDati(Persona p)
        {
            return p.Nome + ' ' + p.Cognome;
        }

        static void Main(string[] args)
        {
            Persona p = new Persona("Pino", "Pini", new DateTime(2000, 5, 7));

            //p.Cognome = "Pini";
            //p.Nome = "Pino";

            // p.Nome = "hkjhkjhkjh";

            string n = p.Nome;
            // p.Cognome = "lkjklj";

            Persona p2 = new Persona("Gina", "Gini", new DateTime(1995, 3, 28));

            //p2.Cognome = "Gini";
            //p2.Nome = "Gina";

            Persona p3 = p;

            Console.WriteLine(Persona.Conteggio);

            //Console.WriteLine(OttieniDati(p));
            //Console.WriteLine(OttieniDati(p2));

            Console.WriteLine(p.DatiAnagrafici);
            Console.WriteLine(p2.DatiAnagrafici);
        }
    }
}
