using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using ConsoleTables;

namespace Gruempeliturnier
{
    class Team
    {

        private Spieler Einzelspieler = new Spieler();

        public List<Team> TeamList = new List<Team>();
        public List<Spieler> MemberList = new List<Spieler>();

        string BearbeitenSpieler;
        int transform;
        public string Name { get; set; }
        public int Punkte { get; set; }

        public Team CreateTeam()
        {

            var MemberList = new List<Spieler>();
            Console.WriteLine("Bitte geben sie einen Namen für das Team ein");
            var Name = Console.ReadLine();
            bool breakout = false;
            while (breakout == false)                                                 
            {

                foreach(Spieler spieler in Einzelspieler.SpielerList)
                {
                    var Table = new ConsoleTable("Position", "Vorname", "Name", "Telefonnummer", "Strasse", "Nummer", "Ort", "PLZ");
                    Console.WriteLine("Hier die Liste aller Spieler");
                    foreach (Spieler item in Einzelspieler.SpielerList)
                    {

                                         
                        Table.AddRow(item.ID, item.Vorname, item.Name, item.Telefonnummer, item.Strasse, item.Nummer, item.Ort, item.PLZ);
                    }
                    Console.WriteLine(Table);
                }
                
                Console.WriteLine("Bitte geben sie die Position des Spielers an");
                string Member = Console.ReadLine();
                foreach(Spieler Player in Einzelspieler.SpielerList)
                {
                    if(Member == )
                    {

                    }
                }
            }










            return new Team
            {
                Name = Name,
                MemberList = MemberList
            };
            /*
            Console.WriteLine("Bitte geben sie die Position des Spielers ein, deb sie hinzufuegen möchten");
            var Member = Console.ReadLine();
            int.TryParse(Member, out transform);
            transform = transform - 1;
            foreach (Spieler item in Einzelspieler.SpielerList)
            {
                if (transform == )
                {
                    MemberList.Add(item);
                }
            }
            
            return new Team
            {
                Name = Name,
                MemberList = MemberList
                
            };
            */
        }

        public void AdaptTeam()
        {

        }
        public void RemoveTeam()
        {
            int count = 0;
            var Table = new ConsoleTable("Position", "Name");
            Console.WriteLine("Hier die Liste aller Spieler");
            foreach (Team item in TeamList)
            {
                count++;

                Table.AddRow(count, item.Name);
            }
            Console.WriteLine(Table);
            Console.WriteLine("Welchen Spieler möchten sie bearbeiten? Bitte geben sie die Entsprechende Position ein");

            Console.WriteLine("Achtung Wenn sie einen Spieler bearbeiten müssen sie alle Attribute neu Setzen");
            BearbeitenSpieler = Console.ReadLine();
            int.TryParse(BearbeitenSpieler, out transform);
            transform = transform - 1;
            TeamList.RemoveAt(transform);


            Console.Clear();
        }
    }
    
}
