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

//Make The Program Know Who Won XD
//      Find And Replace "Done" With "Donex" and do the same thing for o. Then Change The Check Areas Function
//Make A Function To Choose What Square To Make The Player Play In
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



        public void UnBlankSquares(int area) {

            switch (area)
            {
                case 0:
                    for (int i = 1; i <= 9; i++)
                    {
                        UnBlankSquares(i);
                    }
                    break;
                case 1:
                    A11.Enabled = true;
                    A12.Enabled = true;
                    A13.Enabled = true;
                    B11.Enabled = true;
                    B12.Enabled = true;
                    B13.Enabled = true;
                    C11.Enabled = true;
                    C12.Enabled = true;
                    C13.Enabled = true;

                    break;
                case 2:
                    A21.Enabled = true;
                    A22.Enabled = true;
                    A23.Enabled = true;
                    B21.Enabled = true;
                    B22.Enabled = true;
                    B23.Enabled = true;
                    C21.Enabled = true;
                    C22.Enabled = true;
                    C23.Enabled = true;
                    break;
                case 3:
                    A31.Enabled = true;
                    A32.Enabled = true;
                    A33.Enabled = true;
                    B31.Enabled = true;
                    B32.Enabled = true;
                    B33.Enabled = true;
                    C31.Enabled = true;
                    C32.Enabled = true;
                    C33.Enabled = true;
                    break;
                case 4:
                    A41.Enabled = true;
                    A42.Enabled = true;
                    A43.Enabled = true;
                    B41.Enabled = true;
                    B42.Enabled = true;
                    B43.Enabled = true;
                    C41.Enabled = true;
                    C42.Enabled = true;
                    C43.Enabled = true;
                    break;
                case 5:
                    A51.Enabled = true;
                    A52.Enabled = true;
                    A53.Enabled = true;
                    B51.Enabled = true;
                    B52.Enabled = true;
                    B53.Enabled = true;
                    C51.Enabled = true;
                    C52.Enabled = true;
                    C53.Enabled = true;
                    break;
                case 6:
                    A61.Enabled = true;
                    A62.Enabled = true;
                    A63.Enabled = true;
                    B61.Enabled = true;
                    B62.Enabled = true;
                    B63.Enabled = true;
                    C61.Enabled = true;
                    C62.Enabled = true;
                    C63.Enabled = true;
                    break;
                case 7:
                    A71.Enabled = true;
                    A72.Enabled = true;
                    A73.Enabled = true;
                    B71.Enabled = true;
                    B72.Enabled = true;
                    B73.Enabled = true;
                    C71.Enabled = true;
                    C72.Enabled = true;
                    C73.Enabled = true;
                    break;
                case 8:
                    A81.Enabled = true;
                    A82.Enabled = true;
                    A83.Enabled = true;
                    B81.Enabled = true;
                    B82.Enabled = true;
                    B83.Enabled = true;
                    C81.Enabled = true;
                    C82.Enabled = true;
                    C83.Enabled = true;
                    break;
                case 9:
                    A91.Enabled = true;
                    A92.Enabled = true;
                    A93.Enabled = true;
                    B91.Enabled = true;
                    B92.Enabled = true;
                    B93.Enabled = true;
                    C91.Enabled = true;
                    C92.Enabled = true;
                    C93.Enabled = true;
                    break;
                default:
                    break;
            }


        }

        public void ifFinnish()
        {
            //a way to tell if no one won

        }

        public void BlankSquares(int area) {

            switch (area)
            {
                case 0:
                    for (int i = 1; i <= 9; i++)
                    {
                        BlankSquares(i);
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
      
        public int CheckAreas() {

            xPermutations();
            oPermutations();
            if (Square1Done)
            {
                BlankSquares(1);
            }

            if (Square2Done)
            {
                BlankSquares(2);
            }
            if (Square3Done)
            {
                BlankSquares(3);
            }
            if (Square4Done)
            {
                BlankSquares(4);
            }
            if (Square5Done)
            {
                BlankSquares(5);
            }
            if (Square6Done)
            {
                BlankSquares(6);
            }
            if (Square7Done)
            {
                BlankSquares(7);
            }
            if (Square8Done)
            {
                BlankSquares(8);
            }
            if (Square9Done)
            {
                BlankSquares(9);
            }

            if (UltimatePermutaions() == 1)
            {
                return 3;
            }

            return 100;
            
        }
        public void CheckWin()
        {
            if (CheckAreas() == 1)
            {
                BlankSquares(0);
                MessageBox.Show("X WINS!", "Tic Tac Toe");
            }

            if (CheckAreas() == 2)
            {
                BlankSquares(0);
                MessageBox.Show("O WINS!", "Tic Tac Toe");
            }

            if (CheckAreas() == 3)
            {
                BlankSquares(0);
                MessageBox.Show("Somone WON!!! hahahah");
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

        private void A22_Click(object sender, EventArgs e)
        {
            setSquare('A', 2, 2);
        }

        private void A23_Click(object sender, EventArgs e)
        {
            setSquare('A', 2, 3);
        }

        private void B21_Click(object sender, EventArgs e)
        {
            setSquare('B', 2, 1);
        }

        private void B22_Click(object sender, EventArgs e)
        {
            setSquare('B', 2, 2);
        }

        private void B23_Click(object sender, EventArgs e)
        {
            setSquare('B', 2, 3);
        }

        private void C21_Click(object sender, EventArgs e)
        {
            setSquare('C', 2, 1);
        }

        private void C22_Click(object sender, EventArgs e)
        {
            setSquare('C', 2, 2);
        }

        private void C23_Click(object sender, EventArgs e)
        {
            setSquare('C', 2, 3);
        }

        private void A31_Click(object sender, EventArgs e)
        {
            setSquare('A', 3, 1);
        }

        private void A32_Click(object sender, EventArgs e)
        {
            setSquare('A', 3, 2);
        }

        private void A33_Click(object sender, EventArgs e)
        {
            setSquare('A', 3, 3);
        }

        private void B31_Click(object sender, EventArgs e)
        {
            setSquare('B', 3, 1);
        }

        private void B32_Click(object sender, EventArgs e)
        {
            setSquare('B', 3, 2);
        }

        private void B33_Click(object sender, EventArgs e)
        {
            setSquare('B', 3, 3);
        }

        private void C31_Click(object sender, EventArgs e)
        {
            setSquare('C', 3, 1);
        }

        private void C32_Click(object sender, EventArgs e)
        {
            setSquare('C', 3, 2);
        }

        private void C33_Click(object sender, EventArgs e)
        {
            setSquare('C', 3, 3);
        }

        private void A41_Click(object sender, EventArgs e)
        {
            setSquare('A', 4, 1);
        }

        private void A42_Click(object sender, EventArgs e)
        {
            setSquare('A', 4, 2);
        }

        private void A43_Click(object sender, EventArgs e)
        {
            setSquare('A', 4, 3);
        }

        private void B41_Click(object sender, EventArgs e)
        {
            setSquare('B', 4, 1);
        }

        private void B42_Click(object sender, EventArgs e)
        {
            setSquare('B', 4, 2);
        }

        private void B43_Click(object sender, EventArgs e)
        {
            setSquare('B', 4, 3);
        }

        private void C41_Click(object sender, EventArgs e)
        {
            setSquare('C', 4, 1);
        }

        private void C42_Click(object sender, EventArgs e)
        {
            setSquare('C', 4, 2);
        }

        private void C43_Click(object sender, EventArgs e)
        {
            setSquare('C', 4, 3);
        }

        private void A51_Click(object sender, EventArgs e)
        {
            setSquare('A', 5, 1);
        }

        private void A52_Click(object sender, EventArgs e)
        {
            setSquare('A', 5, 2);
        }

        private void A53_Click(object sender, EventArgs e)
        {
            setSquare('A', 5, 3);
        }

        private void B51_Click(object sender, EventArgs e)
        {
            setSquare('B', 5, 1);
        }

        private void B52_Click(object sender, EventArgs e)
        {
            setSquare('B', 5, 2);
        }

        private void B53_Click(object sender, EventArgs e)
        {
            setSquare('B', 5, 3);
        }

        private void C51_Click(object sender, EventArgs e)
        {
            setSquare('C', 5, 1);
        }

        private void C52_Click(object sender, EventArgs e)
        {
            setSquare('C', 5, 2);
        }

        private void C53_Click(object sender, EventArgs e)
        {
            setSquare('C', 5, 3);
        }

        private void A61_Click(object sender, EventArgs e)
        {
            setSquare('A', 6, 1);
        }

        private void A62_Click(object sender, EventArgs e)
        {
            setSquare('A', 6, 2);
        }

        private void A63_Click(object sender, EventArgs e)
        {
            setSquare('A', 6, 3);
        }

        private void B61_Click(object sender, EventArgs e)
        {
            setSquare('B', 6, 1);
        }

        private void B62_Click(object sender, EventArgs e)
        {
            setSquare('B', 6, 2);
        }

        private void B63_Click(object sender, EventArgs e)
        {
            setSquare('B', 6, 3);
        }

        private void C61_Click(object sender, EventArgs e)
        {
            setSquare('C', 6, 1);
        }

        private void C62_Click(object sender, EventArgs e)
        {
            setSquare('C', 6, 2);
        }

        private void C63_Click(object sender, EventArgs e)
        {
            setSquare('C', 6, 3);
        }

        private void A71_Click(object sender, EventArgs e)
        {
            setSquare('A', 7, 1);
        }

        private void A72_Click(object sender, EventArgs e)
        {
            setSquare('A', 7, 2);
        }

        private void A73_Click(object sender, EventArgs e)
        {
            setSquare('A', 7, 3);
        }

        private void B71_Click(object sender, EventArgs e)
        {
            setSquare('B', 7, 1);
        }

        private void B72_Click(object sender, EventArgs e)
        {
            setSquare('B', 7, 2);
        }

        private void B73_Click(object sender, EventArgs e)
        {
            setSquare('B', 7, 3);
        }

        private void C71_Click(object sender, EventArgs e)
        {
            setSquare('C', 7, 1);
        }

        private void C72_Click(object sender, EventArgs e)
        {
            setSquare('C', 7, 2);
        }

        private void C73_Click(object sender, EventArgs e)
        {
            setSquare('C', 7, 3);
        }

        private void A81_Click(object sender, EventArgs e)
        {
            setSquare('A', 8, 1);
        }

        private void A82_Click(object sender, EventArgs e)
        {
            setSquare('A', 8, 2);
        }

        private void A83_Click(object sender, EventArgs e)
        {
            setSquare('A', 8, 3);
        }

        private void B81_Click(object sender, EventArgs e)
        {
            setSquare('B', 8, 1);
        }

        private void B82_Click(object sender, EventArgs e)
        {
            setSquare('B', 8, 2);
        }

        private void B83_Click(object sender, EventArgs e)
        {
            setSquare('B', 8, 3);
        }

        private void C81_Click(object sender, EventArgs e)
        {
            setSquare('C', 8, 1);
        }

        private void C82_Click(object sender, EventArgs e)
        {
            setSquare('C', 8, 2);
        }

        private void C83_Click(object sender, EventArgs e)
        {
            setSquare('C', 8, 3);
        }

        private void A91_Click(object sender, EventArgs e)
        {
            setSquare('A', 9, 1);
        }

        private void A92_Click(object sender, EventArgs e)
        {
            setSquare('A', 9, 2);
        }

        private void A93_Click(object sender, EventArgs e)
        {
            setSquare('A', 9, 3);
        }

        private void B91_Click(object sender, EventArgs e)
        {
            setSquare('B', 9, 1);
        }

        private void B92_Click(object sender, EventArgs e)
        {
            setSquare('B', 9, 2);
        }

        private void B93_Click(object sender, EventArgs e)
        {
            setSquare('B', 9, 3);
        }

        private void C91_Click(object sender, EventArgs e)
        {
            setSquare('C', 9, 1);
        }

        private void C92_Click(object sender, EventArgs e)
        {
            setSquare('C', 9, 2);
        }

        private void C93_Click(object sender, EventArgs e)
        {
            setSquare('C', 9, 3);
        }
    }
}
