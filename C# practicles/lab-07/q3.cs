using System;
using System.Windows.Forms;

namespace DiceGameApp
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            int userNumber = RollDice();
            int computerNumber = RollDice();

            lblUserNumber.Text = $"Your Number: {userNumber}";
            lblComputerNumber.Text = $"Computer's Number: {computerNumber}";

            if (userNumber > computerNumber)
            {
                lblResult.Text = "You Win!";
            }
            else if (userNumber < computerNumber)
            {
                lblResult.Text = "Computer Wins!";
            }
            else
            {
                lblResult.Text = "It's a Tie! Play Again.";
            }
        }

        private int RollDice()
        {
            // Generate a random number between 1 and 6 (inclusive) to simulate rolling a dice.
            return random.Next(1, 7);
        }
    }

    public partial class Form1 : Form
    {
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            int userNumber = RollDice();
            int computerNumber = RollDice();

            lblUserNumber.Text = $"Your Number: {userNumber}";
            lblComputerNumber.Text = $"Computer's Number: {computerNumber}";

            if (userNumber > computerNumber)
            {
                lblResult.Text = "You Win!";
            }
            else if (userNumber < computerNumber)
            {
                lblResult.Text = "Computer Wins!";
            }
            else
            {
                lblResult.Text = "It's a Tie! Play Again.";
            }
        }

        private int RollDice()
        {
            // Generate a random number between 1 and 6 (inclusive) to simulate rolling a dice.
            return random.Next(1, 7);
        }
    }
}
