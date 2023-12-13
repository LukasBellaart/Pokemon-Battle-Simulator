using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator.Pokemons
{
    class Bulbasaur : Pokemon
    {

        public Bulbasaur() : base("Bulbasaur", Types.LEAF, Types.LEAF, Types.FIRE) { }

        public override void battleCry()
        {
            Console.Write(this.getName() + " yells " + this.getName() + "!\n");
        }
    }
}
