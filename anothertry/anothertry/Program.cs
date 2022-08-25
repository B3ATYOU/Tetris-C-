using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace anothertry
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            VariableClass.create_overlist02();
            //bool[][] cool = VariableClass.over_list;
            //VariableClass.over_list[1][1] = true;
            VariableClass.print_bool_list(VariableClass.over_list);
            //bool[][] cool = new bool[3][];
            //cool[0] = new bool[3] {false,false,false };
            //cool[1] = new bool[3] { false, false, false };
            //cool[2] = new bool[3] { false, false, false };

            //variables.print_bool_list(cool);
            //Console.WriteLine(cool[0].Length);

            Thread.Sleep(1000);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 nice = new Form1();
    
            Application.Run(new Form1());
        }
    }
}
