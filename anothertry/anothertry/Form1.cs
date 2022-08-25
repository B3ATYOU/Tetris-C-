using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace anothertry
{
    public partial class Form1 : Form

    {
        static int gap = 10;
        static int rows = VariableClass.rows;
        static int columns = VariableClass.columns;
        static int height = 800 / rows - ((rows + 1) * gap / rows);
        static int width = 1200 / columns - ((columns + 1) * gap / columns);
        //Rectangle rect = new Rectangle(0,0, 800 / VariableClass.rows - (VariableClass.rows + 1) * 10, 800 / VariableClass.columns - (VariableClass.columns + 1) * 10);

        public void create_rect()
        {
            gap = 5;
        }
        //VariableClass.over_list;
        /////----------------
        ///
        SolidBrush black = new SolidBrush(Color.Black);
        SolidBrush lightblue = new SolidBrush(Color.LightBlue);

        /// ///////////////////-------------------------------
        int counter = 0;
        bool new_rect_creat=false;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            DoubleBuffered = true;
            Graphics g = e.Graphics;


            Rectangle duf = new Rectangle(100,100,100,100);
            Rectangle rect = new Rectangle(0,0,width,height);

      
            Thread.Sleep(100);



            for (int i = 0; i < rows; i++)
            {
                rect.Y = height * i + (i + 1) * gap;

                for (int j = 0; j < columns; j++)
                {

                    rect.X = width * j + (j + 1) * gap;
                    if (VariableClass.over_list[i,j] == true)
                    {
                        g.FillRectangle(lightblue, rect);
                    }
                    else
                    {
                        g.FillRectangle(black, rect);
                    }
                }
            }




            //for (int i = 0; i < columns; i++)
            //{
            //    rect.X += width * i + i * 10;
            //}


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            VariableClass.clearlist();
            Invalidate();
        }
    }
}
