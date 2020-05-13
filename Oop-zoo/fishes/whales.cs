using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_zoo
{
    public class Whales:Fishes
    {
        public override int Age => 9;
        public override decimal Weight => 5000m;

        public override int Id => 0922;

        public override string Sound()
        {
            return "the whales make noise";
        }

        public override string Sleep()
        {
            return "the sleep the night";
        }
        public override string Eat()
        {
            return "sardines eat algaue";
        }
    }
}
