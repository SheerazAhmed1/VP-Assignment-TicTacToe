using System.ComponentModel;

namespace TIC_TAC_TOE
{
    public partial class Form1 : Form
    {
        bool turn=true;
        int turn_count=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button btn = sender as Button ;

            if (turn)
            {
                btn.Text = "X";
            }
            else
            {
                btn.Text = "O";   
            }
            turn = !turn;
            turn_count++;
            btn.Enabled = false;

            checkForWinner();
        }

        private void checkForWinner()
        {
            bool winner=false;
            //Horizantal Checks 
            if((R1B1.Text==R1B2.Text)&& (R1B2.Text == R1B3.Text)&&(!R1B1.Enabled))
            winner=true;
            else if ((R2B1.Text == R2B2.Text) && (R2B2.Text == R2B3.Text) && (!R2B1.Enabled))
                winner = true;
           else if ((R3B1.Text == R3B2.Text) && (R3B2.Text == R3B3.Text)&&(!R3B1.Enabled))
                winner = true;

            //Vertical Checks
            if ((R1B1.Text == R2B1.Text) && (R2B1.Text == R3B1.Text) && (!R1B1.Enabled))
                winner = true;
            else if ((R1B2.Text == R2B2.Text) && (R2B2.Text == R3B2.Text) && (!R1B2.Enabled))
                winner = true;
            else if ((R1B3.Text == R2B3.Text) && (R2B3.Text == R3B3.Text) && (!R1B3.Enabled))
                winner = true;

            //Diagonal Checks
            if ((R1B1.Text == R2B2.Text) && (R2B2.Text == R3B3.Text) && (!R1B1.Enabled))
                winner = true;
            else if ((R1B3.Text == R2B2.Text) && (R2B2.Text == R3B1.Text) && (!R1B3.Enabled))
                winner = true;
           


            if (winner)
            {
                disableButtons();
                string winner_is;
                if (turn)
                {
                    winner_is = "O";
                }
                else
                {
                    winner_is = "X";
                }
                MessageBox.Show(winner_is + " Wins");
            }
            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show("Draw");
                }
            }
        }

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {

                    Button btn =  (Button)c;
                    btn.Enabled = false;
                }
            }
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button button = (Button)c;
                    button.Enabled = true;
                    button.Text = "";
                }
            }
            catch { }
        }
    }
}