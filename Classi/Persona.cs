using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    class Persona
    {
        // membri della classe: campi, metodi

        // costruttore
        // metodo che permette di inizializzare opportunamente l'oggetto che si sta creando

        // in mancanza di costruttori specifici ho a disposizione un costruttore
        // senza parametri (default constructor)
        public Persona(string nome, string cognome, DateTime dataDiNascita)
        {
            Nome = nome;        // sto inizializzando i membri
            Cognome = cognome;  // e posso farlo anche su proprietà di sola lettura
            DataDiNascita = dataDiNascita;

            Conteggio++;
        }

        public static int Conteggio { get; set; }  // membro di classe grazie alla parola static


        // proprietà
        public string Nome  // membri di istanza
        {
            get 
            {
                return _nome;
            }
            private set
            {
                if (value == null || value.Length == 0)
                    throw new ArgumentNullException("Nome", "Il nome non può essere nullo o vuoto");

                _nome = value;
            }
        }

        private string _nome;     // l'accessibilità private è il default
                                  // backing field

        public string Cognome { get; }  // implicitly defined property

        public DateTime DataDiNascita { get; }

////        public string OttieniDatiAnagrafici()   // metodo
//        {
//            return Nome + ' ' + Cognome;
//        }

        public string DatiAnagrafici    // proprietà
        {
            get { return Nome + ' ' + Cognome + ' ' + Eta; }
        }

        public int Eta  // come proprietà implemento il calcolo dell'età
        {
            get 
            {
                // calcolo approssimato dell'età
                return DateTime.Today.Year - DataDiNascita.Year;
            }
        }
    }
}
