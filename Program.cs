using System;
using System.Collections.Generic;
using BakerBee.Models;

namespace BakerBees {
    class Program {
        static void Main (string[] args) {
            Bee honey = new Bee ("Honey-B-Goode", "Honey-Bee", 5, 10);
            Bee max = new Bee ("Wax", "LOL", 3, 6);
            QueenBee beyonce = new QueenBee ("Beyonce", "Queen", 150);

            Console.WriteLine (Bee.NumBees);
            Console.WriteLine (honey.Name);
            Console.WriteLine (honey.Stripes);
            List<Bee> Hive = new List<Bee> ();
            honey.PrintInfo ();
            beyonce.PrintInfo ();
            Hive.Add (honey);
            Hive.Add (max);
            Hive.Add (beyonce);
        }
    }
}