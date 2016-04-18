using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace get_display_position
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int x, y;
            string x_string, y_string;

            x = MousePosition.X;
            y = MousePosition.Y;

            x_string = System.Convert.ToString(x);
            y_string = System.Convert.ToString(y);
            label1.Text = "(x,y) = " + x_string + "," + y_string;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int width, height;
            string width_string, height_string;

            /*
            width = this.Size.Width;
            height = this.Size.Height;
            */

            width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;

            width_string = System.Convert.ToString(width);
            height_string = System.Convert.ToString(height);

            label2.Text = "(Width, Height) = " + width_string + "," + height_string;

            draw_circle();
        }

        private System.Windows.Forms.Label[] labels;

        public void draw_circle()
        {
            int x = 0;
            int i, j;
            int cc = 0;

            for (i = 0; i < System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width; i++)
            {
                for (j = 0; j < System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height; j++)
                {
                    if ((i % 200 == 0) && (j % 200 == 0))
                    {
                        if (i == 0 || j == 0)
                            ;
                        else
                            cc++;
                    }
                }
            }
            this.labels = new System.Windows.Forms.Label[cc];

            for (i = 0; i < System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width; i++)
            {
                for (j = 0; j < System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height; j++)
                {
                    if ((i % 200 == 0) && (j % 200 == 0))
                    {
                        if (i == 0 || j == 0)
                        {
                            ;
                        }
                        else
                        {
                            this.labels[x] = new System.Windows.Forms.Label();

                            this.labels[x].Name = "labels" + x.ToString();
                            this.labels[x].Text = "●";
                            this.labels[x].Size = new Size(15,15);
                            this.labels[x].Location = new Point(i, j);

                            x++;
                        }
                    }
                }
            }
            this.Controls.AddRange(this.labels);
        }
    }
}