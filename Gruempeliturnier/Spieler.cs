using ConsoleTables;
using System;
using System.Collections.Generic;

namespace Gruempeliturnier
{
    internal class Spieler
    {
        public List<Spieler> SpielerList = new System.Collections.Generic.List<Spieler>();

        private string BearbeitenSpieler { get; set; }
        private int transform;
        public int PosOfID { get; set; }
        public static int Count { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Telefonnummer { get; set; }
        public string Strasse { get; set; }
        public string Nummer { get; set; }
        public string Ort { get; set; }
        public string PLZ { get; set; }

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

        public void AdaptPlayer()
        {
            int count = 0;
            var Table = new ConsoleTable("Position", "Vorname", "Name", "Telefonnummer", "Strasse", "Nummer", "Ort", "PLZ");
            Console.WriteLine("Hier die Liste aller Spieler");
            foreach (Spieler item in SpielerList)
            {
                count++;

                Table.AddRow(count, item.Vorname, item.Name, item.Telefonnummer, item.Strasse, item.Nummer, item.Ort, item.PLZ);
            }
            Console.WriteLine(Table);
            Console.WriteLine("Welchen Spieler möchten sie bearbeiten? Bitte geben sie die Entsprechende Position ein");

            Console.WriteLine("Achtung Wenn sie einen Spieler bearbeiten müssen sie alle Attribute neu Setzen");
            BearbeitenSpieler = Console.ReadLine();
            int.TryParse(BearbeitenSpieler, out transform);
            transform = transform - 1;
            SpielerList.RemoveAt(transform);
            var p1 = Spieler.Create();
            SpielerList.Add(p1);

            Console.Clear();
        }

        public void RemovePlayer()
        {
            int count = 0;
            var Table = new ConsoleTable("Position", "Vorname", "Name", "Telefonnummer", "Strasse", "Nummer", "Ort", "PLZ");
            Console.WriteLine("Hier die Liste aller Spieler");
            foreach (Spieler item in SpielerList)
            {
                count++;

                Table.AddRow(count, item.Vorname, item.Name, item.Telefonnummer, item.Strasse, item.Nummer, item.Ort, item.PLZ);
            }
            Console.WriteLine(Table);
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

        public int GetPosOfID(int ID)
        {
            PosOfID = ID - 1;
            return PosOfID;
        }
    }
}