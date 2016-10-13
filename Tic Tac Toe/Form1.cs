using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Things to do

//Get Permutations Working (Hopfuly In Differnt File) - DONE! Not Tested
//Make A Function To Choose What Square To Make The Player Play In
//Get The Set Square Function Working
//Set The Bools When The Squares Are Done, And Set All Of That Section To The Winning Letter
//Figure Out How To Restore Sections And ReDisabled the Already Clicked Buttons



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
        bool Square4Done = false;
        bool Square5Done = false;
        bool Square6Done = false;
        bool Square7Done = false;
        bool Square8Done = false;
        bool Square9Done = false;


        public void BlankSquares(int area) {

            switch (area)
            {
                case 0:
                    MessageBox.Show("Wildcard");
                    if (!Square1Done)
                    {

                    }
                    if (!Square2Done)
                    {

                    }
                    if (!Square3Done)
                    {

                    }
                    if (!Square4Done)
                    {

                    }
                    if (!Square5Done)
                    {

                    }
                    if (!Square6Done)
                    {

                    }
                    if (!Square7Done)
                    {

                    }
                    if (!Square8Done)
                    {

                    }
                    if (!Square9Done)
                    {

                    }
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
                    A51.Enabled = false;
                    A52.Enabled = false;
                    A53.Enabled = false;
                    B51.Enabled = false;
                    B52.Enabled = false;
                    B53.Enabled = false;
                    C51.Enabled = false;
                    C52.Enabled = false;
                    C53.Enabled = false;
                    break;
                case 6:
                    A61.Enabled = false;
                    A62.Enabled = false;
                    A63.Enabled = false;
                    B61.Enabled = false;
                    B62.Enabled = false;
                    B63.Enabled = false;
                    C61.Enabled = false;
                    C62.Enabled = false;
                    C63.Enabled = false;
                    break;
                case 7:
                    A71.Enabled = false;
                    A72.Enabled = false;
                    A73.Enabled = false;
                    B71.Enabled = false;
                    B72.Enabled = false;
                    B73.Enabled = false;
                    C71.Enabled = false;
                    C72.Enabled = false;
                    C73.Enabled = false;
                    break;
                case 8:
                    A81.Enabled = false;
                    A82.Enabled = false;
                    A83.Enabled = false;
                    B81.Enabled = false;
                    B82.Enabled = false;
                    B83.Enabled = false;
                    C81.Enabled = false;
                    C82.Enabled = false;
                    C83.Enabled = false;
                    break;
                case 9:
                    A91.Enabled = false;
                    A92.Enabled = false;
                    A93.Enabled = false;
                    B91.Enabled = false;
                    B92.Enabled = false;
                    B93.Enabled = false;
                    C91.Enabled = false;
                    C92.Enabled = false;
                    C93.Enabled = false;
                    break;
                default:
                    break;
            }


        }

        public void ifFinnish()
        {
            //a way to tell if no one one

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

            //Set Values Back To False
            X.A11 = false;
            X.A12 = false;
            X.A13 = false;
            X.B11 = false;
            X.B12 = false;
            X.B13 = false;
            X.C11 = false;
            X.C12 = false;
            X.C13 = false;

            X.A21 = false;
            X.A22 = false;
            X.A23 = false;
            X.B21 = false;
            X.B22 = false;
            X.B23 = false;
            X.C21 = false;
            X.C22 = false;
            X.C23 = false;

            X.A31 = false;
            X.A32 = false;
            X.A33 = false;
            X.B31 = false;
            X.B32 = false;
            X.B33 = false;
            X.C31 = false;
            X.C32 = false;
            X.C33 = false;

            X.A41 = false;
            X.A42 = false;
            X.A43 = false;
            X.B41 = false;
            X.B42 = false;
            X.B43 = false;
            X.C41 = false;
            X.C42 = false;
            X.C43 = false;

            X.A51 = false;
            X.A52 = false;
            X.A53 = false;
            X.B51 = false;
            X.B52 = false;
            X.B53 = false;
            X.C51 = false;
            X.C52 = false;
            X.C53 = false;

            X.A61 = false;
            X.A62 = false;
            X.A63 = false;
            X.B61 = false;
            X.B62 = false;
            X.B63 = false;
            X.C61 = false;
            X.C62 = false;
            X.C63 = false;

            X.A71 = false;
            X.A72 = false;
            X.A73 = false;
            X.B71 = false;
            X.B72 = false;
            X.B73 = false;
            X.C71 = false;
            X.C72 = false;
            X.C73 = false;

            X.A81 = false;
            X.A82 = false;
            X.A83 = false;
            X.B81 = false;
            X.B82 = false;
            X.B83 = false;
            X.C81 = false;
            X.C82 = false;
            X.C83 = false;

            X.A91 = false;
            X.A92 = false;
            X.A93 = false;
            X.B91 = false;
            X.B92 = false;
            X.B93 = false;
            X.C91 = false;
            X.C92 = false;
            X.C93 = false;

            O.A11 = false;
            O.A12 = false;
            O.A13 = false;
            O.B11 = false;
            O.B12 = false;
            O.B13 = false;
            O.C11 = false;
            O.C12 = false;
            O.C13 = false;

            O.A21 = false;
            O.A22 = false;
            O.A23 = false;
            O.B21 = false;
            O.B22 = false;
            O.B23 = false;
            O.C21 = false;
            O.C22 = false;
            O.C23 = false;

            O.A31 = false;
            O.A32 = false;
            O.A33 = false;
            O.B31 = false;
            O.B32 = false;
            O.B33 = false;
            O.C31 = false;
            O.C32 = false;
            O.C33 = false;

            O.A41 = false;
            O.A42 = false;
            O.A43 = false;
            O.B41 = false;
            O.B42 = false;
            O.B43 = false;
            O.C41 = false;
            O.C42 = false;
            O.C43 = false;

            O.A51 = false;
            O.A52 = false;
            O.A53 = false;
            O.B51 = false;
            O.B52 = false;
            O.B53 = false;
            O.C51 = false;
            O.C52 = false;
            O.C53 = false;

            O.A61 = false;
            O.A62 = false;
            O.A63 = false;
            O.B61 = false;
            O.B62 = false;
            O.B63 = false;
            O.C61 = false;
            O.C62 = false;
            O.C63 = false;

            O.A71 = false;
            O.A72 = false;
            O.A73 = false;
            O.B71 = false;
            O.B72 = false;
            O.B73 = false;
            O.C71 = false;
            O.C72 = false;
            O.C73 = false;

            O.A81 = false;
            O.A82 = false;
            O.A83 = false;
            O.B81 = false;
            O.B82 = false;
            O.B83 = false;
            O.C81 = false;
            O.C82 = false;
            O.C83 = false;

            O.A91 = false;
            O.A92 = false;
            O.A93 = false;
            O.B91 = false;
            O.B92 = false;
            O.B93 = false;
            O.C91 = false;
            O.C92 = false;
            O.C93 = false;
        }
       

        

        private void A1_Click(object sender, EventArgs e)
        {
            setSquare('A', 1, 1);
        }

        private void A2_Click(object sender, EventArgs e)
        {
            setSquare('A', 1, 2);
        }

        private void A3_Click(object sender, EventArgs e)
        {
            setSquare('A', 1, 3);
        }

        private void B1_Click(object sender, EventArgs e)
        {
            setSquare('B', 1, 1);
        }

        private void B2_Click(object sender, EventArgs e)
        {
            setSquare('B', 1, 2);
        }

        private void B3_Click(object sender, EventArgs e)
        {
            setSquare('B', 1, 3);
        }

        private void C1_Click(object sender, EventArgs e)
        {
            setSquare('C', 1, 1);
        }

        private void C2_Click(object sender, EventArgs e)
        {
            setSquare('C', 1, 2);
        }

        private void C3_Click(object sender, EventArgs e)
        {
            setSquare('C', 1, 3);
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

        private void A21_Click(object sender, EventArgs e)
        {
            setSquare('A', 2, 1);
        }
    }
}
