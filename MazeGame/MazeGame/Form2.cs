using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You Beat the maze! Take a screenshot and send it to absolutenothingg!");
            Form3 fre = new Form3();
            fre.Show();

            this.Hide();
        }
        private void MoveToStart()
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(1, 1);
            Cursor.Position = PointToScreen(startingPoint);
        }
        private void label16_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }
        int flag = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                label13.Enabled = true;
                label13.Visible = true;
                flag = 1;
            }
            else
            {
                label13.Enabled = false;
                label13.Visible = false;
                flag = 0;
            }
        }

        private void label16_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label15_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label14_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label11_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label12_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label19_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label20_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label13_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label10_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
        private void MoveCursor()
        {
            // Set the Current cursor, move the cursor's Position,
            // and set its clipping rectangle to the form. 

            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Cursor.Position.X  -10, Cursor.Position.Y -10);
            Cursor.Clip = new Rectangle(this.Location, this.Size);
        }

        private void label16_MouseEnter_1(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label2_MouseEnter_1(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label19_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label20_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Failed!");
            Form1 fre = new Form1();
            fre.Show();

            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
