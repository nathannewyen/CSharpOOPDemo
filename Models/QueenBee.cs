using System;

namespace BakerBee.Models {
    public class QueenBee : Bee {
        public QueenBee (string name, string type, int stripes) : base (name, type, stripes, 100) { }
        public override void PrintInfo () {
            Console.WriteLine ($"{Name} is the Queen");
            base.PrintInfo ();
        }
    }
}