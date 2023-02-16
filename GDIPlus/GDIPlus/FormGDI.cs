using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIPlus
{
    public partial class FormGDI : Form
    {
        public FormGDI()
        {
            InitializeComponent();
 
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            var path = Directory.GetCurrentDirectory();
            for (int i = 0; i < 2; i++)
            {
                path = path.Remove(path.LastIndexOf('\\'));
            }

            Bitmap paper = new Bitmap(picture.Width, picture.Height);

 
            Graphics writer = Graphics.FromImage(paper);
            writer.Clear(Color.White);

            #region Line

            //Brush brush = new SolidBrush(Color.Red);

            ////Pen pen = new Pen(Color.Black, 3);
            //Pen pen2 = new Pen(brush, 3);

            //Point p1 = new Point(100, 200);
            //Point p2 = new Point(500, 200);
            //Point p3 = new Point(0, 0);
            //Point p4 = new Point(100, 200);

            //Point[] points =
            //{
            //    new Point(50,50),
            //    new Point(100,50),
            //    new Point(250,100),
            //    new Point(100,80),
            //    new Point(205,140),
            //};

            ////writer.DrawLine(pen,p1,p2);
            //// writer.DrawLine(pen2, p3, p4);
            //writer.DrawLines(pen2, points);


            #endregion

            #region Rectangles

            //Pen pen = new Pen(Color.Black, 5);
            //Rectangle rec = new Rectangle(50, 50, 200, 200);
            //Point[] array =
            //{
            //    new Point(10,150),
            //    new Point(50,100),
            //    new Point(100,200),
            //    new Point(200,300),
            //};
            //writer.DrawPolygon(pen, array);
            //writer.DrawRectangle(pen, rec);

            #endregion

            #region Ellipse | Circle

            //Pen pen = new Pen(Color.Blue, 30);
            //Pen penBlack = new Pen(Color.Black, 3);
            //Rectangle rec = new Rectangle(110, 110, 310, 310);


            //Brush brush1 = new SolidBrush(Color.Blue);
            //writer.FillEllipse(brush1, rec);
            //writer.DrawEllipse(penBlack, rec);

            #endregion

            #region Polygon
            //Pen pen = new Pen(Color.Blue, 5);

            //Point[] points =
            //{
            //    new Point(100,100),
            //    new Point(300,200),
            //    new Point(250,250),

            //};

            //Brush brush = new LinearGradientBrush(new Rectangle(0, 0, 500, 500), Color.Red, Color.Yellow, 90);
            ////writer.DrawPolygon(pen, points);
            //writer.FillPolygon(brush, points);


            #endregion

            #region Curves
            //Pen pen = new Pen(Color.Blue, 5);
            //Brush brush = new LinearGradientBrush(new Rectangle(0, 0, 500, 500), Color.Red, Color.Yellow, 90);

            //Point[] points =
            //{
            //    new Point(100,50),
            //    new Point(300,100),
            //    new Point(500,200),

            //};

            ////writer.DrawCurve(caneta, pontos, 3);
            ////writer.DrawClosedCurve(pen, points, 3, FillMode.Winding);
            //writer.FillClosedCurve(brush, points, FillMode.Winding);

            #endregion

            #region Arc

            //Pen pen = new Pen(Color.Blue, 5);
            //Brush brush = new LinearGradientBrush(new Rectangle(0, 0, 500, 500), Color.Red, Color.Yellow, 90);

            //Rectangle rec = new Rectangle(100, 100, 300, 250);
            //writer.DrawArc(pen, rec, 45f, 270f);

            #endregion

            #region Beziers
            //Pen pen = new Pen(Color.Blue, 5);
            //Point p1 = new Point(50, 300);
            //Point p2 = new Point(200, 400);
            //Point p3 = new Point(400, 10);
            //Point p4 = new Point(500, 200);

            //Point[] pontos = {
            //    new Point(50, 300),
            //    new Point(200, 400),
            //    new Point(400, 10),
            //    new Point(500, 200),
            //             new Point(80, 100),
            //             new Point(100, 200),
            //             new Point(500, 40),

            //         };

            //writer.DrawBeziers(pen, pontos);
            ////writer.DrawBezier(pen,p1,p2,p3,p4);

            #endregion

            #region PIE Graph
            //Pen pen = new Pen(Color.Blue, 5);
            //Brush brush = new LinearGradientBrush(new Rectangle(0, 0, 500, 500), Color.Red, Color.Yellow, 90);

            //Rectangle rec = new Rectangle(50, 50, 300, 300);

            //writer.DrawPie(pen, rec, 0, 90);
            //writer.FillPie(brush, rec, 30, 300); //PACMAN :D

            #endregion

            #region Path

            //Pen pen = new Pen(Color.Gray, 5);
            //Brush brush = new LinearGradientBrush(new Rectangle(0, 0, 500, 500), Color.Red, Color.Yellow, 90);

            //GraphicsPath graphicsPath = new GraphicsPath(FillMode.Alternate);

            //graphicsPath.AddEllipse(new RectangleF(10, 10, 100, 100));
            //graphicsPath.AddEllipse(new RectangleF(70, 10, 100, 100));
            //graphicsPath.AddEllipse(new RectangleF(130, 10, 100, 100));
            //graphicsPath.AddEllipse(new RectangleF(190, 10, 100, 100)); //AUDI :D


            //writer.FillPath(brush, graphicsPath);

            #endregion

            #region Strings
            //Brush brush = new LinearGradientBrush(new Rectangle(0, 0, 500, 500), Color.Red, Color.Yellow, 90);
            //Font font = new Font("Arial", 80, FontStyle.Bold, GraphicsUnit.Point);
            //Point pont = new Point(50, 100);
            //string str = "\nTexasS";
            //Rectangle rec = new Rectangle(10, 20, 500, 400);
            //StringFormat alignment1 = new StringFormat();
            //alignment1.Alignment = StringAlignment.Center;
            //alignment1.LineAlignment = StringAlignment.Center;
            ////alignment1.FormatFlags= StringFormatFlags.DirectionVertical;

            ////writer.DrawString(str,font,brush,pont);
            //writer.DrawString(str, font, brush, rec, alignment1);

            #endregion

            #region Img
            Image img1 = Image.FromFile(path + @"\img\cat.png");
            Rectangle rec = new Rectangle(100, 0, img1.Width, img1.Height);
            Rectangle rec2 = new Rectangle(100, 10, img1.Width, img1.Height);

            writer.DrawImage(img1, rec, rec2, GraphicsUnit.Pixel);

            #endregion

            #region IA

            ////Drawing generated by chat gpt

            //writer.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //// Sky
            //writer.FillRectangle(Brushes.LightSkyBlue, 0, 0, 500, 400);

            //// Grass
            //writer.FillRectangle(Brushes.Green, 0, 400, 500, 100);

            //// Sun
            //writer.FillEllipse(Brushes.Yellow, 375, 25, 100, 100);
            //writer.DrawEllipse(Pens.Black, 375, 25, 100, 100);
            //writer.FillEllipse(Brushes.Yellow, 400, 50, 50, 50);



            //// Head
            //writer.FillEllipse(Brushes.LightSalmon, 150, 50, 100, 100);

            //// Body
            //writer.FillRectangle(Brushes.Khaki, 175, 150, 50, 200);

            //// Arms
            //writer.FillRectangle(Brushes.Khaki, 125, 200, 50, 100);
            //writer.FillRectangle(Brushes.Khaki, 225, 200, 50, 100);

            //// Legs
            //writer.FillRectangle(Brushes.Khaki, 150, 350, 25, 100);
            //writer.FillRectangle(Brushes.Khaki, 200, 350, 25, 100);

            //// Eyes
            //writer.FillEllipse(Brushes.White, 170, 75, 20, 20);
            //writer.FillEllipse(Brushes.White, 210, 75, 20, 20);
            //writer.FillEllipse(Brushes.Black, 175, 80, 10, 10);
            //writer.FillEllipse(Brushes.Black, 215, 80, 10, 10);

            //// Mouth
            //writer.DrawArc(Pens.Black, 170, 105, 30, 20, 0, 180);

            //// Hair
            //writer.FillRectangle(Brushes.Black, 160, 45, 80, 5);
            //writer.FillRectangle(Brushes.Black, 170, 35, 60, 10);
            //writer.FillRectangle(Brushes.Black, 180, 25, 40, 15);

            //// Neck
            //writer.FillRectangle(Brushes.LightSalmon, 185, 150, 30, 25);

            //// Hands
            //writer.FillEllipse(Brushes.LightSalmon, 115, 300, 30, 30);
            //writer.FillEllipse(Brushes.LightSalmon, 245, 300, 30, 30);

            //// Shoes
            //writer.FillRectangle(Brushes.Black, 145, 420, 30, 40);
            //writer.FillRectangle(Brushes.Black, 215, 420, 30, 40);
            //writer.FillEllipse(Brushes.White, 145, 420, 30, 30);
            //writer.FillEllipse(Brushes.White, 215, 420, 30, 30);

            #endregion

            picture.BackgroundImage = paper;

            paper.Save(path + @"\img\Drawing.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
