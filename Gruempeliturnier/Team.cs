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
        public string TeamID { get; set; }
        public string Punkte { get; set; }

        int TeamCount;

        public Team CreateTeam()
        {
            
            var MembList = new List<Spieler>();
            Console.WriteLine("Bitte geben sie einen Namen für das Team ein");
            var Name = Console.ReadLine();
            TeamCount++;

            return new Team
            {
                Name = Name,
                TeamID = TeamCount.ToString(),
                MemberList = MembList
            };

        }

        public void ShowTeamList()
        {
            var Table = new ConsoleTable("ID", "Name");
            Console.WriteLine("Hier die Liste aller Teams");
            foreach (Team item in TeamList)
            {

                Table.AddRow(item.TeamID, item.Name);
            }
            Console.WriteLine(Table);
        }

        public void FillTeam()
        {
            Team selected = new Team();
            ShowTeamList();
            Console.WriteLine("Bitte nennen sie die TeamID");
            string ZSpeicherTID = Console.ReadLine();
            foreach (Team item in TeamList)
            {
                if (ZSpeicherTID == item.TeamID)
                {
                    selected = item;
                }
            }
            Einzelspieler.ShowPlayerList();
            Console.WriteLine("Bitte geben sie die ID des Spielers ein, den sie hinzufügen möchten");
            string PlayerID = Console.ReadLine();
            foreach (Spieler Player in Einzelspieler.SpielerList)
            {
                if(Player.ID == PlayerID)
                {
                    selected.MemberList.Add(Player);
                }
            }
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
