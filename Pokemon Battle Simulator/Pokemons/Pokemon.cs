using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator.Pokemons
{
    internal abstract class Pokemon
    {
        private readonly string name;
        private readonly Types type;
        private readonly Types strenght;
        private readonly Types weakness;



        protected Pokemon(string name, Types type, Types strength, Types weakness)
        {
            this.name = name; // placeholder
            this.type = type;
            this.strenght = strength;
            this.weakness = weakness;

        }

        public abstract void battleCry();

        public string getName()
        {
            return name;
        }


        public Types getType()
        {
            return type;
        }

        public Types getStrength()
        {
            return strenght;
        }

        public Types getWeakness()
        {
            return weakness;
        }
    }
}
