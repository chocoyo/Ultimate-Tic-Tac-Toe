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

//Fix The Menu Buttons Not Working




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
            

        }


        //Declarations
        char turn = 'X';
        int plays = 0;
        Squares X = new Squares();
        Squares O = new Squares();
        bool Square1DoneX = false;
        bool Square2DoneX = false;
        bool Square3DoneX = false;
        bool Square4DoneX = false;
        bool Square5DoneX = false;
        bool Square6DoneX = false;
        bool Square7DoneX = false;
        bool Square8DoneX = false;
        bool Square9DoneX = false;

        bool Square1DoneO = false;
        bool Square2DoneO = false;
        bool Square3DoneO = false;
        bool Square4DoneO = false;
        bool Square5DoneO = false;
        bool Square6DoneO = false;
        bool Square7DoneO = false;
        bool Square8DoneO = false;
        bool Square9DoneO = false;

        bool Finnished = false;

        public void Wildcard() {

            if (!Square1DoneO && !Square1DoneX)
            {
                UnBlankSquares(1);
            }

            if (!Square2DoneO && !Square2DoneX)
            {
                UnBlankSquares(2);
            }

            if (!Square3DoneO && !Square3DoneX)
            {
                UnBlankSquares(3);
            }

            if (!Square4DoneO && !Square4DoneX)
            {
                UnBlankSquares(4);
            }
            if (!Square5DoneO && !Square5DoneX)
            {
                UnBlankSquares(5);
            }
            if (!Square6DoneO && !Square6DoneX)
            {
                UnBlankSquares(6);
            }
            if (!Square7DoneO && !Square7DoneX)
            {
                UnBlankSquares(7);
            }
            if (!Square8DoneO && !Square8DoneX)
            {
                UnBlankSquares(8);
            }
            if (!Square9DoneO && !Square9DoneX)
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
                    if (!Square1DoneX && !Square1DoneO)
                    {
                        //Whitelist The Squares Within The Squares
                        if (!X.A11 && !O.A11)
                        {
                            A11.Enabled = true;
                        }

                        if (!X.A12 && !O.A12)
                        {
                            A12.Enabled = true;
                        }

                        if (!X.A13 && !O.A13)
                        {
                            A13.Enabled = true;
                        }
                        if (!X.B11 && !O.B11)
                        {
                            B11.Enabled = true;
                        }
                        if (!X.B12 && !O.B12)
                        {
                            B12.Enabled = true;
                        }
                        if (!X.B13 && !O.B13)
                        {
                            B13.Enabled = true;
                        }
                        if (!X.C11 && !O.C11)
                        {
                            C11.Enabled = true;
                        }
                        if (!X.C12 && !O.C12)
                        {
                            C12.Enabled = true;
                        }
                        if (!X.C13 && !O.C13)
                        {
                            C13.Enabled = true;
                        }
                    }
                    else
                    {
                        Wildcard();
                        //UnBlankSquares(2);
                        //UnBlankSquares(3);
                        //UnBlankSquares(4);
                        //UnBlankSquares(5);
                        //UnBlankSquares(6);
                        //UnBlankSquares(7);
                        //UnBlankSquares(8);
                        //UnBlankSquares(9);
                    }
                    
                  

                    break;
                case 2:
                    if (!Square2DoneO && !Square2DoneX)
                    {
                        if (!X.A21 && !O.A21)
                        {
                            A21.Enabled = true;
                        }

                        if (!X.A22 && !O.A22)
                        {
                            A22.Enabled = true;
                        }

                        if (!X.A23 && !O.A23)
                        {
                            A23.Enabled = true;
                        }
                        if (!X.B21 && !O.B21)
                        {
                            B21.Enabled = true;
                        }
                        if (!X.B22 && !O.B22)
                        {
                            B22.Enabled = true;
                        }
                        if (!X.B23 && !O.B23)
                        {
                            B23.Enabled = true;
                        }
                        if (!X.C21 && !O.C21)
                        {
                            C21.Enabled = true;
                        }
                        if (!X.C22 && !O.C22)
                        {
                            C22.Enabled = true;
                        }
                        if (!X.C23 && !O.C23)
                        {
                            C23.Enabled = true;
                        }

                    }
                    else
                    {
                        Wildcard();
                    }

                    break;
                case 3:
                    if (!Square3DoneO && !Square3DoneX)
                    {
                        if (!X.A31 && !O.A31)
                        {
                            A31.Enabled = true;
                        }

                        if (!X.A32 && !O.A32)
                        {
                            A32.Enabled = true;
                        }

                        if (!X.A33 && !O.A33)
                        {
                            A33.Enabled = true;
                        }
                        if (!X.B31 && !O.B31)
                        {
                            B31.Enabled = true;
                        }
                        if (!X.B32 && !O.B32)
                        {
                            B32.Enabled = true;
                        }
                        if (!X.B33 && !O.B33)
                        {
                            B33.Enabled = true;
                        }
                        if (!X.C31 && !O.C31)
                        {
                            C31.Enabled = true;
                        }
                        if (!X.C32 && !O.C32)
                        {
                            C32.Enabled = true;
                        }
                        if (!X.C33 && !O.C33)
                        {
                            C33.Enabled = true;
                        }
                    }
                    else
                    {
                        Wildcard();
                    }
                    break;
                case 4:
                    if (!Square4DoneO && !Square4DoneX)
                    {
                        if (!X.A41 && !O.A41)
                        {
                            A41.Enabled = true;
                        }

                        if (!X.A42 && !O.A42)
                        {
                            A42.Enabled = true;
                        }

                        if (!X.A43 && !O.A43)
                        {
                            A43.Enabled = true;
                        }
                        if (!X.B41 && !O.B41)
                        {
                            B41.Enabled = true;
                        }
                        if (!X.B42 && !O.B42)
                        {
                            B42.Enabled = true;
                        }
                        if (!X.B43 && !O.B43)
                        {
                            B43.Enabled = true;
                        }
                        if (!X.C41 && !O.C41)
                        {
                            C41.Enabled = true;
                        }
                        if (!X.C42 && !O.C42)
                        {
                            C42.Enabled = true;
                        }
                        if (!X.C43 && !O.C43)
                        {
                            C43.Enabled = true;
                        }
                    }
                    else
                    {
                        Wildcard();
                    }
                    break;
                case 5:
                    if (!Square5DoneO && !Square5DoneX)
                    {
                        if (!X.A51 && !O.A51)
                        {
                            A51.Enabled = true;
                        }

                        if (!X.A52 && !O.A52)
                        {
                            A52.Enabled = true;
                        }

                        if (!X.A53 && !O.A53)
                        {
                            A53.Enabled = true;
                        }
                        if (!X.B51 && !O.B51)
                        {
                            B51.Enabled = true;
                        }
                        if (!X.B52 && !O.B52)
                        {
                            B52.Enabled = true;
                        }
                        if (!X.B53 && !O.B53)
                        {
                            B53.Enabled = true;
                        }
                        if (!X.C51 && !O.C51)
                        {
                            C51.Enabled = true;
                        }
                        if (!X.C52 && !O.C52)
                        {
                            C52.Enabled = true;
                        }
                        if (!X.C53 && !O.C53)
                        {
                            C53.Enabled = true;
                        }
                    }
                    else
                    {
                        Wildcard();
                    }
                    break;
                case 6:
                    if (!Square6DoneO && !Square6DoneX)
                    {
                        if (!X.A61 && !O.A61)
                        {
                            A61.Enabled = true;
                        }

                        if (!X.A62 && !O.A62)
                        {
                            A62.Enabled = true;
                        }

                        if (!X.A63 && !O.A63)
                        {
                            A63.Enabled = true;
                        }
                        if (!X.B61 && !O.B61)
                        {
                            B61.Enabled = true;
                        }
                        if (!X.B62 && !O.B62)
                        {
                            B62.Enabled = true;
                        }
                        if (!X.B63 && !O.B63)
                        {
                            B63.Enabled = true;
                        }
                        if (!X.C61 && !O.C61)
                        {
                            C61.Enabled = true;
                        }
                        if (!X.C62 && !O.C62)
                        {
                            C62.Enabled = true;
                        }
                        if (!X.C63 && !O.C63)
                        {
                            C63.Enabled = true;
                        }
                    }
                    else
                    {
                        Wildcard();
                    }
                    break;
                case 7:
                    if (!Square7DoneO && !Square7DoneX)
                    {
                        if (!X.A71 && !O.A71)
                        {
                            A71.Enabled = true;
                        }

                        if (!X.A72 && !O.A72)
                        {
                            A72.Enabled = true;
                        }

                        if (!X.A73 && !O.A73)
                        {
                            A73.Enabled = true;
                        }
                        if (!X.B71 && !O.B71)
                        {
                            B71.Enabled = true;
                        }
                        if (!X.B72 && !O.B72)
                        {
                            B72.Enabled = true;
                        }
                        if (!X.B73 && !O.B73)
                        {
                            B73.Enabled = true;
                        }
                        if (!X.C71 && !O.C71)
                        {
                            C71.Enabled = true;
                        }
                        if (!X.C72 && !O.C72)
                        {
                            C72.Enabled = true;
                        }
                        if (!X.C73 && !O.C73)
                        {
                            C73.Enabled = true;
                        }
                    }
                    else
                    {
                        Wildcard();
                    }
                    break;
                case 8:
                    if (!Square8DoneO && !Square8DoneX)
                    {
                        if (!X.A81 && !O.A81)
                        {
                            A81.Enabled = true;
                        }

                        if (!X.A82 && !O.A82)
                        {
                            A82.Enabled = true;
                        }

                        if (!X.A83 && !O.A83)
                        {
                            A83.Enabled = true;
                        }
                        if (!X.B81 && !O.B81)
                        {
                            B81.Enabled = true;
                        }
                        if (!X.B82 && !O.B82)
                        {
                            B82.Enabled = true;
                        }
                        if (!X.B83 && !O.B83)
                        {
                            B83.Enabled = true;
                        }
                        if (!X.C81 && !O.C81)
                        {
                            C81.Enabled = true;
                        }
                        if (!X.C82 && !O.C82)
                        {
                            C82.Enabled = true;
                        }
                        if (!X.C83 && !O.C83)
                        {
                            C83.Enabled = true;
                        }
                    }
                    else
                    {
                        Wildcard();
                    }
                    break;
                case 9:
                    if (!Square9DoneO && !Square9DoneX)
                    {
                        if (!X.A91 && !O.A91)
                        {
                            A91.Enabled = true;
                        }

                        if (!X.A92 && !O.A92)
                        {
                            A92.Enabled = true;
                        }

                        if (!X.A93 && !O.A93)
                        {
                            A93.Enabled = true;
                        }
                        if (!X.B91 && !O.B91)
                        {
                            B91.Enabled = true;
                        }
                        if (!X.B92 && !O.B92)
                        {
                            B92.Enabled = true;
                        }
                        if (!X.B93 && !O.B93)
                        {
                            B93.Enabled = true;
                        }
                        if (!X.C91 && !O.C91)
                        {
                            C91.Enabled = true;
                        }
                        if (!X.C92 && !O.C92)
                        {
                            C92.Enabled = true;
                        }
                        if (!X.C93 && !O.C93)
                        {
                            C93.Enabled = true;
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
            if (Square1DoneX || Square1DoneO)
            {
                BlankSquares(1);
                if (Square1DoneX)
                {
                    SetText(1, 'X');
                }
                else
                {
                    SetText(1, 'O');
                }
                
            }

            if (Square2DoneX || Square2DoneO)
            {
                BlankSquares(2);
                if (Square2DoneX)
                {
                    SetText(2, 'X');
                }
                else
                {
                    SetText(2, 'O');
                }

            }
            if (Square3DoneX || Square3DoneO)
            {
                BlankSquares(3);
                if (Square3DoneX)
                {
                    SetText(3, 'X');
                }
                else
                {
                    SetText(3, 'O');
                }

            }
            if (Square4DoneX || Square4DoneO)
            {
                BlankSquares(4);
                if (Square4DoneX)
                {
                    SetText(4, 'X');
                }
                else
                {
                    SetText(4, 'O');
                }

            }
            if (Square5DoneX || Square5DoneO)
            {
                BlankSquares(5);
                if (Square5DoneX)
                {
                    SetText(5, 'X');
                }
                else
                {
                    SetText(5, 'O');
                }

            }
            if (Square6DoneX || Square6DoneO)
            {
                BlankSquares(6);
                if (Square6DoneX)
                {
                    SetText(6, 'X');
                }
                else
                {
                    SetText(6, 'O');
                }

            }
            if (Square7DoneX || Square7DoneO)
            {
                BlankSquares(7);
                if (Square7DoneX)
                {
                    SetText(7, 'X');
                }
                else
                {
                    SetText(7, 'O');
                }

            }
            if (Square8DoneX || Square8DoneO)
            {
                BlankSquares(8);
                if (Square8DoneX)
                {
                    SetText(8, 'X');
                }
                else
                {
                    SetText(8, 'O');
                }

            }
            if (Square9DoneX || Square9DoneO)
            {
                BlankSquares(9);
                if (Square9DoneX)
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

            A21.Text = "";
            A21.Enabled = true;
            A22.Text = "";
            A22.Enabled = true;
            A23.Text = "";
            A23.Enabled = true;
            B21.Text = "";
            B21.Enabled = true;
            B22.Text = "";
            B22.Enabled = true;
            B23.Text = "";
            B23.Enabled = true;
            C21.Text = "";
            C21.Enabled = true;
            C22.Text = "";
            C22.Enabled = true;
            C23.Text = "";
            C23.Enabled = true;

            A31.Text = "";
            A31.Enabled = true;
            A32.Text = "";
            A32.Enabled = true;
            A33.Text = "";
            A33.Enabled = true;
            B31.Text = "";
            B31.Enabled = true;
            B32.Text = "";
            B32.Enabled = true;
            B33.Text = "";
            B33.Enabled = true;
            C31.Text = "";
            C31.Enabled = true;
            C32.Text = "";
            C32.Enabled = true;
            C33.Text = "";
            C33.Enabled = true;

            A41.Text = "";
            A41.Enabled = true;
            A42.Text = "";
            A42.Enabled = true;
            A43.Text = "";
            A43.Enabled = true;
            B41.Text = "";
            B41.Enabled = true;
            B42.Text = "";
            B42.Enabled = true;
            B43.Text = "";
            B43.Enabled = true;
            C41.Text = "";
            C41.Enabled = true;
            C42.Text = "";
            C42.Enabled = true;
            C43.Text = "";
            C43.Enabled = true;

            A51.Text = "";
            A51.Enabled = true;
            A52.Text = "";
            A52.Enabled = true;
            A53.Text = "";
            A53.Enabled = true;
            B51.Text = "";
            B51.Enabled = true;
            B52.Text = "";
            B52.Enabled = true;
            B53.Text = "";
            B53.Enabled = true;
            C51.Text = "";
            C51.Enabled = true;
            C52.Text = "";
            C52.Enabled = true;
            C53.Text = "";
            C53.Enabled = true;

            A61.Text = "";
            A61.Enabled = true;
            A62.Text = "";
            A62.Enabled = true;
            A63.Text = "";
            A63.Enabled = true;
            B61.Text = "";
            B61.Enabled = true;
            B62.Text = "";
            B62.Enabled = true;
            B63.Text = "";
            B63.Enabled = true;
            C61.Text = "";
            C61.Enabled = true;
            C62.Text = "";
            C62.Enabled = true;
            C63.Text = "";
            C63.Enabled = true;

            A71.Text = "";
            A71.Enabled = true;
            A72.Text = "";
            A72.Enabled = true;
            A73.Text = "";
            A73.Enabled = true;
            B71.Text = "";
            B71.Enabled = true;
            B72.Text = "";
            B72.Enabled = true;
            B73.Text = "";
            B73.Enabled = true;
            C71.Text = "";
            C71.Enabled = true;
            C72.Text = "";
            C72.Enabled = true;
            C73.Text = "";
            C73.Enabled = true;

            A81.Text = "";
            A81.Enabled = true;
            A82.Text = "";
            A82.Enabled = true;
            A83.Text = "";
            A83.Enabled = true;
            B81.Text = "";
            B81.Enabled = true;
            B82.Text = "";
            B82.Enabled = true;
            B83.Text = "";
            B83.Enabled = true;
            C81.Text = "";
            C81.Enabled = true;
            C82.Text = "";
            C82.Enabled = true;
            C83.Text = "";
            C83.Enabled = true;

            A91.Text = "";
            A91.Enabled = true;
            A92.Text = "";
            A92.Enabled = true;
            A93.Text = "";
            A93.Enabled = true;
            B91.Text = "";
            B91.Enabled = true;
            B92.Text = "";
            B92.Enabled = true;
            B93.Text = "";
            B93.Enabled = true;
            C91.Text = "";
            C91.Enabled = true;
            C92.Text = "";
            C92.Enabled = true;
            C93.Text = "";
            C93.Enabled = true;


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

             Square1DoneX = false;
             Square2DoneX = false;
             Square3DoneX = false;
             Square4DoneX = false;
             Square5DoneX = false;
             Square6DoneX = false;
             Square7DoneX = false;
             Square8DoneX = false;
             Square9DoneX = false;

             Square1DoneO = false;
             Square2DoneO = false;
             Square3DoneO = false;
             Square4DoneO = false;
             Square5DoneO = false;
             Square6DoneO = false;
             Square7DoneO = false;
             Square8DoneO = false;
             Square9DoneO = false;
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Is A ULTIMATE Tic Tac Toe Game. Made By Mike Hodges");
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

        
    }
}
