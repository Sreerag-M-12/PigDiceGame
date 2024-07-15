using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGame
{
    internal class Program
    {
        static void playGame(ref int totalPoint, ref int turnPoint, ref int turn)
        {
            Random dice = new Random();
            int diceValue;
            Console.WriteLine(" "); ;
            Console.WriteLine($"Turn {turn}");

            char rollOrHold = Convert.ToChar(Console.ReadLine());
            if (rollOrHold == 'r')
            {
                diceValue = dice.Next(1, 7);
                Console.WriteLine($"Dice value: {diceValue}");
                if (diceValue == 1)
                {
                    turn++;
                    turnPoint = 0;
                    totalPoint = totalPoint + turnPoint;

                    Console.WriteLine($"turn {turn} point: {turnPoint}");
                    Console.WriteLine($"total Point: {totalPoint}");
                    Console.WriteLine("Turn Over");
                }
                else
                {
                    turnPoint = turnPoint + diceValue;
                    Console.WriteLine($"turn {turn} point: {turnPoint}");
                }
            }
            else if (rollOrHold == 'h')
            {
                diceValue = dice.Next(1, 7);
                Console.WriteLine($"your dice value was {diceValue}");
                Console.WriteLine($"turn {turn} point: {turnPoint}");

                totalPoint = totalPoint + turnPoint;

                Console.WriteLine($"total Point: {totalPoint}");

                turn++;
                Console.WriteLine("Turn Over");
                turnPoint = 0;
            }
            else
            {
                Console.WriteLine("wrong output");
            }
        }
        static void Main(string[] args)
        {
           
            int turn = 1;
            int turnPoint = 0;
            int totalPoint = 0;
            Console.WriteLine("Welcome to Pig Dice Game");


            Console.WriteLine("type r to roll the dice, type h to hold");
            while (totalPoint < 20)
            {
                playGame(ref totalPoint, ref turnPoint, ref turn);              
            }

            Console.WriteLine("======================");
            Console.WriteLine($"you have finsihed the game with {totalPoint} points in {turn-1} turns");

        }
    }
}
