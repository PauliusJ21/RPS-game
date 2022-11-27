namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        private RPSLogic gameLogic;
        string playerChoice;
        public int timePerRound = 3;

        public int randomNumber = 0;

        Random rng = new Random();

        public Form1()
        {
            InitializeComponent();
            countDownTimer.Enabled = true;
            gameLogic = new RPSLogic();
            playerChoice = "none";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.rock;
            playerChoice = "rock";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.paper;
            playerChoice = "paper";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.scissors;
            playerChoice = "scissors";
        }



        private void countDownTimer_Tick(object sender, EventArgs e)
        {

            timePerRound--;
            string cpuChoice = "";
            label4.Text = Convert.ToString(timePerRound);
            if (timePerRound < 1)
            {
                countDownTimer.Enabled = false;
                cpuChoice = gameLogic.CPUChoice();
                switch (cpuChoice)

                {

                    case "rock":
                        pictureBox2.Image = Properties.Resources.rock;
                        break;

                    case "paper":
                        pictureBox2.Image = Properties.Resources.paper;
                        break;

                    case "scissors":
                        pictureBox2.Image = Properties.Resources.scissors;
                        break;

                    default:
                        break;

                }
                gameLogic.checkGame(playerChoice, cpuChoice);
                label3.Text = "Player: " + RPSLogic.playerScore;
                label5.Text = "CPU: " + RPSLogic.cpuScore;
                nextRound();
            }


        }
        private void nextRound()
        {
            timePerRound = 4;
            playerChoice = "none";
            pictureBox1.Image = Properties.Resources.dark;
            pictureBox2.Image = Properties.Resources.dark;
            countDownTimer.Enabled = true;
            if (RPSLogic.playerScore == 3 || RPSLogic.cpuScore == 3)
            {
                whoWon();
            }
        }

        private void whoWon()
        {
            if (RPSLogic.playerScore > RPSLogic.cpuScore)
            {
                MessageBox.Show("Player wins the game!");
            }
            else if (RPSLogic.playerScore < RPSLogic.cpuScore)
            {
                MessageBox.Show("CPU Wins the game");
            }
            Application.Restart();
        }
    }
}