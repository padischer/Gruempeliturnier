using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace Gruempeliturnier
{
    class Program
    {
        static void Main(string[] args)
        {
            string Eingabe;

            var spielerlist = new Spieler();

            Console.WriteLine("Was möchten sie tun?");
            Console.WriteLine("1:Spieler Hinzufuegen");
            Console.WriteLine("2:Spieler Bearbeiten");
            Console.WriteLine("3:Spieler Entfernen");
            Console.WriteLine("4:Team Zusammenstellen");
            Console.WriteLine("5:Team bearbeiten");
            Console.WriteLine("6:Spiel spielen");
            Eingabe = Console.ReadLine();
            if(Eingabe == "1")
            {
                var p1 = Spieler.Create();
                spielerlist.SpielerList.Add(p1);
            }
            if (Eingabe == "x")
            {
                // Create Team with Player
            }

            if(Eingabe == "2")
            {
                foreach(Spieler Player in spielerlist.SpielerList)
                {
                    Console.WriteLine(Player);
                }
            }

            if(Eingabe == "3")
            {
                
            }




            Console.ReadKey();
        }
    
    }
}
