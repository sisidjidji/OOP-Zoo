using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_zoo
{
   public class Tigers:mamels
    {
        public override int Age => 2;
        public override decimal Weight => 100m;

        public override int Id => 09222;


        public override string Hair => "brown";
      

        public override string Sound()
        {
            return "the tigers wowww";
        }

        public override string Sleep()
        {
            return "the tiger sleep the night";
        }
        public override string Eat()
        {
            return "tiger eat algaue";
        }
    }
}
