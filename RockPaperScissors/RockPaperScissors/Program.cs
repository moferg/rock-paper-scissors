﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menu: Welcome to Rock Paper Scissors!
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            // Menu: Please choose either rock paper or scissors
            Console.WriteLine("Please type either rock paper or scissors and press enter to make your choice.");
            // Accept user input and change string to all lowercase
            string userChoice = Console.ReadLine().ToLower();
           
            // Generate a random number from 1-3 for cpuChoice
            Random rand = new Random();
            int randInt = rand.Next(1, 4);
            string cpuChoice = "";
            // 1 == rock
            if(randInt == 1)
            {
                cpuChoice = "rock";
            }                
            // 2 == paper
            if(randInt == 2)
            {
                cpuChoice = "paper";
            }
            // 3 == scissors
            if(randInt == 3)
            {
                cpuChoice = "scissors";
            }
            
            // if userChoice == rock && cpuChoice == rock
            if(userChoice == "rock" && cpuChoice == "rock")
            {
                Console.WriteLine($"You chose {userChoice} and the computer chose {cpuChoice}");
                // tie game
                Console.WriteLine("Tie Game!");
            }
            // if userChoice == rock && cpuChoice == paper
            if (userChoice == "rock" && cpuChoice == "paper")
            {
                Console.WriteLine($"You chose {userChoice} and the computer chose {cpuChoice}");
                // cpu wins
                Console.WriteLine("The computer won!");
            }
            // if userChoice == rock && cpuChoice == scissors
            if (userChoice == "rock" && cpuChoice == "scissors")
            {
                Console.WriteLine($"You chose {userChoice} and the computer chose {cpuChoice}");
                // player wins
                Console.WriteLine("You won!");
            }


            // if userChoice == paper && cpuChoice == rock
            if (userChoice == "paper" && cpuChoice == "rock")
            {
                Console.WriteLine($"You chose {userChoice} and the computer chose {cpuChoice}");
                // player wins
                Console.WriteLine("You won!");
            }
            // if userChoice == paper && cpuChoice == paper
            if (userChoice == "paper" && cpuChoice == "paper")
            {
                Console.WriteLine($"You chose {userChoice} and the computer chose {cpuChoice}");
                // tie game
                Console.WriteLine("Tie Game!");
            }
            // if userChoice == paper && cpuChocie == scissors
            if(userChoice == "paper" && cpuChoice == "scissors")
            {
                Console.WriteLine($"You chose {userChoice} and the computer chose {cpuChoice}");
                // cpu wins
                Console.WriteLine("The computer won!");
            }

            // if userChoice == scissors && cpuChoice == rock
            if (userChoice == "scissors" && cpuChoice == "rock")
            {
                Console.WriteLine($"You chose {userChoice} and the computer chose {cpuChoice}");
                // cpu wins
                Console.WriteLine("The computer won!");
            }
            // if userChoice == scissors && cpuChoice == paper
            if (userChoice == "scissors" && cpuChoice == "paper")
            {
                Console.WriteLine($"You chose {userChoice} and the computer chose {cpuChoice}");
                // player wins
                Console.WriteLine("You won!");
            }
            // if userChoice == scissors && cpuChoice == scissors
            if (userChoice == "scissors" && cpuChoice == "scissors")
            {
                Console.WriteLine($"You chose {userChoice} and the computer chose {cpuChoice}");
                // tie game
                Console.WriteLine("Tie Game!");
            }

            Console.ReadKey();
        }
    }
}
