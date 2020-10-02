using System;

namespace Gruempeliturnier
{
    internal class Menu
    {
        //Files aus einem Programm heraus erstellen und Füllen
        //File.WriteAllText(@"C:\Users\svenw\Documents\bla.txt", test);

        private string Eingabe;
        private Team Teams = new Team();
        private Spieler spieler = new Spieler();

        internal void Menue()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Was möchten sie tun?");
                Console.WriteLine("1:Spieleroptionen");
                Console.WriteLine("2:Teamoptionen");
                Console.WriteLine("3:Spielstarten");
                Console.WriteLine("4:Programm beenden");
                Eingabe = Console.ReadLine();

                switch (Eingabe)
                {
                    case "1":
                        Player();
                        break;

                    case "2":
                        Team();
                        break;

                    case "3":
                        Game();
                        break;

                    case "4":
                        return;
                }
            }
        }

        internal void Player()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Was möchten sie tun?");
                Console.WriteLine("1:SielerListe anzeigen");
                Console.WriteLine("2:Spieler Hinzufuegen");
                Console.WriteLine("3:Spieler Bearbeiten");
                Console.WriteLine("4:Spieler Entfernen");
                Console.WriteLine("5:Zurück zum Hauptnemu");
                Console.WriteLine("6:Programm beenden");
                Eingabe = Console.ReadLine();

                switch (Eingabe)
                {
                    case "1":
                        Console.Clear();
                        spieler.ShowPlayerList();
                        break;

                    case "2":
                        Console.Clear();
                        spieler.CreatePlayer();
                        break;

                    case "3":
                        Console.Clear();
                        spieler.ChangePlayer();
                        break;

                    case "4":
                        Console.Clear();
                        spieler.ShowPlayerList();
                        spieler.RemovePlayer();
                        break;

                    case "5":
                        Console.Clear();
                        Menue();
                        break;

                    case "6":
                        return;
                }
            }
        }

        internal void Team()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Was möchten sie tun?");
                Console.WriteLine("1:Teamliste anzeigen");
                Console.WriteLine("2:Ein Team Erstellen");
                Console.WriteLine("3:Spieler einem Team Hinzufügen");
                Console.WriteLine("4:Spieler aus einem Team entfernen");
                Console.WriteLine("5:Team Entfernen");
                Console.WriteLine("6:Zurück zum Hauptmenu");
                Console.WriteLine("7:Programm Beenden");
                Eingabe = Console.ReadLine();

                switch (Eingabe)
                {
                    case "1":
                        Console.Clear();
                        Teams.ShowTeamList();
                        break;

                    case "2":
                        Console.Clear();
                        Teams.CreateTeam();
                        break;

                    case "3":
                        Console.Clear();
                        Teams.FillTeam();
                        break;

                    case "4":
                        Console.Clear();
                        Teams.RemoveFromTeam();
                        break;

                    case "5":
                        Console.Clear();
                        Teams.RemoveTeam();
                        break;

                    case "6":
                        Console.Clear();
                        Menue();
                        break;

                    case "7":
                        return;
                }
            }
        }

        internal void Game()
        {
            Console.WriteLine("Was möchten sie tun?");
            Console.WriteLine("9:Spiel Starten");
        }
    }
}