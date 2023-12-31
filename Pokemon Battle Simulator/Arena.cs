using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemon_Battle_Simulator.Pokemons;

namespace Pokemon_Battle_Simulator
{
    internal class Arena
    {
        private int round = 0;
        private MatchStatus lastVictor;
        private Pokemon lastPokemon;
        private Pokeball lastPokeball;

        static int pointsPlayer1 = 0;
        static int pointsPlayer2 = 0;

        public Battle startRound(Pokemon pokemon1, Pokemon pokemon2, Pokeball pokeball1, Pokeball pokeball2)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Starting Round");
            Console.ForegroundColor = ConsoleColor.White;

            increaseRoundCount();
            Battle newBattle =  new Battle(pokemon1, pokemon2, pokeball1, pokeball2);

            this.lastVictor = newBattle.getWinnaar();
            this.lastPokemon = newBattle.getPokemon();
            this.lastPokeball = newBattle.getPokeball();


            return newBattle;
        }

        public void revealWinner(MatchStatus status, Pokemon pokemon1, Pokemon pokemon2, Pokeball pokeball1, Pokeball pokeball2)
        {
            if (status == MatchStatus.WIN)
            {
                pokeball2.killPokemon(pokemon1);
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Player 1 has won this round!");
                increasePointsPlayer1();
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1000);
            }
            else if (status == MatchStatus.LOSE)
            {
                pokeball1.killPokemon(pokemon2);
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Player 2 has won this round!");
                increasePointsPlayer2();
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1000);


            }
            else if (status == MatchStatus.DRAW)
            {

                pokeball1.catchPokemon();
                Thread.Sleep(1000);

                pokeball2.catchPokemon();
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("This round was a draw");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1000);

            }
        }

        private void increaseRoundCount()
        {
            round++;
        }

        public int getRoundCount()
        {
            return round;
        }
        
        public MatchStatus getLastWinner()
        {
            return lastVictor;
        }

        public Pokemon getLastPokemon()
        {
            return lastPokemon;
        }

        public Pokeball getLastPokeball()
        {
            return lastPokeball;
        }

        public void displayWinner()
        {
            if(pointsPlayer1 > pointsPlayer2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Player 1 has won the game!");
                Console.ForegroundColor = ConsoleColor.White;
            } 
            else if(pointsPlayer1 < pointsPlayer2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Player 2 has won the game!");
                Console.ForegroundColor = ConsoleColor.White;
            } 
            else if(pointsPlayer1 ==  pointsPlayer2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Its a draw!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private void increasePointsPlayer1()
        {
            pointsPlayer1++;
        }

        private void increasePointsPlayer2()
        {
            pointsPlayer2++;
        }
    }

}
