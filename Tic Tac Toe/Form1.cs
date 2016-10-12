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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("X Goes First Rn :)");
        }

        //Declarations
        char turn = 'X';
        int plays = 0;
        Squares X = new Squares();
        Squares O = new Squares();
        bool Square1Done = false;
        bool Square2Done = false;
        bool Square3Done = false;


        public void BlankSquares(int area) {

            switch (area)
            {
                case 0:
                    MessageBox.Show("Wildcard");
                    break;
                case 1:
                    A11.Enabled = false;
                    A12.Enabled = false;
                    A13.Enabled = false;
                    B11.Enabled = false;
                    B12.Enabled = false;
                    B13.Enabled = false;
                    C11.Enabled = false;
                    C12.Enabled = false;
                    C13.Enabled = false;

                    break;
                case 2:
                    A21.Enabled = false;
                    A22.Enabled = false;
                    A23.Enabled = false;
                    B21.Enabled = false;
                    B22.Enabled = false;
                    B23.Enabled = false;
                    C21.Enabled = false;
                    C22.Enabled = false;
                    C23.Enabled = false;
                    break;
                case 3:
                    A31.Enabled = false;
                    A32.Enabled = false;
                    A33.Enabled = false;
                    B31.Enabled = false;
                    B32.Enabled = false;
                    B33.Enabled = false;
                    C31.Enabled = false;
                    C32.Enabled = false;
                    C33.Enabled = false;
                    break;
                case 4:
                    A41.Enabled = false;
                    A42.Enabled = false;
                    A43.Enabled = false;
                    B41.Enabled = false;
                    B42.Enabled = false;
                    B43.Enabled = false;
                    C41.Enabled = false;
                    C42.Enabled = false;
                    C43.Enabled = false;
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                default:
                    break;
            }


        }

        public void ifFinnish()
        {
            if (plays == 9)
            {
                finnish();
                MessageBox.Show("No One Won:(");
            }

        }

        public void finnish()
        {
            
            A11.Enabled = false;
            A12.Enabled = false;
            A13.Enabled = false;
            B11.Enabled = false;
            B12.Enabled = false;
            B13.Enabled = false;
            C11.Enabled = false;
            C12.Enabled = false;
            C13.Enabled = false;
        }

        public void CheckWin()
        {
            if (xPermutations() == 1)
            {
                finnish();
                MessageBox.Show("X WINS!", "Tic Tac Toe");
            }

            if (oPermutations() == 1)
            {
                finnish();
                MessageBox.Show("O WINS!", "Tic Tac Toe");
            }
        }

        public int xPermutations()
        {
            int check = 0;

            if (X.A11)
            {
                //Across the top
                if (X.A12)
                {
                    if (X.A13)
                    {
                        check = 1;
                    }
                }
                //Left Down
                if (X.B11)
                {
                    if (X.C11)
                    {
                        check = 1;
                    }
                }
                //Diagonal Top Left To Bottom Right
                if (X.B12)
                {
                    if (X.C13)
                    {
                        check = 1;
                    }
                }

            }

            //Middle Down
            if (X.A12)
            {
                if (X.B12)
                {
                    if (X.C12)
                    {
                        check = 1;
                    }
                }
            }

            
            if (X.A13)
            {
                //Diagonal Top Right To Bottom Left
                if (X.B12)
                {
                    if (X.C11)
                    {
                        check = 1;
                    }
                }
                //Right Down
                if (X.B13)
                {
                    if (X.C13)
                    {
                        check = 1;
                    }
                }
            }

            //Across the middle
            if (X.B13)
            {
                if (X.B12)
                {
                    if (X.B11)
                    {
                        check = 1;
                    }
                }
            }
            //Across the bottom
            if (X.C11)
            {
                if (X.C12)
                {
                    if (X.C13)
                    {
                        check = 1;
                    }
                }
            }

            return check;
        }
        
        public int oPermutations()
        {
            int check = 0;
            if (O.A11)
            {
                //Across the top
                if (O.A12)
                {
                    if (O.A13)
                    {
                        check = 1;
                    }
                }
                //Left Down
                if (O.B11)
                {
                    if (O.C11)
                    {
                        check = 1;
                    }
                }
                //Diagonal Top Left To Bottom Right
                if (O.B12)
                {
                    if (O.C13)
                    {
                        check = 1;
                    }
                }

            }

            //Middle Down
            if (O.A12)
            {
                if (O.B12)
                {
                    if (O.C12)
                    {
                        check = 1;
                    }
                }
            }


            if (O.A13)
            {
                //Diagonal Top Right To Bottom Left
                if (O.B12)
                {
                    if (O.C11)
                    {
                        check = 1;
                    }
                }
                //Right Down
                if (O.B13)
                {
                    if (O.C13)
                    {
                        check = 1;
                    }
                }
            }

            //Across the middle
            if (O.B13)
            {
                if (O.B12)
                {
                    if (O.B11)
                    {
                        check = 1;
                    }
                }
            }
            //Across the bottom
            if (O.C11)
            {
                if (O.C12)
                {
                    if (O.C13)
                    {
                        check = 1;
                    }
                }
            }

            return check;

        }

        public void NewGame()
        {
            plays = 0;
            turn = 'X';
            resetSquare();
        }

        public void resetSquare()
        {   
                            A11.Text = "";
                            A11.Enabled = true;
                            A12.Text = "";
                            A12.Enabled = true;
                            A13.Text = "";
                            A13.Enabled = true;
                            B11.Text = "";
                            B11.Enabled = true;
                            B12.Text = "";
                            B12.Enabled = true;
                            B13.Text = "";
                            B13.Enabled = true;
                            C11.Text = "";
                            C11.Enabled = true;
                            C12.Text = "";
                            C12.Enabled = true;
                            C13.Text = "";
                            C13.Enabled = true;
            X.A11 = false;
            X.A12 = false;
            X.A13 = false;
            X.B11 = false;
            X.B12 = false;
            X.B13 = false;
            X.C11 = false;
            X.C12 = false;
            X.C13 = false;

            O.A11 = false;
            O.A12 = false;
            O.A13 = false;
            O.B11 = false;
            O.B12 = false;
            O.B13 = false;
            O.C11 = false;
            O.C12 = false;
            O.C13 = false;
        }
       

        public void setSquare(char Letter, int Number)
        {
            if (turn == 'X')
            {
                switch (Letter)
                {
                    case 'A':
                        switch (Number)
                        {
                            case 1:
                                A11.Text = "X";
                                A11.Enabled = false;
                                X.A11 = true;
                                turn = 'O';
                                break;
                            case 2:
                                A12.Text = "X";
                                A12.Enabled = false;
                                X.A12 = true;
                                turn = 'O';
                                break;
                            case 3:
                                A13.Text = "X";
                                A13.Enabled = false;
                                X.A13 = true;
                                turn = 'O';
                                break;
                            default:
                                break;
                        }
                        break;
                    case 'B':
                        switch (Number)
                        {
                            case 1:
                                B11.Text = "X";
                                B11.Enabled = false;
                                X.B11 = true;
                                turn = 'O';
                                break;
                            case 2:
                                B12.Text = "X";
                                B12.Enabled = false;
                                X.B12 = true;
                                turn = 'O';
                                break;
                            case 3:
                                B13.Text = "X";
                                B13.Enabled = false;
                                X.B13 = true;
                                turn = 'O';
                                break;
                            default:
                                break;
                        }
                        break;
                    case 'C':
                        switch (Number)
                        {
                            case 1:
                                C11.Text = "X";
                                C11.Enabled = false;
                                X.C11 = true;
                                turn = 'O';
                                break;
                            case 2:
                                C12.Text = "X";
                                C12.Enabled = false;
                                X.C12 = true;
                                turn = 'O';
                                break;
                            case 3:
                                C13.Text = "X";
                                C13.Enabled = false;
                                X.C13 = true;
                                turn = 'O';
                                break;
                            default:
                                break;
                        }
                        break;
                        
                    default:
                        break;
                }
                
            }
            else if (turn == 'O')
            {
                switch (Letter)
                {
                    case 'A':
                        switch (Number)
                        {
                            case 1:
                                A11.Text = "O";
                                A11.Enabled = false;
                                O.A11 = true;
                                turn = 'X';
                                break;
                            case 2:
                                A12.Text = "O";
                                A12.Enabled = false;
                                O.A12 = true;
                                turn = 'X';
                                break;
                            case 3:
                                A13.Text = "O";
                                A13.Enabled = false;
                                O.A13 = true;
                                turn = 'X';
                                break;
                            default:
                                break;
                        }
                        break;
                    case 'B':
                        switch (Number)
                        {
                            case 1:
                                B11.Text = "O";
                                B11.Enabled = false;
                                O.B11 = true;
                                turn = 'X';
                                break;
                            case 2:
                                B12.Text = "O";
                                B12.Enabled = false;
                                O.B12 = true;
                                turn = 'X';
                                break;
                            case 3:
                                B13.Text = "O";
                                B13.Enabled = false;
                                O.B13 = true;
                                turn = 'X';
                                break;
                            default:
                                break;
                        }
                        break;
                    case 'C':
                        switch (Number)
                        {
                            case 1:
                                C11.Text = "O";
                                C11.Enabled = false;
                                O.C11 = true;
                                turn = 'X';
                                break;
                            case 2:
                                C12.Text = "O";
                                C12.Enabled = false;
                                O.C12 = true;
                                turn = 'X';
                                break;
                            case 3:
                                C13.Text = "O";
                                C13.Enabled = false;
                                O.C13 = true;
                                turn = 'X';
                                break;
                            default:
                                break;
                        }
                        break;

                    default:
                        break;
                }
                
            }
            plays++;
            ifFinnish();
            CheckWin();

         }

        private void A1_Click(object sender, EventArgs e)
        {
            setSquare('A',1);
        }

        private void A2_Click(object sender, EventArgs e)
        {
            setSquare('A', 2);
        }

        private void A3_Click(object sender, EventArgs e)
        {
            setSquare('A', 3);
        }

        private void B1_Click(object sender, EventArgs e)
        {
            setSquare('B', 1);
        }

        private void B2_Click(object sender, EventArgs e)
        {
            setSquare('B', 2);
        }

        private void B3_Click(object sender, EventArgs e)
        {
            setSquare('B', 3);
        }

        private void C1_Click(object sender, EventArgs e)
        {
            setSquare('C', 1);
        }

        private void C2_Click(object sender, EventArgs e)
        {
            setSquare('C', 2);
        }

        private void C3_Click(object sender, EventArgs e)
        {
            setSquare('C', 3);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Is A Tic Tac Toe Game. Made By Mike Hodges");
        }
    }
}
