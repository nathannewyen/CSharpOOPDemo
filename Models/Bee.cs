using System;

namespace BakerBee.Models {
    public class Bee {

        public string Name;
        public string Type;
        private int stripes;
        public int Stripes {
            get {
                return stripes;
            }
        }
        public int Spelling;
        public static int NumBees = 0;
        public Bee (string name, string type, int stripes, int spelling) {
            Name = name;
            Type = type;
            this.stripes = stripes;
            Spelling = spelling;
            NumBees++;
        }
        public virtual void PrintInfo () {
            Console.WriteLine ($"Name: {Name}\nType: {Type}\nStripes: {stripes}\nSpelling Level: {Spelling}");
        }
    }
}