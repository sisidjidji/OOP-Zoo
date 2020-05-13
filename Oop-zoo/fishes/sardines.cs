using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_zoo
{
   public class Sardines:Fishes
    {
        public override int Age => 2;
        public override decimal Weight => 100m;

        public override int Id => 09222;

        public override string  Sound()
        {
            return "the sardine dound";
        }

        public override string Sleep()
        {
          return  "the sleep the night";
        }
        public override string Eat()
        {
            return "sardines eat algaue";
        }

    }
}
