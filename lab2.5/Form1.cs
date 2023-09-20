using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2._5
{
    public partial class Form1 : Form
    {
        private Dictionary<Control, Point> initialPositions = new Dictionary<Control, Point>();

        public Form1()
        {

            InitializeComponent();
            SaveInitialPositions();
        }

        private void SaveInitialPositions()
        {
            initialPositions.Clear();
            foreach (Control C in Controls)
            {
                if (C.Tag != null && C.Tag.ToString() == "1")
                {
                    initialPositions[C] = C.Location;
                }
            }
        }

        private double CalculateParallelogramArea()
        {

            Point[] parallelogramPoints = new Point[4];
            int i = 0;
            foreach (Control C in Controls)
            {
                if (C.Tag != null && C.Tag.ToString() == "1")
                {
                    parallelogramPoints[i] = C.Location;
                    i++;
                }
            }


            double area = Math.Abs(
                (parallelogramPoints[0].X * parallelogramPoints[1].Y +
                 parallelogramPoints[1].X * parallelogramPoints[2].Y +
                 parallelogramPoints[2].X * parallelogramPoints[3].Y +
                 parallelogramPoints[3].X * parallelogramPoints[0].Y -
                 parallelogramPoints[1].X * parallelogramPoints[0].Y -
                 parallelogramPoints[2].X * parallelogramPoints[1].Y -
                 parallelogramPoints[3].X * parallelogramPoints[2].Y -
                 parallelogramPoints[0].X * parallelogramPoints[3].Y) / 2.0);

            return area;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Control C in Controls)
            {
                if (C.Tag != null && C.Tag.ToString() == "1")
                {
                    C.Top--;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control C in Controls)
            {
                if (C.Tag != null && C.Tag.ToString() == "1")
                {
                    C.Top++;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Control C in Controls)
            {
                if (C.Tag != null && C.Tag.ToString() == "1")
                {
                    C.Left--;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (Control C in Controls)
            {
                if (C.Tag != null && C.Tag.ToString() == "1")
                {
                    C.Left++;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double parallelogramArea = CalculateParallelogramArea();
            labelResult.Text = parallelogramArea.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Button)sender).Tag = Convert.ToInt32(((Button)sender).Tag) * (-1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((Button)sender).Tag = Convert.ToInt32(((Button)sender).Tag) * (-1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ((Button)sender).Tag = Convert.ToInt32(((Button)sender).Tag) * (-1);
        }
    }
}
