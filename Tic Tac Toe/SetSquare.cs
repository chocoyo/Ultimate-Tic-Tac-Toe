using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public void setSquare(char Letter, int Number, int Number2)
        {
            //Function To Mark Squares For The Respective Player
            if (turn == 'X')
            {
                switch (Letter)
                {
                    case 'A':
                        String name = "";   //Initalize Name
                        name += Letter;     //Add The Letter
                        name += Number;     //Add The Big Sqaure 1-9 Index
                        name += Number2;    //Add The Vertical 1-3 Row Index
                        Controls[name].Text = "X"; //Change Text On That Button
                        Controls[name].Enabled = false; //Disable That Button
                        X.A[Number - 1, Number2 - 1] = true; //Mark The Corrisponding Bool Var As Taken
                        turn = 'O'; //Switch The Turn
                        break;

                    case 'B':
                        name = "";
                        name += Letter;
                        name += Number;
                        name += Number2;
                        Controls[name].Text = "X";
                        Controls[name].Enabled = false;
                        X.B[Number - 1, Number2 - 1] = true;
                        turn = 'O';
                        break;

                    case 'C':
                        name = "";
                        name += Letter;
                        name += Number;
                        name += Number2;
                        Controls[name].Text = "X";
                        Controls[name].Enabled = false;
                        X.C[Number - 1, Number2 - 1] = true;
                        turn = 'O';
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
                        String name = "";
                        name += Letter;
                        name += Number;
                        name += Number2;
                        Controls[name].Text = "O";
                        Controls[name].Enabled = false;
                        O.A[Number - 1, Number2 - 1] = true;
                        turn = 'X';
                        break;

                    case 'B':
                        name = "";
                        name += Letter;
                        name += Number;
                        name += Number2;
                        Controls[name].Text = "O";
                        Controls[name].Enabled = false;
                        O.B[Number - 1, Number2 - 1] = true;
                        turn = 'X';
                        break;

                    case 'C':
                        name = "";
                        name += Letter;
                        name += Number;
                        name += Number2;
                        Controls[name].Text = "O";
                        Controls[name].Enabled = false;
                        O.C[Number - 1, Number2 - 1] = true;
                        turn = 'X';
                        break;

                    default:
                        break;
                }
            }
            plays++;
            CheckWin();
        }
    }
}
