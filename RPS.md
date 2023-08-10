---
layout: project
type: console application
title: "RockPaperScissors"
date: 2023-8-10
published: true
labels:
  - C#
  - GitHub
summary: "Console app that allows you to play rock, paper, scissors."
---

[
using System;
using static System.Console; //using this means I don't have to type 'Console.' in front of every Write or Read function

namespace RockPaperScissors
//title
{
class Program
	{ //initializing namespace
		static void Main(string[] args)
		{
			
			string RPS;             //used for storing user data
			int RPSplayer;          //used to convert string to int

		do
		{
			WriteLine("Hello! Let's play Rock, Paper, Scissors"); //message prompt WriteLine("Enter:\n1. Rock\n2. Paper\n3. Scissors"); //prompt for input 
			RPS = ReadLine();				      //stores user input into variable
			
			RPSplayer = Convert.ToInt16(RPS);               //converts the string to an integer

			do
			{
				WriteLine("Please pick 1, 2, or 3 for Rock, Paper, Scissors respectively."); //message prompt for player who picks a number other than 1,2,3.
			}while (RPSplayer < 1 || RPSplayer > 3) 					     //do-while statement for player who picks a number other than 1,2,3. 
			
			switch(RPSplayer)
			{
				case 1:
					WriteLine("You picked Rock!"); //message prompt for player picking rock 
					break;
				case 2:
					WriteLine("You picked Paper!"); //message prompt for player picking paper
					break;
				case 3:
					WriteLine("You picked Scissors!"); //message prompt for player picking scissors
					break;
			}

			Random RNG = new Random(); //initializing randomized variable
			int RNGnpc = RNG.Next(3); //randomly generates an integer between 0 and 2

			if (RNGnpc == 0) //npc picks rock
			{
				if (RPSplayer == 1)
				{
				WriteLine(You both chose Rock.. It's a draw!) //player chose rock
				}
				
				else if (RPSplayer == 2) //player chose paper
				{
				WriteLine(Paper beats Rock.. You Win!)
				}
				
				else if (RPSplayer == 3) //player chose scissors
				{
				WriteLine(Rock beats Scissors.. You Lose!)
				}
			}
			
			if (RNGnpc == 1) //npc picks paper
			{
				if (RPSplayer == 1) //player chose rock
				{
				WriteLine(Paper beats Rock.. You Lose!")
				}
				
				else if (RPSplayer == 2) //player chose paper
				{
				WriteLine(You both chose Paper.. It's a draw!)
				}
				
				else if (RPSplayer == 3) //player chose scissors
				{
				WriteLine(Scissors beats Paper.. You Win!)
				}
			}
			
			if (RNGnpc == 2) //npc picks scissors
			{
				if (RPSplayer == 1) //player chose rock
				{
				WriteLine(Rock beats Scissors.. You Win!)
				}
				
				else if (RPSplayer == 2) //player chose paper
				{
				WriteLine(Scissors beats Paper.. You Lose!)
				}
				
				else if (RPSplayer == 3) //player chose scissors
				{
				WriteLine(You both chose Scissors.. It's a draw!)
				}
			}
			
			string playAgain;
			WriteLine("Do you want to play again? y/n");
			playAgain = ReadLine();
		}while (playAgain == "y")
	Read(); //halts program until user hits a key
     }
   }
}
]
