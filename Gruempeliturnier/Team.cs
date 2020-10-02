using ConsoleTables;
using System;
using System.Collections.Generic;

namespace Gruempeliturnier
{
    internal class Team
    {
        private Spieler Einzelspieler = new Spieler();

        public List<Team> TeamList = new List<Team>();
        public List<Spieler> MemberList = new List<Spieler>();

        private string BearbeitenSpieler;
        private int transform;
        public string Name { get; set; }
        public string TeamID { get; set; }
        public string Punkte { get; set; }

        private int TeamCount;

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
            var selected = SearchTeam();
            Einzelspieler.ShowPlayerList();
            Console.WriteLine("Bitte geben sie die ID des Spielers ein, den sie hinzufügen möchten");
            string PlayerID = Console.ReadLine();
            foreach (Spieler Player in Einzelspieler.SpielerList)
            {
                if (Player.ID == PlayerID)
                {
                    selected.MemberList.Add(Player);
                }
            }
        }

        internal void RemoveFromTeam()
        {
            ShowTeamList();
            var selected = SearchTeam();
            var Table = new ConsoleTable("ID", "Vorname", "Name", "Telefonnummer", "Strasse", "Nummer", "Ort", "PLZ");
            Console.WriteLine("Hier die Liste aller Spieler");
            foreach (var player in selected.MemberList)
            {
                Table.AddRow(player.ID, player.Vorname, player.Name, player.Telefonnummer, player.Strasse, player.Nummer, player.Ort, player.PLZ);
            }

            Console.WriteLine("Hier die Liste aller Spieler in diesem Team");
            Einzelspieler.RemovePlayer();
        }

        public void RemoveTeam()
        {
            ShowTeamList();
            Console.WriteLine("Welchen Spieler möchten sie bearbeiten? Bitte geben sie die Entsprechende Position ein");
            BearbeitenSpieler = Console.ReadLine();
            int.TryParse(BearbeitenSpieler, out transform);
            transform = transform - 1;
            TeamList.RemoveAt(transform);

            Console.Clear();
        }

        internal Team SearchTeam()
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

            return selected;
        }
    }
}