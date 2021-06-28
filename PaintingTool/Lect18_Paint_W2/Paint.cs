using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lect18_Paint_W2
{
    public partial class Paint : Form
    {
        Pen p;
        int x = -1;
        int y = -1;
        bool isDrawing = false;
        bool isEraser = false;
        Graphics g;
        
        public Paint()
        {
            InitializeComponent();
            p = new Pen(Color.Black, 2);
            g = canvas.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            p.StartCap = p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        bool startPaint = false;
        int? initX = null;
        int? initY = null; bool drawSquare = false;
        bool drawRectangle = false;
        bool drawCircle = false;
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            p.Color = pb.BackColor;
            currentColor.BackColor = pb.BackColor;
            isEraser = false;
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            startPaint = true;
            if (drawSquare)
            {
                //Use Solid Brush for filling the graphic shapes
                SolidBrush sb = new SolidBrush(currentColor.BackColor);
                //setting the width and height same for creating square.
                //Getting the width and Heigt value from Textbox(txt_ShapeSize)
                g.FillRectangle(sb, e.X, e.Y, int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));
                //setting startPaint and drawSquare value to false for creating one graphic on one click.
                startPaint = false;
                drawSquare = false;
            }
            if (drawRectangle)
            {
                SolidBrush sb = new SolidBrush(currentColor.BackColor);
                //setting the width twice of the height
                g.FillRectangle(sb, e.X, e.Y, 2 * int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));
                startPaint = false;
                drawRectangle = false;
            }
            if (drawCircle)
            {
                SolidBrush sb = new SolidBrush(currentColor.BackColor);
                g.FillEllipse(sb, e.X, e.Y, int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));
                startPaint = false;
                drawCircle = false;
            }
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                x = e.X;
                y = e.Y;
                if (isEraser == false)
                {
                    p.Width = (float)sizeCount.Value;
                    canvas.Cursor = Cursors.Cross;
                }
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPaint)
            {
                //Setting the Pen BackColor and line Width
                Pen p = new Pen(currentColor.BackColor, float.Parse(sizeCount.Text));
                //Drawing the line.
                g.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                initX = e.X;
                initY = e.Y;
            }

            if (isDrawing == true)
            {
                g.DrawLine(p, x, y, e.X, e.Y);
                x = e.X;
                y = e.Y;
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            startPaint = false;
            initX = null;
            initY = null;

            isDrawing = false;
            x = -1;
            y = -1;
            canvas.Cursor = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            canvas.Refresh();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            isEraser = true;
            p.Color = canvas.BackColor;
            p.Width = 20;
                  
        }
        public void DrawPolygonPoint(PaintEventArgs e)
        {

            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create points that define polygon.
            Point point1 = new Point(50, 50);
            Point point2 = new Point(100, 25);
            Point point3 = new Point(200, 5);
            Point point4 = new Point(250, 50);
            Point point5 = new Point(300, 100);
            Point point6 = new Point(350, 200);
            Point point7 = new Point(250, 250);
            Point[] curvePoints =
                     {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
                 point6,
                 point7
             };

            // Draw polygon to screen.
            e.Graphics.DrawPolygon(blackPen, curvePoints);
        }
        
        private void pnl_Draw_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPaint)
            {
                //Setting the Pen BackColor and line Width
                Pen p = new Pen(currentColor.BackColor, float.Parse(sizeCount.Text));
                //Drawing the line.
                g.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                initX = e.X;
                initY = e.Y;
            }
        }
        private void pnl_Draw_MouseDown(object sender, MouseEventArgs e)
        {
            startPaint = true;
            if (drawSquare)
            {
                //Use Solid Brush for filling the graphic shapes
                SolidBrush sb = new SolidBrush(currentColor.BackColor);
                //setting the width and height same for creating square.
                //Getting the width and Heigt value from Textbox(txt_ShapeSize)
                g.FillRectangle(sb, e.X, e.Y, int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));
                //setting startPaint and drawSquare value to false for creating one graphic on one click.
                startPaint = false;
                drawSquare = false;
            }
            if (drawRectangle)
            {
                SolidBrush sb = new SolidBrush(currentColor.BackColor);
                //setting the width twice of the height
                g.FillRectangle(sb, e.X, e.Y, 2 * int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));
                startPaint = false;
                drawRectangle = false;
            }
            if (drawCircle)
            {
                SolidBrush sb = new SolidBrush(currentColor.BackColor);
                g.FillEllipse(sb, e.X, e.Y, int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));
                startPaint = false;
                drawCircle = false;
            }
            if (isEraser == false)
            {
                p.Width = (float)sizeCount.Value;
                canvas.Cursor = Cursors.Cross;
            }
        }
            //Fired when the mouse pointer is over the pnl_Draw and a mouse button is released.
            private void pnl_Draw_MouseUp(object sender, MouseEventArgs e)
        {
            startPaint = false;
            initX = null;
            initY = null;
        }

        private void picploygon_Click(object sender, EventArgs e)
        {
            drawCircle = true;
        }
        private void PicBox_Squar_Click(object sender, EventArgs e)
        {
            drawSquare = true;
        }

        private void PicBox_Rectangle_Click(object sender, EventArgs e)
        {
            drawRectangle = true;
        }
    }
}
