using Pokemon_Battle_Simulator;
using Pokemon_Battle_Simulator.Pokemons;
using System.Diagnostics;
using System.Collections.Generic;



Console.WriteLine("Start spel? Y/N");
string startAntwoord = Console.ReadLine();

if(startAntwoord == "N")
{
    Environment.Exit(0);
}


Console.WriteLine("Naam trainer 1? ");
string trainer1Naam = Console.ReadLine();

Trainer trainer1 = new Trainer(trainer1Naam);

Console.WriteLine("Naam trainer 2? ");
string trainer2Naam = Console.ReadLine();

Trainer trainer2 = new Trainer(trainer2Naam);
List<int> trainer1ListUsed = new List<int>();
List<int> trainer2ListUsed = new List<int>();

string trainer1name = trainer1.getNaam();
string trainer2name = trainer2.getNaam();

Arena arena = new Arena();

int i = 0;

while(canGameContinue()) {
    if (i == 0)
    {
        int trainer1Number = new Random().Next(0, 6);

        while (trainer1ListUsed.Contains(trainer1Number))
        {
            trainer1Number = new Random().Next(0, 6);

        }
        trainer1ListUsed.Add(trainer1Number);

        Pokeball trainer1Pokeball = trainer1.getPokeball(trainer1Number);
        Pokemon trainer1Pokemon = trainer1Pokeball.releasePokemon();



        int trainer2Number = new Random().Next(0, 6);

        while (trainer2ListUsed.Contains(trainer1Number))
        {
            trainer2Number = new Random().Next(0, 6);
        }
        trainer2ListUsed.Add(trainer2Number);

        Pokeball trainer2Pokeball = trainer2.getPokeball(trainer2Number);
        Pokemon trainer2Pokemon = trainer2Pokeball.releasePokemon();

        Battle battleResults = arena.startRound(trainer1Pokemon, trainer2Pokemon, trainer1Pokeball, trainer2Pokeball);

        int winner = battleResults.getWinnaar();

        arena.revealWinner(winner, trainer1Pokemon, trainer2Pokemon, trainer1Pokeball, trainer2Pokeball);


    } else
    {

        int lastRound = arena.getLastWinner();
        Pokemon lastRoundPokemon = arena.getLastPokemon();
        Pokeball lastRoundBall = arena.getLastPokeball();
        if (lastRound == 0)
        {
            Pokeball trainer1Pokeball = lastRoundBall;
            Pokemon trainer1Pokemon = lastRoundPokemon;

            int trainer2Number = new Random().Next(0, 6);



            while (trainer2ListUsed.Contains(trainer2Number))
            {
                trainer2Number = new Random().Next(0, 6);
            }
            trainer2ListUsed.Add(trainer2Number);

            Pokeball trainer2Pokeball = trainer2.getPokeball(trainer2Number);
            Pokemon trainer2Pokemon = trainer2Pokeball.releasePokemon();

            Battle battleResults = arena.startRound(trainer1Pokemon, trainer2Pokemon, trainer1Pokeball, trainer2Pokeball);

            int winner = battleResults.getWinnaar();

            arena.revealWinner(winner, trainer1Pokemon, trainer2Pokemon, trainer1Pokeball, trainer2Pokeball);

        }
        else if (lastRound == 1)
        {

            Pokeball trainer2Pokeball = lastRoundBall;
            Pokemon trainer2Pokemon = lastRoundPokemon;

            int trainer1Number = new Random().Next(0, 6);
            while (trainer1ListUsed.Contains(trainer1Number))
            {
                trainer1Number = new Random().Next(0, 6);
            }
            trainer1ListUsed.Add(trainer1Number);

            Pokeball trainer1Pokeball = trainer1.getPokeball(trainer1Number);
            Pokemon trainer1Pokemon = trainer1Pokeball.releasePokemon();

            Battle battleResults = arena.startRound(trainer1Pokemon, trainer2Pokemon, trainer1Pokeball, trainer2Pokeball);

            int winner = battleResults.getWinnaar();

            arena.revealWinner(winner, trainer1Pokemon, trainer2Pokemon, trainer1Pokeball, trainer2Pokeball);

        }
        else if (lastRound == 2)
        {
            int trainer1Number = new Random().Next(0, 6);
            while (trainer1ListUsed.Contains(trainer1Number))
            {
                trainer1Number = new Random().Next(0, 6);
            }
            trainer1ListUsed.Add(trainer1Number);

            Pokeball trainer1Pokeball = trainer1.getPokeball(trainer1Number);
            Pokemon trainer1Pokemon = trainer1Pokeball.releasePokemon();

            int trainer2Number = new Random().Next(0, 6);

            while (trainer2ListUsed.Contains(trainer1Number))
            {
                trainer2Number = new Random().Next(0, 6);
            }
            trainer2ListUsed.Add(trainer2Number);

            Pokeball trainer2Pokeball = trainer2.getPokeball(trainer2Number);
            Pokemon trainer2Pokemon = trainer2Pokeball.releasePokemon();

            Battle battleResults = arena.startRound(trainer1Pokemon, trainer2Pokemon, trainer1Pokeball, trainer2Pokeball);

            int winner = battleResults.getWinnaar();

            arena.revealWinner(winner, trainer1Pokemon, trainer2Pokemon, trainer1Pokeball, trainer2Pokeball);

        }
    }

    i++;

}

arena.displayWinner();

Boolean canGameContinue()
{
    if(trainer1ListUsed.Count == 6)
    {
        return false;
    }
    else if (trainer2ListUsed.Count == 6)
    {
        return false;
    }

    return true;

}