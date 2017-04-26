﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Things to do

//This Is Code For When I Finally Clean Things Up

                        //for (int k = 0; k< 3; k++)
                        //{
                        //    for (int i = 0; i< 9; i++)
                        //    {
                        //        for (int p = 0; p< 3; p++)
                        //        {
                        //            if (!X.A[i, p] && !O.A[i, p])
                        //            {
                        //                String name = "";
                        //                char c = (k == 0) ? 'A' : (k == 1) ? 'B' : 'C';
                        //                name += c;
                        //                name += (i + 1);
                        //                name += (p + 1);
                        //                Controls[name].Enabled = true;
                        //            }
                        //            if (!X.B[i, p] && !O.B[i, p])
                        //            {
                        //                String name = "";
                        //                char c = (k == 0) ? 'A' : (k == 1) ? 'B' : 'C';
                        //                name += c;
                        //                name += (i + 1);
                        //                name += (p + 1);
                        //                Controls[name].Enabled = true;
                        //            }
                        //            if (!X.C[i, p] && !O.C[i, p])
                        //            {
                        //                String name = "";
                        //                char c = (k == 0) ? 'A' : (k == 1) ? 'B' : 'C';
                        //                name += c;
                        //                name += (i + 1);
                        //                name += (p + 1);
                        //                Controls[name].Enabled = true;
                        //            }
                        //        }
                        //    }
                        //}




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
            //Initailize The All SqaureDone Variables To False
            for (int i = 0; i < 9; i++)
            {
                SquareDoneO[i] = false;
                SquareDoneX[i] = false;
            }
        }

        //Declarations
        char turn = 'X';
        int plays = 0;
        Squares X = new Squares();
        Squares O = new Squares();
        bool[] SquareDoneX = new bool[9];
        bool[] SquareDoneO = new bool[9];
        bool Finnished = false;
        int forcedArea;
        bool CPU = false;
        bool wildcard = false;

        public void Wildcard()
        {

            //Function For When The User Selects Are Square That Is Already Filled "Wildcard"
            if (!SquareDoneO[0] && !SquareDoneX[0])
            {
                UnBlankSquares(1);
            }

            if (!SquareDoneO[1] && !SquareDoneX[1])
            {
                UnBlankSquares(2);
            }

            if (!SquareDoneO[2] && !SquareDoneX[2])
            {
                UnBlankSquares(3);
            }

            if (!SquareDoneO[3] && !SquareDoneX[3])
            {
                UnBlankSquares(4);
            }
            if (!SquareDoneO[4] && !SquareDoneX[4])
            {
                UnBlankSquares(5);
            }
            if (!SquareDoneO[5] && !SquareDoneX[5])
            {
                UnBlankSquares(6);
            }
            if (!SquareDoneO[6] && !SquareDoneX[6])
            {
                UnBlankSquares(7);
            }
            if (!SquareDoneO[7] && !SquareDoneX[7])
            {
                UnBlankSquares(8);
            }
            if (!SquareDoneO[8] && !SquareDoneX[8])
            {
                UnBlankSquares(9);
            }
            cpu(true);
        }

        public void UnBlankSquares(int area)
        {
            //The Function To UnBlank Certain Or All Squares
            switch (area)
            {
                case 0:
                    for (int i = 1; i <= 9; i++)
                    {
                        UnBlankSquares(i);
                    }
                    break;
                case 1:
                    if (!SquareDoneX[0] && !SquareDoneO[0]) //Check To Make Sure The Sqaure Has Not Been Won
                    {
                        int i = 0;
                        for (int p = 0; p < 3; p++)
                        {
                            if (!X.A[i, p] && !O.A[i, p])
                            {
                                String name = "";   //Initalize Name
                                char c = 'A';       //Make The Letter
                                name += c;          //Add The Letter
                                name += (i + 1);    //Add The Big Sqaure 1-9 Index Adjusting For Zero Base
                                name += (p + 1);    //Add The Vertical 1-3 Row Index Adjusting For Zero Base
                                Controls[name].Enabled = true; //Enable The Selected Button
                            }
                            if (!X.B[i, p] && !O.B[i, p])
                            {
                                String name = "";
                                char c = 'B';
                                name += c;
                                name += (i + 1);
                                name += (p + 1);
                                Controls[name].Enabled = true;
                            }
                            if (!X.C[i, p] && !O.C[i, p])
                            {
                                String name = "";
                                char c = 'C';
                                name += c;
                                name += (i+1);
                                name += (p + 1);
                                Controls[name].Enabled = true;
                            }
                        }
                    }
                    else
                    {
                        Wildcard();
                    }
                    break;
                case 2:
                    if (!SquareDoneO[1] && !SquareDoneX[1])
                    {
                        int i = (area - 1);
                        for (int k = 0; k < 3; k++)
                        {
                            for (int p = 0; p < 3; p++)
                            {
                                if (!X.A[i, p] && !O.A[i, p])
                                {
                                    String name = "";
                                    char c = 'A';
                                    name += c;
                                    name += (i + 1);
                                    name += (p + 1);
                                    Controls[name].Enabled = true;
                                }
                                if (!X.B[i, p] && !O.B[i, p])
                                {
                                    String name = "";
                                    char c = 'B';
                                    name += c;
                                    name += (i + 1);
                                    name += (p + 1);
                                    Controls[name].Enabled = true;
                                }
                                if (!X.C[i, p] && !O.C[i, p])
                                {
                                    String name = "";
                                    char c = 'C';
                                    name += c;
                                    name += (i+1);
                                    name += (p + 1);
                                    Controls[name].Enabled = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        Wildcard();
                    }
                    break;
                case 3:
                    if (!SquareDoneO[2] && !SquareDoneX[2])
                    {
                        int i = (area - 1);
                        for (int k = 0; k < 3; k++)
                        {
                            for (int p = 0; p < 3; p++)
                            {
                                if (!X.A[i, p] && !O.A[i, p])
                                {
                                    String name = "";
                                    char c = 'A';
                                    name += c;
                                    name += (i + 1);
                                    name += (p + 1);
                                    Controls[name].Enabled = true;
                                }
                                if (!X.B[i, p] && !O.B[i, p])
                                {
                                    String name = "";
                                    char c = 'B';
                                    name += c;
                                    name += (i + 1);
                                    name += (p + 1);
                                    Controls[name].Enabled = true;
                                }
                                if (!X.C[i, p] && !O.C[i, p])
                                {
                                    String name = "";
                                    char c = 'C';
                                    name += c;
                                    name += (i + 1);
                                    name += (p + 1);
                                    Controls[name].Enabled = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        Wildcard();
                    }
                    break;
                case 4:
                    if (!SquareDoneO[3] && !SquareDoneX[3])
                    {
                        int i = (area - 1);
                        for (int k = 0; k < 3; k++)
                        {
                            for (int p = 0; p < 3; p++)
                            {
                                if (!X.A[i, p] && !O.A[i, p])
                                {
                                    String name = "";
                                    char c = 'A';
                                    name += c;
                                    name += (i + 1);
                                    name += (p + 1);
                                    Controls[name].Enabled = true;
                                }
                                if (!X.B[i, p] && !O.B[i, p])
                                {
                                    String name = "";
                                    char c = 'B';
                                    name += c;
                                    name += (i + 1);
                                    name += (p + 1);
                                    Controls[name].Enabled = true;
                                }
                                if (!X.C[i, p] && !O.C[i, p])
                                {
                                    String name = "";
                                    char c = 'C';
                                    name += c;
                                    name += (i + 1);
                                    name += (p + 1);
                                    Controls[name].Enabled = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        Wildcard();
                    }
                    break;
                case 5:
                    if (!SquareDoneO[4] && !SquareDoneX[4])
                    {
                        int i = (area - 1);
                        for (int k = 0; k < 3; k++)
                        {
                            for (int p = 0; p < 3; p++)
                            {
                                if (!X.A[i, p] && !O.A[i, p])
                                {
                                    String name = "";
                                    char c = 'A';
                                    name += c;
                                    name += (i + 1);
                                    name += (p + 1);
                                    Controls[name].Enabled = true;
                                }
                                if (!X.B[i, p] && !O.B[i, p])
                                {
                                    String name = "";
                                    char c = 'B';
                                    name += c;
                                    name += (i + 1);
                                    name += (p + 1);
                                    Controls[name].Enabled = true;
                                }
                                if (!X.C[i, p] && !O.C[i, p])
                                {
                                    String name = "";
                                    char c = 'C';
                                    name += c;
                                    name += (i + 1);
                                    name += (p + 1);
                                    Controls[name].Enabled = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        Wildcard();
                    }
                    break;
                case 6:
                    if (!SquareDoneO[5] && !SquareDoneX[5])
                    {
                        int i = (area - 1);
                        for (int k = 0; k < 3; k++)
                        {
                            for (int p = 0; p < 3; p++)
                            {
                                if (!X.A[i, p] && !O.A[i, p])
                                {
                                    String name = "";
                                    char c = 'A';
                                    name += c;
                                    name += (i + 1);
                                    name += (p + 1);
                                    Controls[name].Enabled = true;
                                }
                                if (!X.B[i, p] && !O.B[i, p])
                                {
                                    String name = "";
                                    char c = 'B';
                                    name += c;
                                    name += (i + 1);
                                    name += (p + 1);
                                    Controls[name].Enabled = true;
                                }
                                if (!X.C[i, p] && !O.C[i, p])
                                {
                                    String name = "";
                                    char c = 'C';
                                    name += c;
                                    name += (i + 1);
                                    name += (p + 1);
                                    Controls[name].Enabled = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        Wildcard();
                    }
                    break;
                case 7:
                    if (!SquareDoneO[6] && !SquareDoneX[6])
                    {
                        int i = (area - 1);
                        for (int k = 0; k < 3; k++)
                        {
                            for (int p = 0; p < 3; p++)
                            {
                                if (!X.A[i, p] && !O.A[i, p])
                                {
                                    String name = "";
                                    char c = 'A';
                                    name += c;
                                    name += (i + 1);
                                    name += (p + 1);
                                    Controls[name].Enabled = true;
                                }
                                if (!X.B[i, p] && !O.B[i, p])
                                {
                                    String name = "";
                                    char c = 'B';
                                    name += c;
                                    name += (i + 1);
                                    name += (p + 1);
                                    Controls[name].Enabled = true;
                                }
                                if (!X.C[i, p] && !O.C[i, p])
                                {
                                    String name = "";
                                    char c = 'C';
                                    name += c;
                                    name += (i + 1);
                                    name += (p + 1);
                                    Controls[name].Enabled = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        Wildcard();
                    }
                    break;
                case 8:
                    if (!SquareDoneO[7] && !SquareDoneX[7])
                    {
                        int i = (area - 1);
                        for (int k = 0; k < 3; k++)
                        {
                            for (int p = 0; p < 3; p++)
                            {
                                if (!X.A[i, p] && !O.A[i, p])
                                {
                                    String name = "";
                                    char c = 'A';
                                    name += c;
                                    name += (i + 1);
                                    name += (p + 1);
                                    Controls[name].Enabled = true;
                                }
                                if (!X.B[i, p] && !O.B[i, p])
                                {
                                    String name = "";
                                    char c = 'B';
                                    name += c;
                                    name += (i + 1);
                                    name += (p + 1);
                                    Controls[name].Enabled = true;
                                }
                                if (!X.C[i, p] && !O.C[i, p])
                                {
                                    String name = "";
                                    char c = 'C';
                                    name += c;
                                    name += (i + 1);
                                    name += (p + 1);
                                    Controls[name].Enabled = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        Wildcard();
                    }
                    break;
                case 9:
                    if (!SquareDoneO[8] && !SquareDoneX[8])
                    {
                        int i = (area - 1);
                        for (int k = 0; k < 3; k++)
                        {
                            for (int p = 0; p < 3; p++)
                            {
                                if (!X.A[i, p] && !O.A[i, p])
                                {
                                    String name = "";
                                    char c = 'A';
                                    name += c;
                                    name += (i + 1);
                                    name += (p + 1);
                                    Controls[name].Enabled = true;
                                }
                                if (!X.B[i, p] && !O.B[i, p])
                                {
                                    String name = "";
                                    char c = 'B';
                                    name += c;
                                    name += (i + 1);
                                    name += (p + 1);
                                    Controls[name].Enabled = true;
                                }
                                if (!X.C[i, p] && !O.C[i, p])
                                {
                                    String name = "";
                                    char c = 'C';
                                    name += c;
                                    name += (i + 1);
                                    name += (p + 1);
                                    Controls[name].Enabled = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        Wildcard();
                    }
                    break;
                default:
                    break;
            }
        }


        public void BlankSquares(int area)
        {
            //Function To Blank All Or Certain Squares
            if (area == 0)
            {
                for (int i = 1; i <= 9; i++)
                {
                    BlankSquares(i);//Blank All Squares
                }
            }
            else
            {
                for (int k = 0; k < 3; k++)
                {
                    for (int p = 0; p < 3; p++)
                    {
                        String name = "";
                        char c = (k == 0) ? 'A' : (k == 1) ? 'B' : 'C'; //Loop Through Letters
                        name += c;          //Add The Letter
                        name += area;       //Add Specified Area
                        name += (p + 1);    //Add Sqaure Adjusting For Zero Base
                        Controls[name].Enabled = false; //Blank The Sqaure
                    }
                }
            }
          }




        public void SetText(int area, char team) {
            //Sets The Text On The Button For The Respective Player
            if (team == 'X')
            {
                for (int k = 0; k < 3; k++)
                {
                    for (int p = 0; p < 3; p++)
                    {
                        String name = "";
                        char c = (k == 0) ? 'A' : (k == 1) ? 'B' : 'C';
                        name += c;
                        name += area;
                        name += (p + 1);
                        Controls[name].Text = "X";
                    }
                }
            }
            if (team == 'O')
            {
                for (int k = 0; k < 3; k++)
                {
                    for (int p = 0; p < 3; p++)
                    {
                        String name = "";
                        char c = (k == 0) ? 'A' : (k == 1) ? 'B' : 'C';
                        name += c;
                        name += area;
                        name += (p + 1);
                        Controls[name].Text = "O";

                    }
                }
            }
        }


        public void ForceArea(int area)
        {
            //The Function That Forces A User To Play In A Specfic Sqaure
            BlankSquares(0);
            if (!Finnished)
            {
                UnBlankSquares(area);
            }
            forcedArea = area;
            cpu(false);
        }


        public int CheckAreas()
        {
            //Checks All The Areas To See If Any Sqaures Have Been Won
            xPermutations();
            oPermutations();
            if (SquareDoneX[0] || SquareDoneO[0])
            {
                BlankSquares(1);
                if (SquareDoneX[0])
                {
                    SetText(1, 'X');
                }
                else
                {
                    SetText(1, 'O');
                }
                
            }

            if (SquareDoneX[1] || SquareDoneO[1])
            {
                BlankSquares(2);
                if (SquareDoneX[1])
                {
                    SetText(2, 'X');
                }
                else
                {
                    SetText(2, 'O');
                }

            }
            if (SquareDoneX[2] || SquareDoneO[2])
            {
                BlankSquares(3);
                if (SquareDoneX[2])
                {
                    SetText(3, 'X');
                }
                else
                {
                    SetText(3, 'O');
                }

            }
            if (SquareDoneX[3] || SquareDoneO[3])
            {
                BlankSquares(4);
                if (SquareDoneX[3])
                {
                    SetText(4, 'X');
                }
                else
                {
                    SetText(4, 'O');
                }

            }
            if (SquareDoneX[4] || SquareDoneO[4])
            {
                BlankSquares(5);
                if (SquareDoneX[4])
                {
                    SetText(5, 'X');
                }
                else
                {
                    SetText(5, 'O');
                }

            }
            if (SquareDoneX[5] || SquareDoneO[5])
            {
                BlankSquares(6);
                if (SquareDoneX[5])
                {
                    SetText(6, 'X');
                }
                else
                {
                    SetText(6, 'O');
                }

            }
            if (SquareDoneX[6] || SquareDoneO[6])
            {
                BlankSquares(7);
                if (SquareDoneX[6])
                {
                    SetText(7, 'X');
                }
                else
                {
                    SetText(7, 'O');
                }

            }
            if (SquareDoneX[7] || SquareDoneO[7])
            {
                BlankSquares(8);
                if (SquareDoneX[7])
                {
                    SetText(8, 'X');
                }
                else
                {
                    SetText(8, 'O');
                }

            }
            if (SquareDoneX[8] || SquareDoneO[8])
            {
                BlankSquares(9);
                if (SquareDoneX[8])
                {
                    SetText(9, 'X');
                }
                else
                {
                    SetText(9, 'O');
                }

            }

            if (UltimatePermutaionsX() == 1)
            {
                return 1;
            }
            if (UltimatePermutaionsO() == 1)
            {
                return 2;
            }
            return 100;   
        }

        public void CheckWin()
        {
            //Checks To See If Any Player Won The Whole Game
            if (CheckAreas() == 1)
            {
                BlankSquares(0);
                MessageBox.Show("X WINS!", "Tic Tac Toe");
                BlankSquares(0);
                Finnished = true;
            }

            if (CheckAreas() == 2)
            {
                BlankSquares(0);
                MessageBox.Show("O WINS!", "Tic Tac Toe");
                BlankSquares(0);
                Finnished = true;
            }
        }

        public void NewGame()
        {
            //Clears Everything And Starts A New Game
            plays = 0;
            turn = 'X';
            resetSquare();
            Finnished = false;
        }

        public void resetSquare()
        {
            //Reset The Text On All Of The Buttons
            for (int k = 0; k< 3; k++)
            {
                for (int i = 0; i< 9; i++)
                {
                    for (int p = 0; p< 3; p++)
                    {
                            String name = "";
                            char c = (k == 0) ? 'A' : (k == 1) ? 'B' : 'C';
                            name += c;
                            name += (i + 1);
                            name += (p + 1);
                            Controls[name].Enabled = true;
                            Controls[name].Text = "";
                    }
                }
            }


            //Set Values Back To False
            for (int i = 0; i < 9; i++)
            {
                for (int p = 0; p < 3; p++)
                {
                    X.A[i, p] = false;
                    X.B[i, p] = false;
                    X.C[i, p] = false;
                    O.A[i, p] = false;
                    O.B[i, p] = false;
                    O.C[i, p] = false;
                }
            }

            for (int i = 0; i < 9; i++)
            {
                SquareDoneX[i] = false;
                SquareDoneO[i] = false;
            }
        }


        private void cpu(bool card) {

            if (card && CPU && turn == 'O' && !Finnished)
            {
                int k, p, f,l;
                char c;
                String name = "";
                do
                {
                    Random rand = new Random();
                    k = rand.Next(3);
                    p = rand.Next(3);
                    l = rand.Next(9);
                    c = (k == 0) ? 'A' : (k == 1) ? 'B' : 'C';
                    f = (k == 0) ? 0 : (k == 1) ? 3 : 6;
                    name = "";
                    name += c;
                    name += (l + 1);
                    name += (p + 1);
                }while (!Controls[name].Enabled);
                setSquare(c, (l + 1), (p + 1));
                ForceArea((p + f) + 1);
            }
            else if (CPU && turn == 'O' && !Finnished)
            {
                int k, p, f;
                char c;
                String name = "";
                do
                {
                    Random rand = new Random();
                    k = rand.Next(3);
                    p = rand.Next(3);
                    c = (k == 0) ? 'A' : (k == 1) ? 'B' : 'C';
                    f = (k == 0) ? 0 : (k == 1) ? 3 : 6;
                    name = "";
                    name += c;
                    name += forcedArea;
                    name += (p + 1);
                }while (!Controls[name].Enabled);
                setSquare(c, forcedArea, (p + 1));
                ForceArea((p + f) + 1);
            }
        }
        private void A1_Click(object sender, EventArgs e)
        {
            setSquare('A', 1, 1);
            ForceArea(1);
        }

        private void A2_Click(object sender, EventArgs e)
        {
            setSquare('A', 1, 2);
            ForceArea(2);
        }

        private void A3_Click(object sender, EventArgs e)
        {
            setSquare('A', 1, 3);
            ForceArea(3);
        }

        private void B1_Click(object sender, EventArgs e)
        {
            setSquare('B', 1, 1);
            ForceArea(4);
        }

        private void B2_Click(object sender, EventArgs e)
        {
            setSquare('B', 1, 2);
            ForceArea(5);
        }

        private void B3_Click(object sender, EventArgs e)
        {
            setSquare('B', 1, 3);
            ForceArea(6);
        }

        private void C1_Click(object sender, EventArgs e)
        {
            setSquare('C', 1, 1);
            ForceArea(7);
        }

        private void C2_Click(object sender, EventArgs e)
        {
            setSquare('C', 1, 2);
            ForceArea(8);
        }

        private void C3_Click(object sender, EventArgs e)
        {
            setSquare('C', 1, 3);
            ForceArea(9);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void A21_Click(object sender, EventArgs e)
        {
            setSquare('A', 2, 1);
            ForceArea(1);
        }

        private void A22_Click(object sender, EventArgs e)
        {
            setSquare('A', 2, 2);
            ForceArea(2);
        }

        private void A23_Click(object sender, EventArgs e)
        {
            setSquare('A', 2, 3);
            ForceArea(3);
        }

        private void B21_Click(object sender, EventArgs e)
        {
            setSquare('B', 2, 1);
            ForceArea(4);
        }

        private void B22_Click(object sender, EventArgs e)
        {
            setSquare('B', 2, 2);
            ForceArea(5);
        }

        private void B23_Click(object sender, EventArgs e)
        {
            setSquare('B', 2, 3);
            ForceArea(6);
        }

        private void C21_Click(object sender, EventArgs e)
        {
            setSquare('C', 2, 1);
            ForceArea(7);
        }

        private void C22_Click(object sender, EventArgs e)
        {
            setSquare('C', 2, 2);
            ForceArea(8);
        }

        private void C23_Click(object sender, EventArgs e)
        {
            setSquare('C', 2, 3);
            ForceArea(9);
        }

        private void A31_Click(object sender, EventArgs e)
        {
            setSquare('A', 3, 1);
            ForceArea(1);
        }

        private void A32_Click(object sender, EventArgs e)
        {
            setSquare('A', 3, 2); ForceArea(2);
        }

        private void A33_Click(object sender, EventArgs e)
        {
            setSquare('A', 3, 3);
            ForceArea(3);
        }

        private void B31_Click(object sender, EventArgs e)
        {
            setSquare('B', 3, 1);
            ForceArea(4);
        }

        private void B32_Click(object sender, EventArgs e)
        {
            setSquare('B', 3, 2);
            ForceArea(5);
        }

        private void B33_Click(object sender, EventArgs e)
        {
            setSquare('B', 3, 3); ForceArea(6);
        }

        private void C31_Click(object sender, EventArgs e)
        {
            setSquare('C', 3, 1);
            ForceArea(7);
        }

        private void C32_Click(object sender, EventArgs e)
        {
            setSquare('C', 3, 2);
            ForceArea(8);
        }

        private void C33_Click(object sender, EventArgs e)
        {
            setSquare('C', 3, 3);
            ForceArea(9);
        }

        private void A41_Click(object sender, EventArgs e)
        {
            setSquare('A', 4, 1);
            ForceArea(1);
        }

        private void A42_Click(object sender, EventArgs e)
        {
            setSquare('A', 4, 2);
            ForceArea(2);
        }

        private void A43_Click(object sender, EventArgs e)
        {
            setSquare('A', 4, 3);
            ForceArea(3);
        }

        private void B41_Click(object sender, EventArgs e)
        {
            setSquare('B', 4, 1);
            ForceArea(4);
        }

        private void B42_Click(object sender, EventArgs e)
        {
            setSquare('B', 4, 2);
            ForceArea(5);
        }

        private void B43_Click(object sender, EventArgs e)
        {
            setSquare('B', 4, 3);
            ForceArea(6);
        }

        private void C41_Click(object sender, EventArgs e)
        {
            setSquare('C', 4, 1);
            ForceArea(7);
        }

        private void C42_Click(object sender, EventArgs e)
        {
            setSquare('C', 4, 2);
            ForceArea(8);
        }

        private void C43_Click(object sender, EventArgs e)
        {
            setSquare('C', 4, 3);
            ForceArea(9);
        }

        private void A51_Click(object sender, EventArgs e)
        {
            setSquare('A', 5, 1);
            ForceArea(1);
        }

        private void A52_Click(object sender, EventArgs e)
        {
            setSquare('A', 5, 2);
            ForceArea(2);
        }

        private void A53_Click(object sender, EventArgs e)
        {
            setSquare('A', 5, 3); ForceArea(3);
        }

        private void B51_Click(object sender, EventArgs e)
        {
            setSquare('B', 5, 1);
            ForceArea(4);
        }

        private void B52_Click(object sender, EventArgs e)
        {
            setSquare('B', 5, 2);
            ForceArea(5);
        }

        private void B53_Click(object sender, EventArgs e)
        {
            setSquare('B', 5, 3);
            ForceArea(6);
        }

        private void C51_Click(object sender, EventArgs e)
        {
            setSquare('C', 5, 1);
            ForceArea(7);
        }

        private void C52_Click(object sender, EventArgs e)
        {
            setSquare('C', 5, 2);
            ForceArea(8);
        }

        private void C53_Click(object sender, EventArgs e)
        {
            setSquare('C', 5, 3);
            ForceArea(9);
        }

        private void A61_Click(object sender, EventArgs e)
        {
            setSquare('A', 6, 1);
            ForceArea(1);
        }

        private void A62_Click(object sender, EventArgs e)
        {
            setSquare('A', 6, 2);
            ForceArea(2);
        }

        private void A63_Click(object sender, EventArgs e)
        {
            setSquare('A', 6, 3);
            ForceArea(3);
        }

        private void B61_Click(object sender, EventArgs e)
        {
            setSquare('B', 6, 1);
            ForceArea(4);
        }

        private void B62_Click(object sender, EventArgs e)
        {
            setSquare('B', 6, 2);
            ForceArea(5);
        }

        private void B63_Click(object sender, EventArgs e)
        {
            setSquare('B', 6, 3);
            ForceArea(6);
        }

        private void C61_Click(object sender, EventArgs e)
        {
            setSquare('C', 6, 1);
            ForceArea(7);
        }

        private void C62_Click(object sender, EventArgs e)
        {
            setSquare('C', 6, 2);
            ForceArea(8);
        }

        private void C63_Click(object sender, EventArgs e)
        {
            setSquare('C', 6, 3);
            ForceArea(9);
        }

        private void A71_Click(object sender, EventArgs e)
        {
            setSquare('A', 7, 1);
            ForceArea(1);
        }

        private void A72_Click(object sender, EventArgs e)
        {
            setSquare('A', 7, 2); ForceArea(2);
        }

        private void A73_Click(object sender, EventArgs e)
        {
            setSquare('A', 7, 3);
            ForceArea(3);
        }

        private void B71_Click(object sender, EventArgs e)
        {
            setSquare('B', 7, 1);
            ForceArea(4);
        }

        private void B72_Click(object sender, EventArgs e)
        {
            setSquare('B', 7, 2);
            ForceArea(5);
        }

        private void B73_Click(object sender, EventArgs e)
        {
            setSquare('B', 7, 3);
            ForceArea(6);
        }

        private void C71_Click(object sender, EventArgs e)
        {
            setSquare('C', 7, 1);
            ForceArea(7);
        }

        private void C72_Click(object sender, EventArgs e)
        {
            setSquare('C', 7, 2);
            ForceArea(8);
        }

        private void C73_Click(object sender, EventArgs e)
        {
            setSquare('C', 7, 3);
            ForceArea(9);
        }

        private void A81_Click(object sender, EventArgs e)
        {
            setSquare('A', 8, 1);
            ForceArea(1);
        }

        private void A82_Click(object sender, EventArgs e)
        {
            setSquare('A', 8, 2);
            ForceArea(2);
        }

        private void A83_Click(object sender, EventArgs e)
        {
            setSquare('A', 8, 3);
            ForceArea(3);
        }

        private void B81_Click(object sender, EventArgs e)
        {
            setSquare('B', 8, 1);
            ForceArea(4);
        }

        private void B82_Click(object sender, EventArgs e)
        {
            setSquare('B', 8, 2);
            ForceArea(5);
        }

        private void B83_Click(object sender, EventArgs e)
        {
            setSquare('B', 8, 3);
            ForceArea(6);
        }

        private void C81_Click(object sender, EventArgs e)
        {
            setSquare('C', 8, 1); ForceArea(7);
        }

        private void C82_Click(object sender, EventArgs e)
        {
            setSquare('C', 8, 2);
            ForceArea(8);
        }

        private void C83_Click(object sender, EventArgs e)
        {
            setSquare('C', 8, 3);
            ForceArea(9);
        }

        private void A91_Click(object sender, EventArgs e)
        {
            setSquare('A', 9, 1);
            ForceArea(1);
        }

        private void A92_Click(object sender, EventArgs e)
        {
            setSquare('A', 9, 2);
            ForceArea(2);
        }

        private void A93_Click(object sender, EventArgs e)
        {
            setSquare('A', 9, 3);
            ForceArea(3);
        }

        private void B91_Click(object sender, EventArgs e)
        {
            setSquare('B', 9, 1);
            ForceArea(4);
        }

        private void B92_Click(object sender, EventArgs e)
        {
            setSquare('B', 9, 2);
            ForceArea(5);
        }

        private void B93_Click(object sender, EventArgs e)
        {
            setSquare('B', 9, 3);
            ForceArea(6);
        }

        private void C91_Click(object sender, EventArgs e)
        {
            setSquare('C', 9, 1);
            ForceArea(7);
        }

        private void C92_Click(object sender, EventArgs e)
        {
            setSquare('C', 9, 2);
            ForceArea(8);
        }

        private void C93_Click(object sender, EventArgs e)
        {
            setSquare('C', 9, 3);
            ForceArea(9);
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Is A ULTIMATE Tic Tac Toe Game. Made By Mike Hodges");
        }

        private void enableSinglePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CPU)
            {
                NewGame();
                CPU = true;
                enableSinglePlayerToolStripMenuItem.Text = "Enable Multiplayer";
            }
            else if (CPU)
            {
                NewGame();
                CPU = false;
                enableSinglePlayerToolStripMenuItem.Text = "Enable Single Player";
            }
        }
    }
}
