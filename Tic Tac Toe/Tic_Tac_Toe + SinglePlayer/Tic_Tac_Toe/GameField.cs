using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class GameField : Form
    {
        bool turn = true;
        int turn_count = 0;


        public GameField()
        {
            InitializeComponent();
            DisableButtons();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;

            CheckForWinner();
        }

        private void SingleButtonClick(object sender, EventArgs e)
        {
            turn = true;
            Button b = (Button)sender;
            Button c = (Button)sender;                 
            b.Text = "X";
            b.Enabled = false;
            turn_count++;

            turn = false;
            if (turn_count < 9)
            {
                Button[] B = { X1, X2, X3, Y1, Y2, Y3, Z1, Z2, Z3 };
                var count = new Random();
                int i = count.Next(0, 8);

                for(int j = 0; j < 20; j++)                
                    if (B[i].Enabled == false)                    
                        i = count.Next(0, 8);

                c = B[i];                    
                c.Text = "O";
            }
            c.Enabled = false;

            turn_count++;
            SingleCheckForWinner();
        }

        private void SingleCheckForWinner()
        {
            bool there_is_a_winner = false;
            string winner = "";


            if ((X1.Text == "X") && (X2.Text == "X") && (X3.Text == "X") && (!X1.Enabled))
            {
                there_is_a_winner = true;
                winner = "X";
            }                
            else if ((Y1.Text == "X") && (Y2.Text == "X") && (Y3.Text == "X") && (!Y1.Enabled))
            {
                there_is_a_winner = true;
                winner = "X";
            }
            else if ((Z1.Text == "X") && (Z2.Text == "X") && (Z3.Text == "X") && (!Z1.Enabled))
            {
                there_is_a_winner = true;
                winner = "X";
            }

            else if ((X1.Text == "X") && (Y1.Text == "X") && (Z1.Text == "X") && (!X1.Enabled))
            {
                there_is_a_winner = true;
                winner = "X";
            }
            else if ((X2.Text == "X") && (Y2.Text == "X") && (Z2.Text == "X") && (!X2.Enabled))
            {
                there_is_a_winner = true;
                winner = "X";
            }
            else if ((X3.Text == "X") && (Y3.Text == "X") && (Z3.Text == "X") && (!X3.Enabled))
            {
                there_is_a_winner = true;
                winner = "X";
            }

            else if ((X1.Text == "X") && (Y2.Text == "X") && (Z3.Text == "X") && (Z3.Text == "X") && (!X1.Enabled))
            {
                there_is_a_winner = true;
                winner = "X";
            }
            else if ((X3.Text == "X") && (Y2.Text == "X") && (Z1.Text == "X") && (!X3.Enabled))
            {
                there_is_a_winner = true;
                winner = "X";
            }


            else if ((X1.Text == "O") && (X2.Text == "O") && (X3.Text == "O") && (!X1.Enabled))
            {
                there_is_a_winner = true;
                winner = "O";
            }
            else if ((Y1.Text == "O") && (Y2.Text == "O") && (Y3.Text == "O") && (!Y1.Enabled))
            {
                there_is_a_winner = true;
                winner = "O";
            }
            else if ((Z1.Text == "O") && (Z2.Text == "O") && (Z3.Text == "O") && (!Z1.Enabled))
            {
                there_is_a_winner = true;
                winner = "O";
            }

            else if ((X1.Text == "O") && (Y1.Text == "O") && (Z1.Text == "O") && (!X1.Enabled))
            {
                there_is_a_winner = true;
                winner = "O";
            }
            else if ((X2.Text == "O") && (Y2.Text == "O") && (Z2.Text == "O") && (!X2.Enabled))
            {
                there_is_a_winner = true;
                winner = "O";
            }
            else if ((X3.Text == "O") && (Y3.Text == "O") && (Z3.Text == "O") && (!X3.Enabled))
            {
                there_is_a_winner = true;
                winner = "O";
            }

            else if ((X1.Text == "O") && (Y2.Text == "O") && (Z3.Text == "O") && (Z3.Text == "O") && (!X1.Enabled))
            {
                there_is_a_winner = true;
                winner = "O";
            }
            else if ((X3.Text == "O") && (Y2.Text == "O") && (Z1.Text == "O") && (!X3.Enabled))
            {
                there_is_a_winner = true;
                winner = "O";
            }


            if (there_is_a_winner)
            {
                DisableButtons();
                MessageBox.Show(winner + " Wins!", "Yay!");
            }
            else if (turn_count == 9)
            {
                MessageBox.Show("Draw!", "Bummer!");
            }


        }

        private void CheckForWinner()
        {
            bool there_is_a_winner = false;

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                there_is_a_winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                there_is_a_winner = true;

            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                there_is_a_winner = true;

            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                there_is_a_winner = true;


            if(there_is_a_winner)
            {
                DisableButtons();
                string winner = "";

                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + " Wins!", "Yay!");
            }
            else if (turn_count == 9)
            {
                MessageBox.Show("Draw!","Bummer!");
            }
        }

        private void DisableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void singlePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisableButtons();
            turn = true;
            turn_count = 0;

            X1.Enabled = true;
            X1.Text = "";
            X2.Enabled = true;
            X2.Text = "";
            X3.Enabled = true;
            X3.Text = "";

            Y1.Enabled = true;
            Y1.Text = "";
            Y2.Enabled = true;
            Y2.Text = "";
            Y3.Enabled = true;
            Y3.Text = "";

            Z1.Enabled = true;
            Z1.Text = "";
            Z2.Enabled = true;
            Z2.Text = "";
            Z3.Enabled = true;
            Z3.Text = "";

            A1.Text = "";
            A2.Text = "";
            A3.Text = "";

            B1.Text = "";
            B2.Text = "";
            B3.Text = "";

            C1.Text = "";
            C2.Text = "";
            C3.Text = "";
        }

        private void multiplayerGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            X1.Text = "";
            X2.Text = "";
            X3.Text = "";

            Y1.Text = "";
            Y2.Text = "";
            Y3.Text = "";

            Z1.Text = "";
            Z2.Text = "";
            Z3.Text = "";

            A1.Enabled = true;            
            A1.Text = "";
            A2.Enabled = true;
            A2.Text = "";
            A3.Enabled = true;
            A3.Text = "";

            B1.Enabled = true;
            B1.Text = "";
            B2.Enabled = true;
            B2.Text = "";
            B3.Enabled = true;
            B3.Text = "";

            C1.Enabled = true;
            C1.Text = "";
            C2.Enabled = true;
            C2.Text = "";
            C3.Enabled = true;
            C3.Text = "";

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        
    }
}
