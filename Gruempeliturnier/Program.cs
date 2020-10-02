using System;

namespace Gruempeliturnier
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Files aus einem Programm heraus erstellen und Füllen
            //File.WriteAllText(@"C:\Users\svenw\Documents\bla.txt", test);

            string Eingabe;
            var Teams = new Team();
            var spieler = new Spieler();
            while (true)
            {
                Console.WriteLine("Was möchten sie tun?");
                Console.WriteLine("1:Spieler Hinzufuegen");
                Console.WriteLine("2:Spieler Bearbeiten");
                Console.WriteLine("3:Spieler Entfernen");
                Console.WriteLine("4:Erstellen");
                Console.WriteLine("5:Spieler einem Team Hinzufügen");
                Console.WriteLine("6:Spieler aus einem Team entfernen");
                Console.WriteLine("7:Team Entfernen");
                Console.WriteLine("8:Programm beenden");
                Eingabe = Console.ReadLine();
                if (Eingabe == "1")
                {
                    var p1 = spieler.CreatePlayer();
                    spieler.SpielerList.Add(p1);

                    Console.Clear();
                }

                if (Eingabe == "2")
                {
                    spieler.ChangePlayer();
                    Console.Clear();
                }

                if (Eingabe == "3")
                {
                    spieler.RemovePlayer();
                }
                if (Eingabe == "4")
                {
                    var t1 = Teams.CreateTeam();
                    Teams.TeamList.Add(t1);
                }
                if (Eingabe == "5")
                {

                }
                if (Eingabe == "6")
                {

                }
                if (Eingabe == "7")
                {
                }
                if (Eingabe == "8")
                {
                    return;
                }
            }

            Console.ReadKey();
        }
    }
}