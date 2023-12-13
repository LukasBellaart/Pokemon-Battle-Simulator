using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator.Pokemons
{
    class Charmander : Pokemon
    {

        public Charmander(): base("charmander", Types.FIRE, Types.FIRE, Types.WATER)
        {

        }

        public override void battleCry()
        {
            Console.Write(this.getName() + " yells " + this.getName() + "!\n");
        }

    }
 
}
