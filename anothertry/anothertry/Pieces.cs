using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anothertry
{
    internal class Pieces
    {

        public static bool t = true; public static bool f = false;

        public static bool[,] piece_01 = 
        {{ f,f,f,f,f},
         { f,f,f,f,f},
         { f,f,f,f,f},
         { f,f,f,f,f},
         { f,f,f,f,f}};

        public static bool[,] piece_02 =
        {{ f,f,f,f,f},
         { f,f,f,f,f},
         { f,f,f,f,f},
         { f,f,f,f,f},
         { f,f,f,f,f}};

        public static bool[,] piece_03 =
        {{ f,f,f,f,f},
         { f,f,f,f,f},
         { f,f,f,f,f},
         { f,f,f,f,f},
         { f,f,f,f,f}};

        public static bool[,] piece_04 =
        {{ f,f,f,f,f},
         { f,f,f,f,f},
         { f,f,f,f,f},
         { f,f,f,f,f},
         { f,f,f,f,f}};


        public static int[] find_bounds(bool[,] input_list) {

            int up = 5;
            int down = 0;

            int right = 0;
            int left = 5;

            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < 5; j++) {
                    if (input_list[i, j] == true) {
                        if (i>down) { down = i; }
                        if (i < up) { up = i; }
                        if (j > right) { right = j; }
                        if (j < left) { left = j; }

                    }
                }
            }

            int[] output_list = { left,up,right,down}; return output_list;
        }
    }
}
