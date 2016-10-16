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

                switch (Number)
                {
                    case 1:
                        switch (Letter)
                        {
                            case 'A':
                                switch (Number2)
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
                                switch (Number2)
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
                                switch (Number2)
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
                        break;
                    case 2:
                        switch (Letter)
                        {
                            case 'A':
                                switch (Number2)
                                {
                                    case 1:
                                        A21.Text = "X";
                                        A21.Enabled = false;
                                        X.A21 = true;
                                        turn = 'O';
                                        break;
                                    case 2:
                                        A22.Text = "X";
                                        A22.Enabled = false;
                                        X.A22 = true;
                                        turn = 'O';
                                        break;
                                    case 3:
                                        A23.Text = "X";
                                        A23.Enabled = false;
                                        X.A23 = true;
                                        turn = 'O';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'B':
                                switch (Number2)
                                {
                                    case 1:
                                        B21.Text = "X";
                                        B21.Enabled = false;
                                        X.B21 = true;
                                        turn = 'O';
                                        break;
                                    case 2:
                                        B22.Text = "X";
                                        B22.Enabled = false;
                                        X.B22 = true;
                                        turn = 'O';
                                        break;
                                    case 3:
                                        B23.Text = "X";
                                        B23.Enabled = false;
                                        X.B23 = true;
                                        turn = 'O';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'C':
                                switch (Number2)
                                {
                                    case 1:
                                        C21.Text = "X";
                                        C21.Enabled = false;
                                        X.C21 = true;
                                        turn = 'O';
                                        break;
                                    case 2:
                                        C22.Text = "X";
                                        C22.Enabled = false;
                                        X.C22 = true;
                                        turn = 'O';
                                        break;
                                    case 3:
                                        C23.Text = "X";
                                        C23.Enabled = false;
                                        X.C23 = true;
                                        turn = 'O';
                                        break;
                                    default:
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;
                    case 3:
                        switch (Letter)
                        {
                            case 'A':
                                switch (Number2)
                                {
                                    case 1:
                                        A31.Text = "X";
                                        A31.Enabled = false;
                                        X.A31 = true;
                                        turn = 'O';
                                        break;
                                    case 2:
                                        A32.Text = "X";
                                        A32.Enabled = false;
                                        X.A32 = true;
                                        turn = 'O';
                                        break;
                                    case 3:
                                        A33.Text = "X";
                                        A33.Enabled = false;
                                        X.A33 = true;
                                        turn = 'O';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'B':
                                switch (Number2)
                                {
                                    case 1:
                                        B31.Text = "X";
                                        B31.Enabled = false;
                                        X.B31 = true;
                                        turn = 'O';
                                        break;
                                    case 2:
                                        B32.Text = "X";
                                        B32.Enabled = false;
                                        X.B32 = true;
                                        turn = 'O';
                                        break;
                                    case 3:
                                        B33.Text = "X";
                                        B33.Enabled = false;
                                        X.B33 = true;
                                        turn = 'O';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'C':
                                switch (Number2)
                                {
                                    case 1:
                                        C31.Text = "X";
                                        C31.Enabled = false;
                                        X.C31 = true;
                                        turn = 'O';
                                        break;
                                    case 2:
                                        C32.Text = "X";
                                        C32.Enabled = false;
                                        X.C32 = true;
                                        turn = 'O';
                                        break;
                                    case 3:
                                        C33.Text = "X";
                                        C33.Enabled = false;
                                        X.C33 = true;
                                        turn = 'O';
                                        break;
                                    default:
                                        break;
                                }
                                break;

                            default:
                                break;
                        }

                        break;
                    case 4:
                        switch (Letter)
                        {
                            case 'A':
                                switch (Number2)
                                {
                                    case 1:
                                        A41.Text = "X";
                                        A41.Enabled = false;
                                        X.A41 = true;
                                        turn = 'O';
                                        break;
                                    case 2:
                                        A42.Text = "X";
                                        A42.Enabled = false;
                                        X.A42 = true;
                                        turn = 'O';
                                        break;
                                    case 3:
                                        A43.Text = "X";
                                        A43.Enabled = false;
                                        X.A43 = true;
                                        turn = 'O';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'B':
                                switch (Number2)
                                {
                                    case 1:
                                        B41.Text = "X";
                                        B41.Enabled = false;
                                        X.B41 = true;
                                        turn = 'O';
                                        break;
                                    case 2:
                                        B42.Text = "X";
                                        B42.Enabled = false;
                                        X.B42 = true;
                                        turn = 'O';
                                        break;
                                    case 3:
                                        B43.Text = "X";
                                        B43.Enabled = false;
                                        X.B43 = true;
                                        turn = 'O';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'C':
                                switch (Number2)
                                {
                                    case 1:
                                        C41.Text = "X";
                                        C41.Enabled = false;
                                        X.C41 = true;
                                        turn = 'O';
                                        break;
                                    case 2:
                                        C42.Text = "X";
                                        C42.Enabled = false;
                                        X.C42 = true;
                                        turn = 'O';
                                        break;
                                    case 3:
                                        C43.Text = "X";
                                        C43.Enabled = false;
                                        X.C43 = true;
                                        turn = 'O';
                                        break;
                                    default:
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;
                    case 5:
                        switch (Letter)
                        {
                            case 'A':
                                switch (Number2)
                                {
                                    case 1:
                                        A51.Text = "X";
                                        A51.Enabled = false;
                                        X.A51 = true;
                                        turn = 'O';
                                        break;
                                    case 2:
                                        A52.Text = "X";
                                        A52.Enabled = false;
                                        X.A52 = true;
                                        turn = 'O';
                                        break;
                                    case 3:
                                        A53.Text = "X";
                                        A53.Enabled = false;
                                        X.A53 = true;
                                        turn = 'O';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'B':
                                switch (Number2)
                                {
                                    case 1:
                                        B51.Text = "X";
                                        B51.Enabled = false;
                                        X.B51 = true;
                                        turn = 'O';
                                        break;
                                    case 2:
                                        B52.Text = "X";
                                        B52.Enabled = false;
                                        X.B52 = true;
                                        turn = 'O';
                                        break;
                                    case 3:
                                        B53.Text = "X";
                                        B53.Enabled = false;
                                        X.B53 = true;
                                        turn = 'O';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'C':
                                switch (Number2)
                                {
                                    case 1:
                                        C51.Text = "X";
                                        C51.Enabled = false;
                                        X.C51 = true;
                                        turn = 'O';
                                        break;
                                    case 2:
                                        C52.Text = "X";
                                        C52.Enabled = false;
                                        X.C52 = true;
                                        turn = 'O';
                                        break;
                                    case 3:
                                        C53.Text = "X";
                                        C53.Enabled = false;
                                        X.C53 = true;
                                        turn = 'O';
                                        break;
                                    default:
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;
                    case 6:
                        switch (Letter)
                        {
                            case 'A':
                                switch (Number2)
                                {
                                    case 1:
                                        A61.Text = "X";
                                        A61.Enabled = false;
                                        X.A61 = true;
                                        turn = 'O';
                                        break;
                                    case 2:
                                        A62.Text = "X";
                                        A62.Enabled = false;
                                        X.A62 = true;
                                        turn = 'O';
                                        break;
                                    case 3:
                                        A63.Text = "X";
                                        A63.Enabled = false;
                                        X.A63 = true;
                                        turn = 'O';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'B':
                                switch (Number2)
                                {
                                    case 1:
                                        B61.Text = "X";
                                        B61.Enabled = false;
                                        X.B61 = true;
                                        turn = 'O';
                                        break;
                                    case 2:
                                        B62.Text = "X";
                                        B62.Enabled = false;
                                        X.B62 = true;
                                        turn = 'O';
                                        break;
                                    case 3:
                                        B63.Text = "X";
                                        B63.Enabled = false;
                                        X.B63 = true;
                                        turn = 'O';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'C':
                                switch (Number2)
                                {
                                    case 1:
                                        C61.Text = "X";
                                        C61.Enabled = false;
                                        X.C61 = true;
                                        turn = 'O';
                                        break;
                                    case 2:
                                        C62.Text = "X";
                                        C62.Enabled = false;
                                        X.C62 = true;
                                        turn = 'O';
                                        break;
                                    case 3:
                                        C63.Text = "X";
                                        C63.Enabled = false;
                                        X.C63 = true;
                                        turn = 'O';
                                        break;
                                    default:
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;
                    case 7:
                        switch (Letter)
                        {
                            case 'A':
                                switch (Number2)
                                {
                                    case 1:
                                        A71.Text = "X";
                                        A71.Enabled = false;
                                        X.A71 = true;
                                        turn = 'O';
                                        break;
                                    case 2:
                                        A72.Text = "X";
                                        A72.Enabled = false;
                                        X.A72 = true;
                                        turn = 'O';
                                        break;
                                    case 3:
                                        A73.Text = "X";
                                        A73.Enabled = false;
                                        X.A73 = true;
                                        turn = 'O';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'B':
                                switch (Number2)
                                {
                                    case 1:
                                        B71.Text = "X";
                                        B71.Enabled = false;
                                        X.B71 = true;
                                        turn = 'O';
                                        break;
                                    case 2:
                                        B72.Text = "X";
                                        B72.Enabled = false;
                                        X.B72 = true;
                                        turn = 'O';
                                        break;
                                    case 3:
                                        B73.Text = "X";
                                        B73.Enabled = false;
                                        X.B73 = true;
                                        turn = 'O';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'C':
                                switch (Number2)
                                {
                                    case 1:
                                        C71.Text = "X";
                                        C71.Enabled = false;
                                        X.C71 = true;
                                        turn = 'O';
                                        break;
                                    case 2:
                                        C72.Text = "X";
                                        C72.Enabled = false;
                                        X.C72 = true;
                                        turn = 'O';
                                        break;
                                    case 3:
                                        C73.Text = "X";
                                        C73.Enabled = false;
                                        X.C73 = true;
                                        turn = 'O';
                                        break;
                                    default:
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;
                    case 8:
                        switch (Letter)
                        {
                            case 'A':
                                switch (Number2)
                                {
                                    case 1:
                                        A81.Text = "X";
                                        A81.Enabled = false;
                                        X.A81 = true;
                                        turn = 'O';
                                        break;
                                    case 2:
                                        A82.Text = "X";
                                        A82.Enabled = false;
                                        X.A82 = true;
                                        turn = 'O';
                                        break;
                                    case 3:
                                        A83.Text = "X";
                                        A83.Enabled = false;
                                        X.A83 = true;
                                        turn = 'O';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'B':
                                switch (Number2)
                                {
                                    case 1:
                                        B81.Text = "X";
                                        B81.Enabled = false;
                                        X.B81 = true;
                                        turn = 'O';
                                        break;
                                    case 2:
                                        B82.Text = "X";
                                        B82.Enabled = false;
                                        X.B82 = true;
                                        turn = 'O';
                                        break;
                                    case 3:
                                        B83.Text = "X";
                                        B83.Enabled = false;
                                        X.B83 = true;
                                        turn = 'O';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'C':
                                switch (Number2)
                                {
                                    case 1:
                                        C81.Text = "X";
                                        C81.Enabled = false;
                                        X.C81 = true;
                                        turn = 'O';
                                        break;
                                    case 2:
                                        C82.Text = "X";
                                        C82.Enabled = false;
                                        X.C82 = true;
                                        turn = 'O';
                                        break;
                                    case 3:
                                        C83.Text = "X";
                                        C83.Enabled = false;
                                        X.C83 = true;
                                        turn = 'O';
                                        break;
                                    default:
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;
                    case 9:
                        switch (Letter)
                        {
                            case 'A':
                                switch (Number2)
                                {
                                    case 1:
                                        A91.Text = "X";
                                        A91.Enabled = false;
                                        X.A91 = true;
                                        turn = 'O';
                                        break;
                                    case 2:
                                        A92.Text = "X";
                                        A92.Enabled = false;
                                        X.A92 = true;
                                        turn = 'O';
                                        break;
                                    case 3:
                                        A93.Text = "X";
                                        A93.Enabled = false;
                                        X.A93 = true;
                                        turn = 'O';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'B':
                                switch (Number2)
                                {
                                    case 1:
                                        B91.Text = "X";
                                        B91.Enabled = false;
                                        X.B91 = true;
                                        turn = 'O';
                                        break;
                                    case 2:
                                        B92.Text = "X";
                                        B92.Enabled = false;
                                        X.B92 = true;
                                        turn = 'O';
                                        break;
                                    case 3:
                                        B93.Text = "X";
                                        B93.Enabled = false;
                                        X.B93 = true;
                                        turn = 'O';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'C':
                                switch (Number2)
                                {
                                    case 1:
                                        C91.Text = "X";
                                        C91.Enabled = false;
                                        X.C91 = true;
                                        turn = 'O';
                                        break;
                                    case 2:
                                        C92.Text = "X";
                                        C92.Enabled = false;
                                        X.C92 = true;
                                        turn = 'O';
                                        break;
                                    case 3:
                                        C93.Text = "X";
                                        C93.Enabled = false;
                                        X.C93 = true;
                                        turn = 'O';
                                        break;
                                    default:
                                        break;
                                }
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

                switch (Number)
                {
                    case 1:
                        switch (Letter)
                        {
                            case 'A':
                                switch (Number2)
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
                                switch (Number2)
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
                                switch (Number2)
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
                        break;
                    case 2:
                        switch (Letter)
                        {
                            case 'A':
                                switch (Number2)
                                {
                                    case 1:
                                        A21.Text = "O";
                                        A21.Enabled = false;
                                        O.A21 = true;
                                        turn = 'X';
                                        break;
                                    case 2:
                                        A22.Text = "O";
                                        A22.Enabled = false;
                                        O.A22 = true;
                                        turn = 'X';
                                        break;
                                    case 3:
                                        A23.Text = "O";
                                        A23.Enabled = false;
                                        O.A23 = true;
                                        turn = 'X';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'B':
                                switch (Number2)
                                {
                                    case 1:
                                        B21.Text = "O";
                                        B21.Enabled = false;
                                        O.B21 = true;
                                        turn = 'X';
                                        break;
                                    case 2:
                                        B22.Text = "O";
                                        B22.Enabled = false;
                                        O.B22 = true;
                                        turn = 'X';
                                        break;
                                    case 3:
                                        B23.Text = "O";
                                        B23.Enabled = false;
                                        O.B23 = true;
                                        turn = 'X';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'C':
                                switch (Number2)
                                {
                                    case 1:
                                        C21.Text = "O";
                                        C21.Enabled = false;
                                        O.C21 = true;
                                        turn = 'X';
                                        break;
                                    case 2:
                                        C22.Text = "O";
                                        C22.Enabled = false;
                                        O.C22 = true;
                                        turn = 'X';
                                        break;
                                    case 3:
                                        C23.Text = "O";
                                        C23.Enabled = false;
                                        O.C23 = true;
                                        turn = 'X';
                                        break;
                                    default:
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;
                    case 3:
                        switch (Letter)
                        {
                            case 'A':
                                switch (Number2)
                                {
                                    case 1:
                                        A31.Text = "O";
                                        A31.Enabled = false;
                                        O.A31 = true;
                                        turn = 'X';
                                        break;
                                    case 2:
                                        A32.Text = "O";
                                        A32.Enabled = false;
                                        O.A32 = true;
                                        turn = 'X';
                                        break;
                                    case 3:
                                        A33.Text = "O";
                                        A33.Enabled = false;
                                        O.A33 = true;
                                        turn = 'X';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'B':
                                switch (Number2)
                                {
                                    case 1:
                                        B31.Text = "O";
                                        B31.Enabled = false;
                                        O.B31 = true;
                                        turn = 'X';
                                        break;
                                    case 2:
                                        B32.Text = "O";
                                        B32.Enabled = false;
                                        O.B32 = true;
                                        turn = 'X';
                                        break;
                                    case 3:
                                        B33.Text = "O";
                                        B33.Enabled = false;
                                        O.B33 = true;
                                        turn = 'X';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'C':
                                switch (Number2)
                                {
                                    case 1:
                                        C31.Text = "O";
                                        C31.Enabled = false;
                                        O.C31 = true;
                                        turn = 'X';
                                        break;
                                    case 2:
                                        C32.Text = "O";
                                        C32.Enabled = false;
                                        O.C32 = true;
                                        turn = 'X';
                                        break;
                                    case 3:
                                        C33.Text = "O";
                                        C33.Enabled = false;
                                        O.C33 = true;
                                        turn = 'X';
                                        break;
                                    default:
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;
                    case 4:
                        switch (Letter)
                        {
                            case 'A':
                                switch (Number2)
                                {
                                    case 1:
                                        A41.Text = "O";
                                        A41.Enabled = false;
                                        O.A41 = true;
                                        turn = 'X';
                                        break;
                                    case 2:
                                        A42.Text = "O";
                                        A42.Enabled = false;
                                        O.A42 = true;
                                        turn = 'X';
                                        break;
                                    case 3:
                                        A43.Text = "O";
                                        A43.Enabled = false;
                                        O.A43 = true;
                                        turn = 'X';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'B':
                                switch (Number2)
                                {
                                    case 1:
                                        B41.Text = "O";
                                        B41.Enabled = false;
                                        O.B41 = true;
                                        turn = 'X';
                                        break;
                                    case 2:
                                        B42.Text = "O";
                                        B42.Enabled = false;
                                        O.B42 = true;
                                        turn = 'X';
                                        break;
                                    case 3:
                                        B43.Text = "O";
                                        B43.Enabled = false;
                                        O.B43 = true;
                                        turn = 'X';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'C':
                                switch (Number2)
                                {
                                    case 1:
                                        C41.Text = "O";
                                        C41.Enabled = false;
                                        O.C41 = true;
                                        turn = 'X';
                                        break;
                                    case 2:
                                        C42.Text = "O";
                                        C42.Enabled = false;
                                        O.C42 = true;
                                        turn = 'X';
                                        break;
                                    case 3:
                                        C43.Text = "O";
                                        C43.Enabled = false;
                                        O.C43 = true;
                                        turn = 'X';
                                        break;
                                    default:
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;
                    case 5:
                        switch (Letter)
                        {
                            case 'A':
                                switch (Number2)
                                {
                                    case 1:
                                        A51.Text = "O";
                                        A51.Enabled = false;
                                        O.A51 = true;
                                        turn = 'X';
                                        break;
                                    case 2:
                                        A52.Text = "O";
                                        A52.Enabled = false;
                                        O.A52 = true;
                                        turn = 'X';
                                        break;
                                    case 3:
                                        A53.Text = "O";
                                        A53.Enabled = false;
                                        O.A53 = true;
                                        turn = 'X';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'B':
                                switch (Number2)
                                {
                                    case 1:
                                        B51.Text = "O";
                                        B51.Enabled = false;
                                        O.B51 = true;
                                        turn = 'X';
                                        break;
                                    case 2:
                                        B52.Text = "O";
                                        B52.Enabled = false;
                                        O.B52 = true;
                                        turn = 'X';
                                        break;
                                    case 3:
                                        B53.Text = "O";
                                        B53.Enabled = false;
                                        O.B53 = true;
                                        turn = 'X';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'C':
                                switch (Number2)
                                {
                                    case 1:
                                        C51.Text = "O";
                                        C51.Enabled = false;
                                        O.C51 = true;
                                        turn = 'X';
                                        break;
                                    case 2:
                                        C52.Text = "O";
                                        C52.Enabled = false;
                                        O.C52 = true;
                                        turn = 'X';
                                        break;
                                    case 3:
                                        C53.Text = "O";
                                        C53.Enabled = false;
                                        O.C53 = true;
                                        turn = 'X';
                                        break;
                                    default:
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;
                    case 6:
                        switch (Letter)
                        {
                            case 'A':
                                switch (Number2)
                                {
                                    case 1:
                                        A61.Text = "O";
                                        A61.Enabled = false;
                                        O.A61 = true;
                                        turn = 'X';
                                        break;
                                    case 2:
                                        A62.Text = "O";
                                        A62.Enabled = false;
                                        O.A62 = true;
                                        turn = 'X';
                                        break;
                                    case 3:
                                        A63.Text = "O";
                                        A63.Enabled = false;
                                        O.A63 = true;
                                        turn = 'X';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'B':
                                switch (Number2)
                                {
                                    case 1:
                                        B61.Text = "O";
                                        B61.Enabled = false;
                                        O.B61 = true;
                                        turn = 'X';
                                        break;
                                    case 2:
                                        B62.Text = "O";
                                        B62.Enabled = false;
                                        O.B62 = true;
                                        turn = 'X';
                                        break;
                                    case 3:
                                        B63.Text = "O";
                                        B63.Enabled = false;
                                        O.B63 = true;
                                        turn = 'X';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'C':
                                switch (Number2)
                                {
                                    case 1:
                                        C61.Text = "O";
                                        C61.Enabled = false;
                                        O.C61 = true;
                                        turn = 'X';
                                        break;
                                    case 2:
                                        C62.Text = "O";
                                        C62.Enabled = false;
                                        O.C62 = true;
                                        turn = 'X';
                                        break;
                                    case 3:
                                        C63.Text = "O";
                                        C63.Enabled = false;
                                        O.C63 = true;
                                        turn = 'X';
                                        break;
                                    default:
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;
                    case 7:
                        switch (Letter)
                        {
                            case 'A':
                                switch (Number2)
                                {
                                    case 1:
                                        A71.Text = "O";
                                        A71.Enabled = false;
                                        O.A71 = true;
                                        turn = 'X';
                                        break;
                                    case 2:
                                        A72.Text = "O";
                                        A72.Enabled = false;
                                        O.A72 = true;
                                        turn = 'X';
                                        break;
                                    case 3:
                                        A73.Text = "O";
                                        A73.Enabled = false;
                                        O.A73 = true;
                                        turn = 'X';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'B':
                                switch (Number2)
                                {
                                    case 1:
                                        B71.Text = "O";
                                        B71.Enabled = false;
                                        O.B71 = true;
                                        turn = 'X';
                                        break;
                                    case 2:
                                        B72.Text = "O";
                                        B72.Enabled = false;
                                        O.B72 = true;
                                        turn = 'X';
                                        break;
                                    case 3:
                                        B73.Text = "O";
                                        B73.Enabled = false;
                                        O.B73 = true;
                                        turn = 'X';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'C':
                                switch (Number2)
                                {
                                    case 1:
                                        C71.Text = "O";
                                        C71.Enabled = false;
                                        O.C71 = true;
                                        turn = 'X';
                                        break;
                                    case 2:
                                        C72.Text = "O";
                                        C72.Enabled = false;
                                        O.C72 = true;
                                        turn = 'X';
                                        break;
                                    case 3:
                                        C73.Text = "O";
                                        C73.Enabled = false;
                                        O.C73 = true;
                                        turn = 'X';
                                        break;
                                    default:
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;
                    case 8:
                        switch (Letter)
                        {
                            case 'A':
                                switch (Number2)
                                {
                                    case 1:
                                        A81.Text = "O";
                                        A81.Enabled = false;
                                        O.A81 = true;
                                        turn = 'X';
                                        break;
                                    case 2:
                                        A82.Text = "O";
                                        A82.Enabled = false;
                                        O.A82 = true;
                                        turn = 'X';
                                        break;
                                    case 3:
                                        A83.Text = "O";
                                        A83.Enabled = false;
                                        O.A83 = true;
                                        turn = 'X';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'B':
                                switch (Number2)
                                {
                                    case 1:
                                        B81.Text = "O";
                                        B81.Enabled = false;
                                        O.B81 = true;
                                        turn = 'X';
                                        break;
                                    case 2:
                                        B82.Text = "O";
                                        B82.Enabled = false;
                                        O.B82 = true;
                                        turn = 'X';
                                        break;
                                    case 3:
                                        B83.Text = "O";
                                        B83.Enabled = false;
                                        O.B83 = true;
                                        turn = 'X';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'C':
                                switch (Number2)
                                {
                                    case 1:
                                        C81.Text = "O";
                                        C81.Enabled = false;
                                        O.C81 = true;
                                        turn = 'X';
                                        break;
                                    case 2:
                                        C82.Text = "O";
                                        C82.Enabled = false;
                                        O.C82 = true;
                                        turn = 'X';
                                        break;
                                    case 3:
                                        C83.Text = "O";
                                        C83.Enabled = false;
                                        O.C83 = true;
                                        turn = 'X';
                                        break;
                                    default:
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;
                    case 9:
                        switch (Letter)
                        {
                            case 'A':
                                switch (Number2)
                                {
                                    case 1:
                                        A91.Text = "O";
                                        A91.Enabled = false;
                                        O.A91 = true;
                                        turn = 'X';
                                        break;
                                    case 2:
                                        A92.Text = "O";
                                        A92.Enabled = false;
                                        O.A92 = true;
                                        turn = 'X';
                                        break;
                                    case 3:
                                        A93.Text = "O";
                                        A93.Enabled = false;
                                        O.A93 = true;
                                        turn = 'X';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'B':
                                switch (Number2)
                                {
                                    case 1:
                                        B91.Text = "O";
                                        B91.Enabled = false;
                                        O.B91 = true;
                                        turn = 'X';
                                        break;
                                    case 2:
                                        B92.Text = "O";
                                        B92.Enabled = false;
                                        O.B92 = true;
                                        turn = 'X';
                                        break;
                                    case 3:
                                        B93.Text = "O";
                                        B93.Enabled = false;
                                        O.B93 = true;
                                        turn = 'X';
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 'C':
                                switch (Number2)
                                {
                                    case 1:
                                        C91.Text = "O";
                                        C91.Enabled = false;
                                        O.C91 = true;
                                        turn = 'X';
                                        break;
                                    case 2:
                                        C92.Text = "O";
                                        C92.Enabled = false;
                                        O.C92 = true;
                                        turn = 'X';
                                        break;
                                    case 3:
                                        C93.Text = "O";
                                        C93.Enabled = false;
                                        O.C93 = true;
                                        turn = 'X';
                                        break;
                                    default:
                                        break;
                                }
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
            CheckWin();

        }

    }

    }
