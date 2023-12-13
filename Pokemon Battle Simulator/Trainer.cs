using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

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
            for (int i = 0; i < 6; i++)
            {
                pokeballs.Add(new Pokeball(i));
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
