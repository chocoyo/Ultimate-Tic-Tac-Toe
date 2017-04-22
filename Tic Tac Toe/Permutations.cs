using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{

    public partial class Form1 : Form
    {
        public void xPermutations()
        {
            //Checks To See If Any Of The Conditions To Win A Sqaure Have Been Met
            for (int i = 0; i < 9; i++)
            {
                //First Section
                if (X.A[i, 0])
                {
                    //Across the top
                    if (X.A[i,1])
                    {
                        if (X.A[i,2])
                        {
                            SquareDoneX[i] = true;
                        }
                    }
                    //Left Down
                    if (X.B[i,0])
                    {
                        if (X.C[i,0])
                        {
                            SquareDoneX[i] = true;
                        }
                    }
                    //Diagonal Top Left To Bottom Right
                    if (X.B[i,1])
                    {
                        if (X.C[i,2])
                        {
                            SquareDoneX[i] = true;
                        }
                    }

                }

                //Middle Down
                if (X.A[i,1])
                {
                    if (X.B[i,1])
                    {
                        if (X.C[i,1])
                        {
                            SquareDoneX[i] = true;
                        }
                    }
                }


                if (X.A[i,2])
                {
                    //Diagonal Top Right To Bottom Left
                    if (X.B[i,1])
                    {
                        if (X.C[i,0])
                        {
                            SquareDoneX[i] = true;
                        }
                    }
                    //Right Down
                    if (X.B[i,2])
                    {
                        if (X.C[i,2])
                        {
                            SquareDoneX[i] = true;
                        }
                    }
                }

                //Across the middle
                if (X.B[i,2])
                {
                    if (X.B[i,1])
                    {
                        if (X.B[i,0])
                        {
                            SquareDoneX[i] = true;
                        }
                    }
                }
                //Across the bottom
                if (X.C[i,0])
                {
                    if (X.C[i,1])
                    {
                        if (X.C[i,2])
                        {
                            SquareDoneX[i] = true;
                        }
                    }
                }
            }
        }

        public void oPermutations()
        {

            for (int i = 0; i < 9; i++)
            {
                //First Section
                if (O.A[i, 0])
                {
                    //Across the top
                    if (O.A[i, 1])
                    {
                        if (O.A[i, 2])
                        {
                            SquareDoneO[i] = true;
                        }
                    }
                    //Left Down
                    if (O.B[i, 0])
                    {
                        if (O.C[i, 0])
                        {
                            SquareDoneO[i] = true;
                        }
                    }
                    //Diagonal Top Left To Bottom Right
                    if (O.B[i, 1])
                    {
                        if (O.C[i, 2])
                        {
                            SquareDoneO[i] = true;
                        }
                    }

                }

                //Middle Down
                if (O.A[i, 1])
                {
                    if (O.B[i, 1])
                    {
                        if (O.C[i, 1])
                        {
                            SquareDoneO[i] = true;
                        }
                    }
                }


                if (O.A[i, 2])
                {
                    //Diagonal Top Right To Bottom Left
                    if (O.B[i, 1])
                    {
                        if (O.C[i, 0])
                        {
                            SquareDoneO[i] = true;
                        }
                    }
                    //Right Down
                    if (O.B[i, 2])
                    {
                        if (O.C[i, 2])
                        {
                            SquareDoneO[i] = true;
                        }
                    }
                }

                //Across the middle
                if (O.B[i, 2])
                {
                    if (O.B[i, 1])
                    {
                        if (O.B[i, 0])
                        {
                            SquareDoneO[i] = true;
                        }
                    }
                }
                //Across the bottom
                if (O.C[i, 0])
                {
                    if (O.C[i, 1])
                    {
                        if (O.C[i, 2])
                        {
                            SquareDoneO[i] = true;
                        }
                    }
                }
            }
        }



        public int UltimatePermutaionsX()
        {
            //Checks To See If Any Of The Conditions To Win The Game Have Been Met
            int check = 0;

            //First Section
            if (SquareDoneX[0])
            {
                //Across the top
                if (SquareDoneX[1])
                {
                    if (SquareDoneX[2])
                    {

                        check = 1;
                    }
                }
                //Left Down
                if (SquareDoneX[3])
                {
                    if (SquareDoneX[6])
                    {

                        check = 1;
                    }
                }
                //Diagonal Top Left To Bottom Right
                if (SquareDoneX[4])
                {
                    if (SquareDoneX[8])
                    {

                        check = 1;
                    }
                }

            }

            //Middle Down
            if (SquareDoneX[1])
            {
                if (SquareDoneX[4])
                {
                    if (SquareDoneX[7])
                    {
                        check = 1;
                    }
                }
            }


            if (SquareDoneX[2])
            {
                //Diagonal Top Right To Bottom Left
                if (SquareDoneX[4])
                {
                    if (SquareDoneX[6])
                    {

                        check = 1;
                    }
                }
                //Right Down
                if (SquareDoneX[5])
                {
                    if (SquareDoneX[8])
                    {
                        SquareDoneX[0] = true;
                        check = 1;
                    }
                }
            }

            //Across the middle
            if (SquareDoneX[5])
            {
                if (SquareDoneX[4])
                {
                    if (SquareDoneX[3])
                    {

                        check = 1;
                    }
                }
            }
            //Across the bottom
            if (SquareDoneX[6])
            {
                if (SquareDoneX[7])
                {
                    if (SquareDoneX[8])
                    {

                        check = 1;
                    }
                }
            }
            return check;
        }


        public int UltimatePermutaionsO() {

            //Skeleton For Ultimate Permutations

            int check = 0;

            //First Section
            if (SquareDoneO[0])
            {
                //Across the top
                if (SquareDoneO[1])
                {
                    if (SquareDoneO[2])
                    {

                        check = 1;
                    }
                }
                //Left Down
                if (SquareDoneO[3])
                {
                    if (SquareDoneO[6])
                    {

                        check = 1;
                    }
                }
                //Diagonal Top Left To Bottom Right
                if (SquareDoneO[4])
                {
                    if (SquareDoneO[8])
                    {

                        check = 1;
                    }
                }

            }

            //Middle Down
            if (SquareDoneO[1])
            {
                if (SquareDoneO[4])
                {
                    if (SquareDoneO[7])
                    {
                        check = 1;
                    }
                }
            }


            if (SquareDoneO[2])
            {
                //Diagonal Top Right To Bottom Left
                if (SquareDoneO[4])
                {
                    if (SquareDoneO[6])
                    {

                        check = 1;
                    }
                }
                //Right Down
                if (SquareDoneO[5])
                {
                    if (SquareDoneO[8])
                    {
                        SquareDoneO[0] = true;
                        check = 1;
                    }
                }
            }

            //Across the middle
            if (SquareDoneO[5])
            {
                if (SquareDoneO[4])
                {
                    if (SquareDoneO[3])
                    {

                        check = 1;
                    }
                }
            }
            //Across the bottom
            if (SquareDoneO[6])
            {
                if (SquareDoneO[7])
                {
                    if (SquareDoneO[8])
                    {

                        check = 1;
                    }
                }
            }
            return check;
        }
    }
}
