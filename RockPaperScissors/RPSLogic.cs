using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class RPSLogic
    {
        string[] choices = { "rock", "paper", "scissors", "rock", "scissors", "paper" };

        public int randomNumber = 0;

        Random rng = new Random();



        static public int playerScore;

        static public int cpuScore;

        public void checkGame(string playerChoice, string cpuChoice)
        {
            if (playerChoice == "rock" && cpuChoice == "paper")
            {
                MessageBox.Show("CPU Wins");
                cpuScore++;
            }
            else if (playerChoice == "paper" && cpuChoice == "rock")
            {
                MessageBox.Show("Player Wins");
                playerScore++;
            }
            else if (playerChoice == "paper" && cpuChoice == "scissors")
            {
                MessageBox.Show("AI Wins");
                cpuScore++;
            }
            else if (playerChoice == "scissors" && cpuChoice == "paper")
            {
                MessageBox.Show("Player Wins");
                playerScore++;
            }
            else if (playerChoice == "scissors" && cpuChoice == "rock")
            {
                MessageBox.Show("AI Wins");
                cpuScore++;
            }
            else if (playerChoice == "rock" && cpuChoice == "scissors")
            {
                MessageBox.Show("Player Wins");
                playerScore++;
            }
            else
            {
                MessageBox.Show("Draw");
            }
        }
        public string CPUChoice()
        {
           randomNumber = rng.Next(0, 5);
           var cpuChoice = choices[randomNumber];
           return cpuChoice.ToString();
        }
    }
}
