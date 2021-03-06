﻿using System;
using System.Collections.Generic;
using Casino;
using Casino.TwentyOne;


namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Guid identifier = Guid.NewGuid();
            Console.WriteLine("Welcome to the Grand Hotel and Casino.  Lets start by telling me your name.");
            string playerName = Console.ReadLine();

            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}.  Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "ya" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;

                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }

            Console.WriteLine("Feel free to look around the casino.  Bye for now.");
            Console.Read();
             

        }
    }
}
