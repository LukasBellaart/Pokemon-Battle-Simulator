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
        private readonly string ownerName;

        public Pokeball(string naam, string pokemonName)
        {
            switch (pokemonName)
            {
                case "Charmander":
                    pokemon = new Charmander();

                    break;
                case "Squirtle":
                    pokemon = new Squirtle();

                    break;
                case "Bulbasaur":
                    pokemon = new Bulbasaur();
                    break;
            }
            ownerName = naam;
        }


        public Pokemon releasePokemon()
        {

            Console.WriteLine(ownerName + " is releasing " + pokemon.getName());

            return pokemon;
        }

        public void catchPokemon()
        {
            Console.WriteLine(ownerName + " is catching " + pokemon.getName());
        }

        public void killPokemon(Pokemon killerPokemon)
        {
            Console.WriteLine(killerPokemon.getName() + " killed " + ownerName + "'s " + pokemon.getName() + "!\n");
        }
    }
}
