using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Метод_Брезенхема
{
    public partial class Form1 : Form
    {
        private int x1, y1, x2, y2;
        private Color lineColor = Color.Black;
        private float lineWidth = 1;

        public Form1()
        {
            InitializeComponent();
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;

            trackBar1.Minimum = 1;
            trackBar1.Value = 1;
        }

        private void Form1_Load(object sender, EventArgs e) {}

        private void label1_Click(object sender, EventArgs e) {}

        private void pictureBox1_Click(object sender, EventArgs e) {}

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            DrawLineBresenham(g, x1, y1, x2, y2, lineColor);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lineWidth = trackBar1.Value;
            lineWidthLabel.Text = $"Толщина отрезка: {lineWidth}";

            pictureBox1.Invalidate();
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(textBoxX1.Text, out int result))
            {
                if (result <= pictureBox1.Width)
                {
                    textBoxX1.ForeColor = Color.Black;
                    x1 = result;
                }
                else
                {
                    textBoxX1.ForeColor = Color.Red;
                }
            }
            else 
            {
                textBoxX1.ForeColor = Color.Black;
                x1 = 0; 
            }

            pictureBox1.Invalidate();
        }

        private void textBoxY1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxY1.Text, out int result))
            {
                if (result <= pictureBox1.Height)
                {
                    textBoxY1.ForeColor = Color.Black;
                    y1 = result;
                }
                else
                {
                    textBoxY1.ForeColor = Color.Red;
                }
            }
            else
            {
                textBoxY1.ForeColor = Color.Black;
                y1 = 0;
            }

            pictureBox1.Invalidate();
        }

        private void textBoxX2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxX2.Text, out int result))
            {
                if (result <= pictureBox1.Width)
                {
                    textBoxX2.ForeColor = Color.Black;
                    x2 = result;
                }
                else
                {
                    textBoxX2.ForeColor = Color.Red;
                }
            }
            else
            {
                textBoxX2.ForeColor = Color.Black;
                x2 = 0;
            }

            pictureBox1.Invalidate();
        }

        private void textBoxY2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxY2.Text, out int result))
            {
                if (result <= pictureBox1.Height)
                {
                    textBoxY2.ForeColor = Color.Black;
                    y2 = result;
                }
                else
                {
                    textBoxY2.ForeColor = Color.Red;
                }
            }
            else
            {
                textBoxY2.ForeColor = Color.Black;
                y2 = 0;
            }

            pictureBox1.Invalidate();
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                lineColor = colorDialog1.Color;

                pictureBox1.Invalidate();
            }
        }

        private void DrawLineBresenham(Graphics g, int x1, int y1, int x2, int y2, Color color)
        {
            int dx = Math.Abs(x2 - x1);
            int dy = Math.Abs(y2 - y1);
            int sx = x1 < x2 ? 1 : -1;
            int sy = y1 < y2 ? 1 : -1;
            int err = dx - dy;

            while (true)
            {
                g.FillRectangle(new SolidBrush(color), x1, y1, (int)lineWidth, (int)lineWidth);

                if (x1 == x2 && y1 == y2)
                    break;

                int err2 = 2 * err;
                if (err2 > -dy)
                {
                    err -= dy;
                    x1 += sx;
                }
                if (err2 < dx)
                {
                    err += dx;
                    y1 += sy;
                }
            }
        }
    }
}
