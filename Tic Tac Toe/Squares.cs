using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Squares
    {
        //Bool Variables To Mark Which Sqaures Have Been Taken For Each Player
        public bool[,] A = new bool[9,3];
        public bool[,] B = new bool[9, 3];
        public bool[,] C = new bool[9, 3];
    }
}
