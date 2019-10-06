using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SurvivalBackEnd;

namespace SurvivalUI
{
    public partial class Form1 : Form
    {
        SurvivalController sc = new SurvivalController();
        Lion l = new Lion();
        Rabbit r = new Rabbit();

        PictureBox[,] pb = new PictureBox[20, 20];
 

        public Form1()
        {
            InitializeComponent();
            


            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    pb[i, j] = new PictureBox();
                    pb[i, j].Location = new Point(i * 25 + 100, j * 25 + 100);
                    pb[i, j].Width = 25;
                    pb[i, j].Height = 25;
                    pb[i, j].Tag = null;
                    pb[i, j].Visible = true;
                    pb[i, j].BorderStyle = BorderStyle.FixedSingle;
                    pb[i, j].BringToFront();
                    Controls.Add(pb[i, j]);
                }
            }


        }
    }
}
