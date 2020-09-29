using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Gruempeliturnier
{
    class Spieler
    {
        public List<Spieler> SpielerList = new System.Collections.Generic.List<Spieler>();

        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Telefonnummer { get; set; }

        public  string Strasse { get; set; }
        public string Nummer { get; set; }
        public string Ort { get; set; }
        public string PLZ { get; set; }

        public void AddPlayer()
        {
            

            Console.WriteLine("Bitte geben sie den Vornamen des spielers ein");
            Vorname = Console.ReadLine();
            Console.WriteLine("Bitte geben sie den Namen des spielers ein");
            Name = Console.ReadLine();
            Console.WriteLine("Bitte geben sie die Telefonnummer des spielers ein");
            Telefonnummer = Console.ReadLine();
            Console.WriteLine("Bitte geben sie den Strassennahmen vom Wohnort des spielers ein");
            Strasse = Console.ReadLine();
            Console.WriteLine(" Bitte geben sie die Hausnummer des Spielers ein");
            Nummer = Console.ReadLine();
            Console.WriteLine("Bitte geben sie Den Wohnort des Spielers ein");
            Ort = Console.ReadLine();
            Console.WriteLine("Bitte geben sie den Namen des spielers ein");
            PLZ = Console.ReadLine();
        }

        internal static Spieler Create()
        {

            Console.WriteLine("Bitte geben sie den Vornamen des spielers ein");
            var Vorname = Console.ReadLine();
            Console.WriteLine("Bitte geben sie den Namen des spielers ein");
            var Name = Console.ReadLine();
            Console.WriteLine("Bitte geben sie die Telefonnummer des spielers ein");
            var Telefonnummer = Console.ReadLine();
            Console.WriteLine("Bitte geben sie den Strassennahmen vom Wohnort des spielers ein");
            var Strasse = Console.ReadLine();
            Console.WriteLine(" Bitte geben sie die Hausnummer des Spielers ein");
            var Nummer = Console.ReadLine();
            Console.WriteLine("Bitte geben sie Den Wohnort des Spielers ein");
            var Ort = Console.ReadLine();
            Console.WriteLine("Bitte geben sie die PLZ vom Wohnort des spielers ein");
            var PLZ = Console.ReadLine();


            return new Spieler
            {
                Vorname = Vorname,
                Name = Name,
                Telefonnummer = Telefonnummer,
                Strasse = Strasse,
                Nummer = Nummer,
                Ort = Ort,
                PLZ = PLZ
            };
        }

    }
}
