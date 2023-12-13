using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator.Pokemons
{
    class Squirtle : Pokemon
    {

        public Squirtle() : base("squirtle", Types.WATER, Types.WATER, Types.LEAF) { }

        public override void battleCry()
        {
            Console.Write(this.getName() + " yells " + this.getName() + "!\n");
        }
    }
}
