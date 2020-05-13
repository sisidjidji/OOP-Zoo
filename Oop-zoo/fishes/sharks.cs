using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_zoo
{
   public class Sharks:Fishes
    {
        public override int Age => 7;
        public override decimal Weight => 1000m;

        public override int Id => 09222544;

        public override string Sound()
        {
            return "the shark toutouroutou";
        }

        public override string Sleep()
        {
            return "the sharks sleep the night";
        }
        public override string Eat()
        {
            return "sharks eat fishes";
        }
    }
}
