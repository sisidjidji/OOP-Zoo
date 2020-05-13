using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_zoo
{
    public class butterflys:Insects
    {
        public override int Age => 1;
        public override decimal Weight => 1m;

        public override int Id => 0654657;

        public override string Wings => "four";


        public override bool fly()
        {
            Console.WriteLine("butterflys fly!!");
            return true;

        }
        public override string Sound()
        {
            return "the butterflys frrr";
        }

        public override string Sleep()
        {
            return "the betterfly sleep ";
        }
        public override string Eat()
        {
            return "betterflys eat from the flowers";
        }
    }
}
