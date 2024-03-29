﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Pokemon_Battle_Simulator.Pokemons;

namespace Pokemon_Battle_Simulator
{
    internal class Trainer
    {
        private static int MAX_BELT_SIZE = 6;

        readonly string naam;

        public ObservableCollection<Pokeball> pokeballs = new ObservableCollection<Pokeball>();


        public Trainer(string naam) {
            this.pokeballs.CollectionChanged += listChanged;

            this.naam = naam;

            string[] defaultPokemons = { "Charmander", "Squirtle", "Bulbasaur", "Charmander", "Squirtle", "Bulbasaur" };

            foreach (string pokemon in defaultPokemons)
            {
                switch (pokemon)
                {
                    case "Charmander":
                        pokeballs.Add(new Pokeball(naam, new Charmander()));
                        break;
                    case "Squirtle":
                        pokeballs.Add(new Pokeball(naam, new Squirtle()));
                        break;
                    case "Bulbasaur":
                        pokeballs.Add(new Pokeball(naam, new Bulbasaur()));
                        break;
                }
            }
        }

        public Pokeball getPokeball(int index)
        {
            return pokeballs[index];
        }

        public string getNaam()
        {
            return naam;
        }

        void listChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            //list changed - an item was added.
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                if(this.pokeballs.Count > MAX_BELT_SIZE)
                {
                    throw new Exception("Added more than 6 items to belt");
                }

            }
        }
    }


}
