using ConsoleTables;
using System;
using System.Collections.Generic;

namespace Gruempeliturnier
{
    internal class Spieler
    {
        public List<Spieler> SpielerList = new System.Collections.Generic.List<Spieler>();

        private string BearbeitenSpieler { get; set; }
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

        internal void ReplacePlayerAttibute(string Nummer, string Attribut, string Replacement)
        {
            foreach (Spieler item in SpielerList)
            {
                if (item.ID == Nummer)
                {
                    switch (Attribut)
                    {
                        case "Vorname":
                            item.Vorname = Replacement;
                            break;

                        case "Name":
                            item.Name = Replacement;
                            break;

                        case "Telefonnummer":
                            item.Telefonnummer = Replacement;
                            break;

                        case "Strasse":
                            item.Strasse = Replacement;
                            break;

                        case "Nummer":
                            item.Nummer = Replacement;
                            break;

                        case "Ort":
                            item.Ort = Replacement;
                            break;

                        case "PLZ":
                            item.PLZ = Replacement;
                            break;
                    }
                }
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
            bool breakout = true;
            while (breakout)
            {
                Console.WriteLine("Welches Attribut möchten sie bearbeiten? (nur 1)");
                string CaseSwitch = Console.ReadLine();
                if (CaseSwitch == "ID")
                {
                    Console.WriteLine("Sie dürfen die ID nicht bearbeiten. Möchten sie stadtdessen ein anderes Attribut bearbeiten? y/n");
                    breakout = false;
                }
                Console.WriteLine("Bitte geben sie das neue Attribut ein");
                string replace = Console.ReadLine();
                switch (CaseSwitch)
                {
                    case "Vorname":
                        ReplacePlayerAttibute(BearbeitenSpieler, CaseSwitch, replace);
                        Console.WriteLine("Der Vorname wurde geändert");
                        break;

                    case "Name":
                        ReplacePlayerAttibute(BearbeitenSpieler, CaseSwitch, replace);
                        Console.WriteLine("Der Name wurde geändert");
                        break;

                    case "Telefonnummer":
                        ReplacePlayerAttibute(BearbeitenSpieler, CaseSwitch, replace);
                        Console.WriteLine("Die Telefonnummer wurde geändert");
                        break;

                    case "Strasse":
                        ReplacePlayerAttibute(BearbeitenSpieler, CaseSwitch, replace);
                        Console.WriteLine("Die Strasse wurde geändert");
                        break;

                    case "Hausnummer":
                        ReplacePlayerAttibute(BearbeitenSpieler, CaseSwitch, replace);
                        Console.WriteLine("Die Hausnummer wurde geändert");
                        break;

                    case "Ort":
                        ReplacePlayerAttibute(BearbeitenSpieler, CaseSwitch, replace);
                        Console.WriteLine("Der Ort wurde geändert");
                        break;

                    case "PLZ":
                        ReplacePlayerAttibute(BearbeitenSpieler, CaseSwitch, replace);
                        Console.WriteLine("Die PLZ wurde geändert");
                        break;
                }
                Console.WriteLine("möchten sie ein weiteres Attribut bearbeiten? y/n");
                string condition = Console.ReadLine();
                if (condition == "n")
                {
                    breakout = false;
                }
            }
        }

        public void RemovePlayer()
        {
            Console.WriteLine("Welchen Spieler möchten sie entfernen? Bitte geben sie die Entsprechende ÏD ein");
            BearbeitenSpieler = Console.ReadLine();
            var Temp = new Spieler();
            foreach (Spieler item in SpielerList)
            {
                if (item.ID == BearbeitenSpieler)
                {
                    Temp = item;
                }
            }
            SpielerList.Remove(Temp);

            Console.Clear();
        }
    }
}