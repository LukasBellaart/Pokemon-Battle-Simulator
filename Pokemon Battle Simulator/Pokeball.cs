using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemon_Battle_Simulator.Pokemons;

namespace Pokemon_Battle_Simulator
{
    internal sealed class Pokeball
    {

        private readonly Pokemon pokemon;

        public Pokeball(int id)
        {
            if(id == 0)
            {
                pokemon = new Charmander();
            } else if (id == 1)
            {
                pokemon = new Squirtle();
            } else if (id ==2)
            {
                pokemon = new Bulbasaur();
            }
            else if (id == 3)
            {
                pokemon = new Charmander();
            }
            else if (id == 4)
            {
                pokemon = new Squirtle();
            }
            else if (id == 5)
            {
                pokemon = new Bulbasaur();
            }
        }


        public Pokemon releasePokemon()
        {

            Console.WriteLine("Releasing " + pokemon.getName());

            return pokemon;
        }

        public void catchPokemon()
        {
            Console.WriteLine("Catching " + pokemon.getName());
        }

        public void killPokemon(Pokemon killerPokemon)
        {
            Console.WriteLine(killerPokemon.getName() + " killed " + pokemon.getName() + "!\n");
        }
    }
}
