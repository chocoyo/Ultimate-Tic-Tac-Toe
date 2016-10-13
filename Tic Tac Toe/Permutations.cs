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
            //int check = 0;

            //First Section
            if (X.A11)
            {
                //Across the top
                if (X.A12)
                {
                    if (X.A13)
                    {
                        Square1Done = true;
                        //check = 1;
                    }
                }
                //Left Down
                if (X.B11)
                {
                    if (X.C11)
                    {
                        Square1Done = true;
                        //check = 1;
                    }
                }
                //Diagonal Top Left To Bottom Right
                if (X.B12)
                {
                    if (X.C13)
                    {
                        Square1Done = true;
                        //check = 1;
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
                        Square1Done = true;
                        //check = 1;
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
                        Square1Done = true;
                        //check = 1;
                    }
                }
                //Right Down
                if (X.B13)
                {
                    if (X.C13)
                    {
                        Square1Done = true;
                        //check = 1;
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
                        Square1Done = true;
                        //check = 1;
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
                        Square1Done = true;
                        //check = 1;
                    }
                }
            }



            //Section 2
            if (X.A21)
            {
                //Across the top
                if (X.A22)
                {
                    if (X.A23)
                    {
                        Square2Done = true;
                        //check = 1;
                    }
                }
                //Left Down
                if (X.B21)
                {
                    if (X.C21)
                    {
                        Square2Done = true;
                        //check = 1;
                    }
                }
                //Diagonal Top Left To Bottom Right
                if (X.B22)
                {
                    if (X.C23)
                    {
                        Square2Done = true;
                        //check = 1;
                    }
                }

            }

            //Middle Down
            if (X.A22)
            {
                if (X.B22)
                {
                    if (X.C22)
                    {
                        Square2Done = true;
                        //check = 1;
                    }
                }
            }


            if (X.A23)
            {
                //Diagonal Top Right To Bottom Left
                if (X.B22)
                {
                    if (X.C21)
                    {
                        Square2Done = true;
                        //check = 1;
                    }
                }
                //Right Down
                if (X.B23)
                {
                    if (X.C23)
                    {
                        Square2Done = true;
                        //check = 1;
                    }
                }
            }

            //Across the middle
            if (X.B23)
            {
                if (X.B22)
                {
                    if (X.B21)
                    {
                        Square2Done = true;
                        //check = 1;
                    }
                }
            }
            //Across the bottom
            if (X.C21)
            {
                if (X.C22)
                {
                    if (X.C23)
                    {
                        Square2Done = true;
                        //check = 1;
                    }
                }
            }


            //Section 3
            if (X.A31)
            {
                //Across the top
                if (X.A32)
                {
                    if (X.A33)
                    {
                        Square3Done = true;
                        //check = 1;
                    }
                }
                //Left Down
                if (X.B31)
                {
                    if (X.C31)
                    {
                        Square3Done = true;
                        //check = 1;
                    }
                }
                //Diagonal Top Left To Bottom Right
                if (X.B32)
                {
                    if (X.C33)
                    {
                        Square3Done = true;
                        //check = 1;
                    }
                }

            }

            //Middle Down
            if (X.A32)
            {
                if (X.B32)
                {
                    if (X.C32)
                    {
                        Square3Done = true;
                        //check = 1;
                    }
                }
            }


            if (X.A33)
            {
                //Diagonal Top Right To Bottom Left
                if (X.B32)
                {
                    if (X.C31)
                    {
                        Square3Done = true;
                        //check = 1;
                    }
                }
                //Right Down
                if (X.B33)
                {
                    if (X.C33)
                    {
                        Square3Done = true;
                        //check = 1;
                    }
                }
            }

            //Across the middle
            if (X.B33)
            {
                if (X.B32)
                {
                    if (X.B31)
                    {
                        Square3Done = true;
                        //check = 1;
                    }
                }
            }
            //Across the bottom
            if (X.C31)
            {
                if (X.C32)
                {
                    if (X.C33)
                    {
                        Square3Done = true;
                        //check = 1;
                    }
                }
            }
            
            //Forth Section
            if (X.A41)
            {
                //Across the top
                if (X.A42)
                {
                    if (X.A43)
                    {
                        Square4Done = true;
                        //check = 1;
                    }
                }
                //Left Down
                if (X.B41)
                {
                    if (X.C41)
                    {
                        Square4Done = true;
                        //check = 1;
                    }
                }
                //Diagonal Top Left To Bottom Right
                if (X.B42)
                {
                    if (X.C43)
                    {
                        Square4Done = true;
                        //check = 1;
                    }
                }

            }

            //Middle Down
            if (X.A42)
            {
                if (X.B42)
                {
                    if (X.C42)
                    {
                        Square4Done = true;
                        //check = 1;
                    }
                }
            }


            if (X.A43)
            {
                //Diagonal Top Right To Bottom Left
                if (X.B42)
                {
                    if (X.C41)
                    {
                        Square4Done = true;
                        //check = 1;
                    }
                }
                //Right Down
                if (X.B43)
                {
                    if (X.C43)
                    {
                        Square4Done = true;
                        //check = 1;
                    }
                }
            }

            //Across the middle
            if (X.B43)
            {
                if (X.B42)
                {
                    if (X.B41)
                    {
                        Square4Done = true;
                        //check = 1;
                    }
                }
            }
            //Across the bottom
            if (X.C41)
            {
                if (X.C42)
                {
                    if (X.C43)
                    {
                        Square4Done = true;
                        //check = 1;
                    }
                }
            }


            //Fifth Section
            if (X.A51)
            {
                //Across the top
                if (X.A52)
                {
                    if (X.A53)
                    {
                        Square5Done = true;
                        //check = 1;
                    }
                }
                //Left Down
                if (X.B51)
                {
                    if (X.C51)
                    {
                        Square5Done = true;
                        //check = 1;
                    }
                }
                //Diagonal Top Left To Bottom Right
                if (X.B52)
                {
                    if (X.C53)
                    {
                        Square5Done = true;
                        //check = 1;
                    }
                }

            }

            //Middle Down
            if (X.A52)
            {
                if (X.B52)
                {
                    if (X.C52)
                    {
                        Square5Done = true;
                        //check = 1;
                    }
                }
            }


            if (X.A53)
            {
                //Diagonal Top Right To Bottom Left
                if (X.B52)
                {
                    if (X.C51)
                    {
                        Square5Done = true;
                        //check = 1;
                    }
                }
                //Right Down
                if (X.B53)
                {
                    if (X.C53)
                    {
                        Square5Done = true;
                        //check = 1;
                    }
                }
            }

            //Across the middle
            if (X.B53)
            {
                if (X.B52)
                {
                    if (X.B51)
                    {
                        Square5Done = true;
                        //check = 1;
                    }
                }
            }
            //Across the bottom
            if (X.C51)
            {
                if (X.C52)
                {
                    if (X.C53)
                    {
                        Square5Done = true;
                        //check = 1;
                    }
                }
            }


            //Sixth Section
            if (X.A61)
            {
                //Across the top
                if (X.A62)
                {
                    if (X.A63)
                    {
                        Square6Done = true;
                        //check = 1;
                    }
                }
                //Left Down
                if (X.B61)
                {
                    if (X.C61)
                    {
                        Square6Done = true;
                        //check = 1;
                    }
                }
                //Diagonal Top Left To Bottom Right
                if (X.B62)
                {
                    if (X.C63)
                    {
                        Square6Done = true;
                        //check = 1;
                    }
                }

            }

            //Middle Down
            if (X.A62)
            {
                if (X.B62)
                {
                    if (X.C62)
                    {
                        Square6Done = true;
                        //check = 1;
                    }
                }
            }


            if (X.A63)
            {
                //Diagonal Top Right To Bottom Left
                if (X.B62)
                {
                    if (X.C61)
                    {
                        Square6Done = true;
                        //check = 1;
                    }
                }
                //Right Down
                if (X.B63)
                {
                    if (X.C63)
                    {
                        Square6Done = true;
                        //check = 1;
                    }
                }
            }

            //Across the middle
            if (X.B63)
            {
                if (X.B62)
                {
                    if (X.B61)
                    {
                        Square6Done = true;
                        //check = 1;
                    }
                }
            }
            //Across the bottom
            if (X.C61)
            {
                if (X.C62)
                {
                    if (X.C63)
                    {
                        Square6Done = true;
                        //check = 1;
                    }
                }
            }



            //7th Section
            if (X.A71)
            {
                //Across the top
                if (X.A72)
                {
                    if (X.A73)
                    {
                        Square7Done = true;
                        //check = 1;
                    }
                }
                //Left Down
                if (X.B71)
                {
                    if (X.C71)
                    {
                        Square7Done = true;
                        //check = 1;
                    }
                }
                //Diagonal Top Left To Bottom Right
                if (X.B72)
                {
                    if (X.C73)
                    {
                        Square7Done = true;
                        //check = 1;
                    }
                }

            }

            //Middle Down
            if (X.A72)
            {
                if (X.B72)
                {
                    if (X.C72)
                    {
                        Square7Done = true;
                        //check = 1;
                    }
                }
            }


            if (X.A73)
            {
                //Diagonal Top Right To Bottom Left
                if (X.B72)
                {
                    if (X.C71)
                    {
                        Square7Done = true;
                        //check = 1;
                    }
                }
                //Right Down
                if (X.B73)
                {
                    if (X.C73)
                    {
                        Square7Done = true;
                        //check = 1;
                    }
                }
            }

            //Across the middle
            if (X.B73)
            {
                if (X.B72)
                {
                    if (X.B71)
                    {
                        Square7Done = true;
                        //check = 1;
                    }
                }
            }
            //Across the bottom
            if (X.C71)
            {
                if (X.C72)
                {
                    if (X.C73)
                    {
                        Square7Done = true;
                        //check = 1;
                    }
                }
            }


            //8th Section
            if (X.A81)
            {
                //Across the top
                if (X.A82)
                {
                    if (X.A83)
                    {
                        Square8Done = true;
                        //check = 1;
                    }
                }
                //Left Down
                if (X.B81)
                {
                    if (X.C81)
                    {
                        Square8Done = true;
                        //check = 1;
                    }
                }
                //Diagonal Top Left To Bottom Right
                if (X.B82)
                {
                    if (X.C83)
                    {
                        Square8Done = true;
                        //check = 1;
                    }
                }

            }

            //Middle Down
            if (X.A82)
            {
                if (X.B82)
                {
                    if (X.C82)
                    {
                        Square8Done = true;
                        //check = 1;
                    }
                }
            }


            if (X.A83)
            {
                //Diagonal Top Right To Bottom Left
                if (X.B82)
                {
                    if (X.C81)
                    {
                        Square8Done = true;
                        //check = 1;
                    }
                }
                //Right Down
                if (X.B83)
                {
                    if (X.C83)
                    {
                        Square8Done = true;
                        //check = 1;
                    }
                }
            }

            //Across the middle
            if (X.B83)
            {
                if (X.B82)
                {
                    if (X.B81)
                    {
                        Square8Done = true;
                        //check = 1;
                    }
                }
            }
            //Across the bottom
            if (X.C81)
            {
                if (X.C82)
                {
                    if (X.C83)
                    {
                        Square8Done = true;
                        //check = 1;
                    }
                }
            }




            //9th Section
            if (X.A91)
            {
                //Across the top
                if (X.A92)
                {
                    if (X.A93)
                    {
                        Square9Done = true;
                        //check = 1;
                    }
                }
                //Left Down
                if (X.B91)
                {
                    if (X.C91)
                    {
                        Square9Done = true;
                        //check = 1;
                    }
                }
                //Diagonal Top Left To Bottom Right
                if (X.B92)
                {
                    if (X.C93)
                    {
                        Square9Done = true;
                        //check = 1;
                    }
                }

            }

            //Middle Down
            if (X.A92)
            {
                if (X.B92)
                {
                    if (X.C92)
                    {
                        Square9Done = true;
                        //check = 1;
                    }
                }
            }


            if (X.A93)
            {
                //Diagonal Top Right To Bottom Left
                if (X.B92)
                {
                    if (X.C91)
                    {
                        Square9Done = true;
                        //check = 1;
                    }
                }
                //Right Down
                if (X.B93)
                {
                    if (X.C93)
                    {
                        Square9Done = true;
                        //check = 1;
                    }
                }
            }

            //Across the middle
            if (X.B93)
            {
                if (X.B92)
                {
                    if (X.B91)
                    {
                        Square9Done = true;
                        //check = 1;
                    }
                }
            }
            //Across the bottom
            if (X.C91)
            {
                if (X.C92)
                {
                    if (X.C93)
                    {
                        Square9Done = true;
                        //check = 1;
                    }
                }
            }



            //return check;
        }




        public void oPermutations()
        {

            //int check = 0;

            //First Section
            if (O.A11)
            {
                //Across the top
                if (O.A12)
                {
                    if (O.A13)
                    {
                        Square1Done = true;
                        //check = 1;
                    }
                }
                //Left Down
                if (O.B11)
                {
                    if (O.C11)
                    {
                        Square1Done = true;
                        //check = 1;
                    }
                }
                //Diagonal Top Left To Bottom Right
                if (O.B12)
                {
                    if (O.C13)
                    {
                        Square1Done = true;
                        //check = 1;
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
                        Square1Done = true;
                        //check = 1;
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
                        Square1Done = true;
                        //check = 1;
                    }
                }
                //Right Down
                if (O.B13)
                {
                    if (O.C13)
                    {
                        Square1Done = true;
                        //check = 1;
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
                        Square1Done = true;
                        //check = 1;
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
                        Square1Done = true;
                        //check = 1;
                    }
                }
            }



            //Section 2
            if (O.A21)
            {
                //Across the top
                if (O.A22)
                {
                    if (O.A23)
                    {
                        Square2Done = true;
                        //check = 1;
                    }
                }
                //Left Down
                if (O.B21)
                {
                    if (O.C21)
                    {
                        Square2Done = true;
                        //check = 1;
                    }
                }
                //Diagonal Top Left To Bottom Right
                if (O.B22)
                {
                    if (O.C23)
                    {
                        Square2Done = true;
                        //check = 1;
                    }
                }

            }

            //Middle Down
            if (O.A22)
            {
                if (O.B22)
                {
                    if (O.C22)
                    {
                        Square2Done = true;
                        //check = 1;
                    }
                }
            }


            if (O.A23)
            {
                //Diagonal Top Right To Bottom Left
                if (O.B22)
                {
                    if (O.C21)
                    {
                        Square2Done = true;
                        //check = 1;
                    }
                }
                //Right Down
                if (O.B23)
                {
                    if (O.C23)
                    {
                        Square2Done = true;
                        //check = 1;
                    }
                }
            }

            //Across the middle
            if (O.B23)
            {
                if (O.B22)
                {
                    if (O.B21)
                    {
                        Square2Done = true;
                        //check = 1;
                    }
                }
            }
            //Across the bottom
            if (O.C21)
            {
                if (O.C22)
                {
                    if (O.C23)
                    {
                        Square2Done = true;
                        //check = 1;
                    }
                }
            }


            //Section 3
            if (O.A31)
            {
                //Across the top
                if (O.A32)
                {
                    if (O.A33)
                    {
                        Square3Done = true;
                        //check = 1;
                    }
                }
                //Left Down
                if (O.B31)
                {
                    if (O.C31)
                    {
                        Square3Done = true;
                        //check = 1;
                    }
                }
                //Diagonal Top Left To Bottom Right
                if (O.B32)
                {
                    if (O.C33)
                    {
                        Square3Done = true;
                        //check = 1;
                    }
                }

            }

            //Middle Down
            if (O.A32)
            {
                if (O.B32)
                {
                    if (O.C32)
                    {
                        Square3Done = true;
                        //check = 1;
                    }
                }
            }


            if (O.A33)
            {
                //Diagonal Top Right To Bottom Left
                if (O.B32)
                {
                    if (O.C31)
                    {
                        Square3Done = true;
                        //check = 1;
                    }
                }
                //Right Down
                if (O.B33)
                {
                    if (O.C33)
                    {
                        Square3Done = true;
                        //check = 1;
                    }
                }
            }

            //Across the middle
            if (O.B33)
            {
                if (O.B32)
                {
                    if (O.B31)
                    {
                        Square3Done = true;
                        //check = 1;
                    }
                }
            }
            //Across the bottom
            if (O.C31)
            {
                if (O.C32)
                {
                    if (O.C33)
                    {
                        Square3Done = true;
                        //check = 1;
                    }
                }
            }

            //Forth Section
            if (O.A41)
            {
                //Across the top
                if (O.A42)
                {
                    if (O.A43)
                    {
                        Square4Done = true;
                        //check = 1;
                    }
                }
                //Left Down
                if (O.B41)
                {
                    if (O.C41)
                    {
                        Square4Done = true;
                        //check = 1;
                    }
                }
                //Diagonal Top Left To Bottom Right
                if (O.B42)
                {
                    if (O.C43)
                    {
                        Square4Done = true;
                        //check = 1;
                    }
                }

            }

            //Middle Down
            if (O.A42)
            {
                if (O.B42)
                {
                    if (O.C42)
                    {
                        Square4Done = true;
                        //check = 1;
                    }
                }
            }


            if (O.A43)
            {
                //Diagonal Top Right To Bottom Left
                if (O.B42)
                {
                    if (O.C41)
                    {
                        Square4Done = true;
                        //check = 1;
                    }
                }
                //Right Down
                if (O.B43)
                {
                    if (O.C43)
                    {
                        Square4Done = true;
                        //check = 1;
                    }
                }
            }

            //Across the middle
            if (O.B43)
            {
                if (O.B42)
                {
                    if (O.B41)
                    {
                        Square4Done = true;
                        //check = 1;
                    }
                }
            }
            //Across the bottom
            if (O.C41)
            {
                if (O.C42)
                {
                    if (O.C43)
                    {
                        Square4Done = true;
                        //check = 1;
                    }
                }
            }


            //Fifth Section
            if (O.A51)
            {
                //Across the top
                if (O.A52)
                {
                    if (O.A53)
                    {
                        Square5Done = true;
                        //check = 1;
                    }
                }
                //Left Down
                if (O.B51)
                {
                    if (O.C51)
                    {
                        Square5Done = true;
                        //check = 1;
                    }
                }
                //Diagonal Top Left To Bottom Right
                if (O.B52)
                {
                    if (O.C53)
                    {
                        Square5Done = true;
                        //check = 1;
                    }
                }

            }

            //Middle Down
            if (O.A52)
            {
                if (O.B52)
                {
                    if (O.C52)
                    {
                        Square5Done = true;
                        //check = 1;
                    }
                }
            }


            if (O.A53)
            {
                //Diagonal Top Right To Bottom Left
                if (O.B52)
                {
                    if (O.C51)
                    {
                        Square5Done = true;
                        //check = 1;
                    }
                }
                //Right Down
                if (O.B53)
                {
                    if (O.C53)
                    {
                        Square5Done = true;
                        //check = 1;
                    }
                }
            }

            //Across the middle
            if (O.B53)
            {
                if (O.B52)
                {
                    if (O.B51)
                    {
                        Square5Done = true;
                        //check = 1;
                    }
                }
            }
            //Across the bottom
            if (O.C51)
            {
                if (O.C52)
                {
                    if (O.C53)
                    {
                        Square5Done = true;
                        //check = 1;
                    }
                }
            }


            //SiOth Section
            if (O.A61)
            {
                //Across the top
                if (O.A62)
                {
                    if (O.A63)
                    {
                        Square6Done = true;
                        //check = 1;
                    }
                }
                //Left Down
                if (O.B61)
                {
                    if (O.C61)
                    {
                        Square6Done = true;
                        //check = 1;
                    }
                }
                //Diagonal Top Left To Bottom Right
                if (O.B62)
                {
                    if (O.C63)
                    {
                        Square6Done = true;
                        //check = 1;
                    }
                }

            }

            //Middle Down
            if (O.A62)
            {
                if (O.B62)
                {
                    if (O.C62)
                    {
                        Square6Done = true;
                        //check = 1;
                    }
                }
            }


            if (O.A63)
            {
                //Diagonal Top Right To Bottom Left
                if (O.B62)
                {
                    if (O.C61)
                    {
                        Square6Done = true;
                        //check = 1;
                    }
                }
                //Right Down
                if (O.B63)
                {
                    if (O.C63)
                    {
                        Square6Done = true;
                        //check = 1;
                    }
                }
            }

            //Across the middle
            if (O.B63)
            {
                if (O.B62)
                {
                    if (O.B61)
                    {
                        Square6Done = true;
                        //check = 1;
                    }
                }
            }
            //Across the bottom
            if (O.C61)
            {
                if (O.C62)
                {
                    if (O.C63)
                    {
                        Square6Done = true;
                        //check = 1;
                    }
                }
            }



            //7th Section
            if (O.A71)
            {
                //Across the top
                if (O.A72)
                {
                    if (O.A73)
                    {
                        Square7Done = true;
                        //check = 1;
                    }
                }
                //Left Down
                if (O.B71)
                {
                    if (O.C71)
                    {
                        Square7Done = true;
                        //check = 1;
                    }
                }
                //Diagonal Top Left To Bottom Right
                if (O.B72)
                {
                    if (O.C73)
                    {
                        Square7Done = true;
                        //check = 1;
                    }
                }

            }

            //Middle Down
            if (O.A72)
            {
                if (O.B72)
                {
                    if (O.C72)
                    {
                        Square7Done = true;
                        //check = 1;
                    }
                }
            }


            if (O.A73)
            {
                //Diagonal Top Right To Bottom Left
                if (O.B72)
                {
                    if (O.C71)
                    {
                        Square7Done = true;
                        //check = 1;
                    }
                }
                //Right Down
                if (O.B73)
                {
                    if (O.C73)
                    {
                        Square7Done = true;
                        //check = 1;
                    }
                }
            }

            //Across the middle
            if (O.B73)
            {
                if (O.B72)
                {
                    if (O.B71)
                    {
                        Square7Done = true;
                        //check = 1;
                    }
                }
            }
            //Across the bottom
            if (O.C71)
            {
                if (O.C72)
                {
                    if (O.C73)
                    {
                        Square7Done = true;
                        //check = 1;
                    }
                }
            }


            //8th Section
            if (O.A81)
            {
                //Across the top
                if (O.A82)
                {
                    if (O.A83)
                    {
                        Square8Done = true;
                        //check = 1;
                    }
                }
                //Left Down
                if (O.B81)
                {
                    if (O.C81)
                    {
                        Square8Done = true;
                        //check = 1;
                    }
                }
                //Diagonal Top Left To Bottom Right
                if (O.B82)
                {
                    if (O.C83)
                    {
                        Square8Done = true;
                        //check = 1;
                    }
                }

            }

            //Middle Down
            if (O.A82)
            {
                if (O.B82)
                {
                    if (O.C82)
                    {
                        Square8Done = true;
                        //check = 1;
                    }
                }
            }


            if (O.A83)
            {
                //Diagonal Top Right To Bottom Left
                if (O.B82)
                {
                    if (O.C81)
                    {
                        Square8Done = true;
                        //check = 1;
                    }
                }
                //Right Down
                if (O.B83)
                {
                    if (O.C83)
                    {
                        Square8Done = true;
                        //check = 1;
                    }
                }
            }

            //Across the middle
            if (O.B83)
            {
                if (O.B82)
                {
                    if (O.B81)
                    {
                        Square8Done = true;
                        //check = 1;
                    }
                }
            }
            //Across the bottom
            if (O.C81)
            {
                if (O.C82)
                {
                    if (O.C83)
                    {
                        Square8Done = true;
                        //check = 1;
                    }
                }
            }




            //9th Section
            if (O.A91)
            {
                //Across the top
                if (O.A92)
                {
                    if (O.A93)
                    {
                        Square9Done = true;
                        //check = 1;
                    }
                }
                //Left Down
                if (O.B91)
                {
                    if (O.C91)
                    {
                        Square9Done = true;
                        //check = 1;
                    }
                }
                //Diagonal Top Left To Bottom Right
                if (O.B92)
                {
                    if (O.C93)
                    {
                        Square9Done = true;
                        //check = 1;
                    }
                }

            }

            //Middle Down
            if (O.A92)
            {
                if (O.B92)
                {
                    if (O.C92)
                    {
                        Square9Done = true;
                        //check = 1;
                    }
                }
            }


            if (O.A93)
            {
                //Diagonal Top Right To Bottom Left
                if (O.B92)
                {
                    if (O.C91)
                    {
                        Square9Done = true;
                        //check = 1;
                    }
                }
                //Right Down
                if (O.B93)
                {
                    if (O.C93)
                    {
                        Square9Done = true;
                        //check = 1;
                    }
                }
            }

            //Across the middle
            if (O.B93)
            {
                if (O.B92)
                {
                    if (O.B91)
                    {
                        Square9Done = true;
                        //check = 1;
                    }
                }
            }
            //Across the bottom
            if (O.C91)
            {
                if (O.C92)
                {
                    if (O.C93)
                    {
                        Square9Done = true;
                        //check = 1;
                    }
                }
            }



            //return check;

        }


        public int UltimatePermutaions() {
            
            //Skeleton For Ultimate Permutations

            int check = 0;

            //First Section
            if (Square1Done)
            {
                //Across the top
                if (Square2Done)
                {
                    if (Square3Done)
                    {
                        
                        check = 1;
                    }
                }
                //Left Down
                if (Square4Done)
                {
                    if (Square7Done)
                    {
                       
                        check = 1;
                    }
                }
                //Diagonal Top Left To Bottom Right
                if (Square5Done)
                {
                    if (Square9Done)
                    {
                    
                        check = 1;
                    }
                }

            }

            //Middle Down
            if (Square2Done)
            {
                if (Square5Done)
                {
                    if (Square8Done)
                    {
                        check = 1;
                    }
                }
            }


            if (Square3Done)
            {
                //Diagonal Top Right To Bottom Left
                if (Square5Done)
                {
                    if (Square7Done)
                    {

                        check = 1;
                    }
                }
                //Right Down
                if (Square6Done)
                {
                    if (Square9Done)
                    {
                        Square1Done = true;
                        check = 1;
                    }
                }
            }

            //Across the middle
            if (Square6Done)
            {
                if (Square5Done)
                {
                    if (Square4Done)
                    {
                        
                        check = 1;
                    }
                }
            }
            //Across the bottom
            if (Square7Done)
            {
                if (Square8Done)
                {
                    if (Square9Done)
                    {
                        
                        check = 1;
                    }
                }
            }

            return check;





        }



    }
}
