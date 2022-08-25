using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace anothertry
{
    internal class VariableClass
    {

        public static int columns = 10;
        public static int rows = 10;
        public static bool[,] over_list;

        public void create_overlist01(int a,int b)
        {
            //columns = a;
            //rows = b;

            //bool[] cool = new bool[columns];
            //for (int j = 0; j < columns; j++)
            //{
            //    cool[j] = false;
            //}

            //over_list = new bool[rows,columns];

            //for (int i = 0; i < columns; i++)
            //{
            //    over_list[i,j] = cool;
            //}

            //List<bool[]> cool2 = new List<bool[]>();

            //for (int i = 0; i < rows; i++)
            //{
            //    cool2.Add(cool);
            //}

        }
        public static void create_overlist02()
        {
            string filePath = @"E:\C# Codes\My Code\anothertry\Bool.txt";

            //List<string> lines = new List<string>();
            //lines = File.ReadAllLines(filePath).ToList();
            string[] lines = File.ReadAllLines(filePath);

            rows = lines.Length;
            columns = lines[0].Length;

            over_list = new bool[rows, columns];

            int counter1 = 0;int counter2 = 0;

            foreach (string line in lines) {

                foreach (char val in line) {

                    if (val == '1')
                    {
                        over_list[counter1, counter2] = true;
                    }
                    else {
                        over_list[counter1, counter2] = false;
                    }

                    counter2++;
                }
                counter2=0;
                counter1++;
            }


        }


        public static void print_bool_list(bool[,] something) {
            int a = something.GetLength(0);
            int b = something.GetLength(1);

            for (int i=0; i < a; i++)
            {
                for (int j=0; j < b; j++) {
                    if (something[i,j] == true)
                    {
                        Console.Write("1");
                    }
                    else { 
                    Console.Write("0");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void clearlist() {

            for (int i = 0; i < rows; i++) {
                bool checker = true;
                for (int j = 0; j < columns; j++) {
                    if (over_list[i, j] == false) {
                        checker = false;
                    }
                }

                if (checker == true) {
                    for (int j = 0; j < columns; j++)
                    {
                        over_list[i, j] = false;
                    }
                }

            }

        }


    }
}
