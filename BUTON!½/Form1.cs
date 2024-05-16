using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUTON__
{
   
    public partial class Form1 : Form

    {

        public Form1()

        {

            InitializeComponent();
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;

        }

        private void button1_Click(object sender, EventArgs e)

        {

            Button btn = new Button();

            btn.Location = new Point(button1.Right + 5, button1.Top);

            btn.MouseMove += control_MouseMove;

            Controls.Add(btn);

            btn.BringToFront();

        }

        private void control_MouseMove(object sender, MouseEventArgs e)
        {
            Control ctl = sender as Control;

           
            if (ctl.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                
                Controls.Remove(ctl);
                ctl.Dispose(); 
            }
            else
            {
               
                ctl.Location = PointToClient(Cursor.Position);
            }
        }

        private void control_Mouseup(object sender, MouseEventArgs e)

        {

        }

        private void button2_Click(object sender, EventArgs e)

        {

            PictureBox btn2 = new PictureBox();

            btn2.BackColor = Color.Black;

            btn2.Location = new Point(button1.Right + 5, button1.Top);

            btn2.MouseMove += control_MouseMove;

            Controls.Add(btn2);

            btn2.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)

        {

            Label btn3 = new Label();

            btn3.Location = new Point(button1.Right + 5, button1.Top);

            btn3.MouseMove += control_MouseMove;

            Controls.Add(btn3);

            btn3.BringToFront();

        }
        

    }

}
