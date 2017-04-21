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
            //MessageBox.Show("X Goes First Rn :)");
            for (int i = 0; i < 9; i++)
            {
                SquareDoneO[i] = false;
            }

            for (int i = 0; i < 9; i++)
            {
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

        public void Wildcard() {

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

        }

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
                    //Example Of How To Whitelist Some of The Squares
                    if (!SquareDoneX[0] && !SquareDoneO[0])
                    {
                        int i = 0;
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



        public void SetText(int area, char team) {

            if (team == 'X')
            {

                switch (area)
                {
                    case 1:
                        A11.Text = "X";
                        A12.Text = "X";
                        A13.Text = "X";
                        B11.Text = "X";
                        B12.Text = "X";
                        B13.Text = "X";
                        C11.Text = "X";
                        C12.Text = "X";
                        C13.Text = "X";
                        break;
                    case 2:
                        A21.Text = "X";
                        A22.Text = "X";
                        A23.Text = "X";
                        B21.Text = "X";
                        B22.Text = "X";
                        B23.Text = "X";
                        C21.Text = "X";
                        C22.Text = "X";
                        C23.Text = "X";
                        break;
                    case 3:
                        A31.Text = "X";
                        A32.Text = "X";
                        A33.Text = "X";
                        B31.Text = "X";
                        B32.Text = "X";
                        B33.Text = "X";
                        C31.Text = "X";
                        C32.Text = "X";
                        C33.Text = "X";
                        break;
                    case 4:
                        A41.Text = "X";
                        A42.Text = "X";
                        A43.Text = "X";
                        B41.Text = "X";
                        B42.Text = "X";
                        B43.Text = "X";
                        C41.Text = "X";
                        C42.Text = "X";
                        C43.Text = "X";
                        break;
                    case 5:
                        A51.Text = "X";
                        A52.Text = "X";
                        A53.Text = "X";
                        B51.Text = "X";
                        B52.Text = "X";
                        B53.Text = "X";
                        C51.Text = "X";
                        C52.Text = "X";
                        C53.Text = "X";
                        break;
                    case 6:
                        A61.Text = "X";
                        A62.Text = "X";
                        A63.Text = "X";
                        B61.Text = "X";
                        B62.Text = "X";
                        B63.Text = "X";
                        C61.Text = "X";
                        C62.Text = "X";
                        C63.Text = "X";
                        break;
                    case 7:
                        A71.Text = "X";
                        A72.Text = "X";
                        A73.Text = "X";
                        B71.Text = "X";
                        B72.Text = "X";
                        B73.Text = "X";
                        C71.Text = "X";
                        C72.Text = "X";
                        C73.Text = "X";
                        break;
                    case 8:
                        A81.Text = "X";
                        A82.Text = "X";
                        A83.Text = "X";
                        B81.Text = "X";
                        B82.Text = "X";
                        B83.Text = "X";
                        C81.Text = "X";
                        C82.Text = "X";
                        C83.Text = "X";
                        break;
                    case 9:
                        A91.Text = "X";
                        A92.Text = "X";
                        A93.Text = "X";
                        B91.Text = "X";
                        B92.Text = "X";
                        B93.Text = "X";
                        C91.Text = "X";
                        C92.Text = "X";
                        C93.Text = "X";
                        break;

                    default:
                        break;
                }
            }
            if (team == 'O')
            {
                switch (area)
                {
                    case 1:
                        A11.Text = "O";
                        A12.Text = "O";
                        A13.Text = "O";
                        B11.Text = "O";
                        B12.Text = "O";
                        B13.Text = "O";
                        C11.Text = "O";
                        C12.Text = "O";
                        C13.Text = "O";
                        break;
                    case 2:
                        A21.Text = "O";
                        A22.Text = "O";
                        A23.Text = "O";
                        B21.Text = "O";
                        B22.Text = "O";
                        B23.Text = "O";
                        C21.Text = "O";
                        C22.Text = "O";
                        C23.Text = "O";
                        break;
                    case 3:
                        A31.Text = "O";
                        A32.Text = "O";
                        A33.Text = "O";
                        B31.Text = "O";
                        B32.Text = "O";
                        B33.Text = "O";
                        C31.Text = "O";
                        C32.Text = "O";
                        C33.Text = "O";
                        break;
                    case 4:
                         A41.Text = "O";
                        A42.Text = "O";
                        A43.Text = "O";
                        B41.Text = "O";
                        B42.Text = "O";
                        B43.Text = "O";
                        C41.Text = "O";
                        C42.Text = "O";
                        C43.Text = "O";
                        break;
                    case 5:
                        A51.Text = "O";
                        A52.Text = "O";
                        A53.Text = "O";
                        B51.Text = "O";
                        B52.Text = "O";
                        B53.Text = "O";
                        C51.Text = "O";
                        C52.Text = "O";
                        C53.Text = "O";
                        break;
                    case 6:
                        A61.Text = "O";
                        A62.Text = "O";
                        A63.Text = "O";
                        B61.Text = "O";
                        B62.Text = "O";
                        B63.Text = "O";
                        C61.Text = "O";
                        C62.Text = "O";
                        C63.Text = "O";
                        break;
                    case 7:
                         A71.Text = "O";
                        A72.Text = "O";
                        A73.Text = "O";
                        B71.Text = "O";
                        B72.Text = "O";
                        B73.Text = "O";
                        C71.Text = "O";
                        C72.Text = "O";
                        C73.Text = "O";
                        break;
                    case 8:
                        A81.Text = "O";
                        A82.Text = "O";
                        A83.Text = "O";
                        B81.Text = "O";
                        B82.Text = "O";
                        B83.Text = "O";
                        C81.Text = "O";
                        C82.Text = "O";
                        C83.Text = "O";
                        break;
                    case 9:
                        A91.Text = "O";
                        A92.Text = "O";
                        A93.Text = "O";
                        B91.Text = "O";
                        B92.Text = "O";
                        B93.Text = "O";
                        C91.Text = "O";
                        C92.Text = "O";
                        C93.Text = "O";
                        break;

                    default:
                        break;
                }




            }


        }


        public void ForceArea(int area) {

            //Maybe i should unblnaked all buttons and then blank the things i need to
            BlankSquares(0);
            if (!Finnished)
            {
                UnBlankSquares(area);
            }
        }


        public int CheckAreas() {

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
                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int p = 0; p < 3; p++)
                {
                    X.B[i, p] = false;
                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int p = 0; p < 3; p++)
                {
                    X.C[i, p] = false;
                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int p = 0; p < 3; p++)
                {
                    O.A[i, p] = false;
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int p = 0; p < 3; p++)
                {
                    O.B[i, p] = false;
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int p = 0; p < 3; p++)
                {
                    O.C[i, p] = false;
                }
            }


             SquareDoneX[0] = false;
             SquareDoneX[1] = false;
             SquareDoneX[2] = false;
             SquareDoneX[3] = false;
             SquareDoneX[4] = false;
             SquareDoneX[5] = false;
             SquareDoneX[6] = false;
             SquareDoneX[7] = false;
             SquareDoneX[8] = false;

             SquareDoneO[0] = false;
             SquareDoneO[1] = false;
             SquareDoneO[2] = false;
             SquareDoneO[3] = false;
             SquareDoneO[4] = false;
             SquareDoneO[5] = false;
             SquareDoneO[6] = false;
             SquareDoneO[7] = false;
             SquareDoneO[8] = false;
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
            setSquare('B', 2, 2); ForceArea(5);
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
    }
}
