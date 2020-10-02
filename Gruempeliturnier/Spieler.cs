using ConsoleTables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Gruempeliturnier
{
    internal class Spieler
    {
        public List<Spieler> SpielerList = new System.Collections.Generic.List<Spieler>();

        
        private string BearbeitenSpieler { get; set; }
        private int transform;
        public string SaveID { get; set; }
        public static int Count { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Telefonnummer { get; set; }
        public string Strasse { get; set; }
        public string Nummer { get; set; }
        public string Ort { get; set; }
        public string PLZ { get; set; }
        public string Change { get; set; }

        internal void ShowPlayerList()
        {
            var Table = new ConsoleTable("ID", "Vorname", "Name", "Telefonnummer", "Strasse", "Nummer", "Ort", "PLZ");
            Console.WriteLine("Hier die Liste aller Spieler");
            foreach (Spieler item in SpielerList)
            {

                Table.AddRow(item.ID, item.Vorname, item.Name, item.Telefonnummer, item.Strasse, item.Nummer, item.Ort, item.PLZ);
            }
            Console.WriteLine(Table);
        }

        internal void SearchPlayer(string Nummer, string Attribut, string Replacement)
        {

            foreach (Spieler item in SpielerList)
            {
                if (item.Nummer == BearbeitenSpieler) ;
                

            }
        }

        internal Spieler CreatePlayer()
        {
            Console.WriteLine("Bitte geben sie den Vornamen des spielers ein");
            var Vorname = Console.ReadLine();
            Console.WriteLine("Bitte geben sie den Namen des spielers ein");
            var Name = Console.ReadLine();
            Console.WriteLine("Bitte geben sie die Telefonnummer des spielers ein");
            var Telefonnummer = Console.ReadLine();
            Console.WriteLine("Bitte geben sie den Strassennahmen vom Wohnort des spielers ein");
            var Strasse = Console.ReadLine();
            Console.WriteLine("Bitte geben sie die Hausnummer des Spielers ein");
            var Nummer = Console.ReadLine();
            Console.WriteLine("Bitte geben sie Den Wohnort des Spielers ein");
            var Ort = Console.ReadLine();
            Console.WriteLine("Bitte geben sie die PLZ vom Wohnort des spielers ein");
            var PLZ = Console.ReadLine();
            Count++;

            return new Spieler
            {
                ID = Count.ToString(),
                Vorname = Vorname,
                Name = Name,
                Telefonnummer = Telefonnummer,
                Strasse = Strasse,
                Nummer = Nummer,
                Ort = Ort,
                PLZ = PLZ
            };
        }

        public void ChangePlayer()
        {
            ShowPlayerList();
            Console.WriteLine("Welchen Spieler möchten sie bearbeiten? Bitte geben sie die Entsprechende ID ein");
            BearbeitenSpieler = Console.ReadLine();
            bool breakout = false;
            while (breakout = false)
            {
                Console.WriteLine("Welches Attribut möchten sie bearbeiten? (nur 1)");
                string CaseSwitch= Console.ReadLine();
                bool truth;
                switch (CaseSwitch)
                {
                    case "ID":
                        Console.WriteLine("Die ID kann nicht bearbeitet werden");
                        break;
                    case "Vorname":
                        
                        Console.WriteLine("Der Vorname wurde geändert");
                        break;
                }
                var p1 = CreatePlayer();
                SpielerList.Add(p1);

            }
        }

        public void RemovePlayer()
        {
            ShowPlayerList();
            Console.WriteLine("Welchen Spieler möchten sie entfernen? Bitte geben sie die Entsprechende Position ein");
            BearbeitenSpieler = Console.ReadLine();
            int.TryParse(BearbeitenSpieler, out transform);
            transform = transform - 1;
            SpielerList.RemoveAt(transform);

            Console.Clear();
        }

        public void adaptList()
        {
            int countList = 0;
            foreach (Spieler Player in SpielerList)
            {
                countList++;
                while (Player.ID != countList.ToString())
                {
                    int PlayerIDInt;

                    int.TryParse(Player.ID, out PlayerIDInt);
                    PlayerIDInt = PlayerIDInt - 1;
                    Player.ID = PlayerIDInt.ToString();
                }
            }
        }


    }
}