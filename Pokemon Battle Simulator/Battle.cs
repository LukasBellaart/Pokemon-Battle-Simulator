﻿using Pokemon_Battle_Simulator.Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator
{
    internal class Battle
    {
        private MatchStatus status;

        private Pokemon pokemon;

        private Pokeball pokeball;

        public Battle(Pokemon pokemon1, Pokemon pokemon2, Pokeball pokeball1, Pokeball pokeball2)
        {

            Types pokeMonStrength1 = pokemon1.getStrength();
            Types pokeMonWeakness1 = pokemon1.getWeakness();

            Types pokeMonStrength2 = pokemon2.getStrength();
            Types pokeMonWeakness2 = pokemon2.getWeakness();


            if (pokeMonStrength1 == pokeMonWeakness2)
            {
                this.status = MatchStatus.WIN;
                this.pokemon = pokemon1;
                this.pokeball = pokeball1;

            }
            else if (pokeMonStrength2 == pokeMonWeakness1)
            {
                this.status = MatchStatus.LOSE;
                this.pokemon = pokemon2;
                this.pokeball = pokeball2;

            }
            else
            {
                this.status = MatchStatus.DRAW;
            }

        }

        public MatchStatus getWinnaar()
        {
            return status;
        }

        public Pokemon getPokemon()
        {
            return pokemon;
        }

        public Pokeball getPokeball()
        {
            return pokeball;
        }
    }
}
