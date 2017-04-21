using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        //Lets Do Some UNREALY HUGE SWITCH STATEMENT

        public void setSquare(char Letter, int Number, int Number2)
        {
            //idek how to debug this so i really hope it works
            if (turn == 'X')
            {
                switch (Letter)
                {
                    case 'A':
                        String name = "";
                        name += Letter;
                        name += Number;
                        name += Number2;
                        Controls[name].Text = "X";
                        Controls[name].Enabled = false;
                        X.A[Number - 1, Number2 - 1] = true;
                        turn = 'O';
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
