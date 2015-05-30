//Alexander Tappin
//Paint Application
//April 2015
//Oregon Institute of Technology GUI
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace PaintApplication
{
    public partial class Form_main : Form
    {
        Graphics g;
        Image bmp;
        Rectangle rectangle; //Rectangle for selection functionality
        Pen p = new Pen(Color.Black, 2);
        Point sp = new Point(0, 0);
        Point ep = new Point(0, 0);
        int k = 0; //Could have used boolean value instead, if Left-Click, becomes 1
        int click_count = 0; //Used for Bezier Curve drawing
        List<Point> point_list = new List<Point>();
        Point[] bezier_point_arry = new Point[4]; //Array to hold bezier array points
        Bitmap SelectBitmap; //Seperate bitmap for selected part of image by user
        bool Select = false; //Select boolean variable for if user is selecting or not

        public Form_main()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            bmp = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height, g);
            g = Graphics.FromImage(bmp);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //starting point is where clicked
            sp = e.Location;

            if (e.Button == MouseButtons.Left)
            {
                k = 1;//If left-click, k becomes 1
            }

            switch (toolStripTextBox_ToolSelected.Text)
            {
                //Opens another form for entering text and font size
                case "Text":
                    Text_Form form = new Text_Form();
                    DialogResult obj = form.ShowDialog();
                    if (obj == DialogResult.OK)
                    {
                        string s_font = form.textBox_FontSize.Text;
                        int font = Int32.Parse(s_font);
                        string text = form.textBox_TextWord.Text;
                        //to make sure program doesn't break from incorrect font size
                        if (font > 0 || font < 200)
                        {
                            Font fnt = new Font("Times New Roman", font);
                            g.DrawString(text, fnt, p.Brush, e.Location);
                            pictureBox1.Image = bmp;
                        }
                    }
                    //will be unclicked, so resets k to 0
                    k = 0;
                    break;
                case "Polygon":
                    point_list.Add(e.Location);
                    break;
                case "Bezier":
                    if (click_count < 4)
                    {
                        bezier_point_arry[click_count] = e.Location;
                    }
                    click_count++;

                    //Bezier requires 4 points
                    if (click_count == 4)
                    {
                        Point pt1 = bezier_point_arry[0];
                        Point pt2 = bezier_point_arry[1];
                        Point pt3 = bezier_point_arry[2];
                        Point pt4 = bezier_point_arry[3];
                        g.DrawBezier(p, pt1, pt2, pt3, pt4);
                        click_count = 0;//reset click count
                        pictureBox1.Image = bmp;
                    }
                    break;
                default:
                    break;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Pen SelectPen = new Pen(Color.Black, 1);
            ep = e.Location;
            //Used function x or y values are flipped and when subtracted aren't negative
            CheckCoordValue(ref ep, ref sp);
            int X_coord = ep.X - sp.X;
            int Y_coord = ep.Y - sp.Y;
            switch (toolStripTextBox_ToolSelected.Text)
            {
                case "Bezier":
                    break;
                case "Ellipse":
                    g.DrawEllipse(p, sp.X, sp.Y, X_coord, Y_coord);
                    pictureBox1.Image = bmp;
                    break;
                case "Polygon":
                    break;
                case "Rectangle":
                    g.DrawRectangle(p, sp.X, sp.Y, X_coord, Y_coord);
                    pictureBox1.Image = bmp;
                    break;
                case "Line":
                    g.DrawLine(p, sp, ep);
                    pictureBox1.Image = bmp;
                    break;
                case "Select":
                    //Attempt for select, tried to have user select a "rectangle"
                    //of image, and then create bitmap of that, then to perform
                    //action on just specific selected bitmap later
                    g.DrawRectangle(SelectPen, sp.X, sp.Y, X_coord, Y_coord);
                    rectangle = new Rectangle(sp.X, sp.Y, X_coord, Y_coord);
                    pictureBox1.Image = bmp;
                    SelectBitmap = new Bitmap(rectangle.Width, rectangle.Height);
                    break;
                default:
                    break;
            }
            k = 0;
        }

        private void CheckCoordValue(ref Point ep, ref Point sp)
        {
            if (ep.X < sp.X)
            {
                int temp = ep.X;
                ep.X = sp.X;
                sp.X = temp;
            }

            if (ep.Y < sp.Y)
            {
                int temp = ep.Y;
                ep.Y = sp.Y;
                sp.Y = temp;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            p.Color = colorDialog1.Color;
            //If holding the click button
            if (k == 1)
            {
                ep = e.Location;

                switch (toolStripTextBox_ToolSelected.Text)
                {
                    case "Bezier":
                        break;
                    case "Ellipse":
                        break;
                    case "Polygon":
                        break;
                    case "Rectangle":
                        break;
                    case "Line":
                        break;
                    case "Select":
                        break;
                    case "Brush Size 1":
                        g.FillEllipse(p.Brush, e.X, e.Y, 8, 8);
                        pictureBox1.Image = bmp;
                        sp = ep;
                        break;
                    case "Brush Size 2":
                        g.FillEllipse(p.Brush, e.X, e.Y, 12, 12);
                        pictureBox1.Image = bmp;
                        sp = ep;
                        break;
                    case "Brush Size 3":
                        g.FillEllipse(p.Brush, e.X, e.Y, 20, 20);
                        pictureBox1.Image = bmp;
                        sp = ep;
                        break;
                    default:
                        g.DrawLine(p, sp, ep);
                        pictureBox1.Image = bmp;
                        sp = ep;
                        break;
                }
            }
        }

        //Sets things visible or not, also menu items unchecked or checked

        private void toolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStrip_PaintTools.Visible == true)
            {
                toolStrip_PaintTools.Visible = false;
                toolToolStripMenuItem.Checked = false;
            }
            else
            {
                toolStrip_PaintTools.Visible = true;
                toolToolStripMenuItem.Checked = true;
            }
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStrip_Action.Visible == true)
            {
                statusBarToolStripMenuItem.Checked = false;
                toolStrip_Action.Visible = false;
            }
            else
            {
                statusBarToolStripMenuItem.Checked = true;
                toolStrip_Action.Visible = true;
            }
        }

        //Puts the text in the status bar
        private void toolStripButton_Bezier_Click(object sender, EventArgs e)
        {
            toolStripTextBox_ToolSelected.Text = "Bezier";
        }

        private void toolStripButton_Ellipse_Click(object sender, EventArgs e)
        {
            toolStripTextBox_ToolSelected.Text = "Ellipse";
        }

        private void toolStripButton_Polygon_Click(object sender, EventArgs e)
        {
            toolStripTextBox_ToolSelected.Text = "Polygon";
        }

        private void toolStripButton_Rectangle_Click(object sender, EventArgs e)
        {
            toolStripTextBox_ToolSelected.Text = "Rectangle";
        }

        private void toolStripButton_Line_Click(object sender, EventArgs e)
        {
            toolStripTextBox_ToolSelected.Text = "Line";
        }

        private void toolStripButton_Pencil_Click(object sender, EventArgs e)
        {
            toolStripTextBox_ToolSelected.Text = "Pencil";
            p.Width = 1;
        }

        private void toolStripButton_Text_Click(object sender, EventArgs e)
        {
            toolStripTextBox_ToolSelected.Text = "Text";
        }

        private void brush1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (brush1ToolStripMenuItem.Checked == false)
            {
                brush1ToolStripMenuItem.Checked = true;
                toolStripTextBox_ToolSelected.Text = "Brush Size 1";
                brush2ToolStripMenuItem.Checked = false;
                brush3ToolStripMenuItem.Checked = false;
            }
            else
                brush1ToolStripMenuItem.Checked = false;
        }

        private void brush2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (brush2ToolStripMenuItem.Checked == false)
            {
                brush2ToolStripMenuItem.Checked = true;
                toolStripTextBox_ToolSelected.Text = "Brush Size 2";
                brush1ToolStripMenuItem.Checked = false;
                brush3ToolStripMenuItem.Checked = false;
            }
            else
                brush2ToolStripMenuItem.Checked = false;
        }

        private void brush3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (brush3ToolStripMenuItem.Checked == false)
            {
                brush3ToolStripMenuItem.Checked = true;
                toolStripTextBox_ToolSelected.Text = "Brush Size 3";
                brush1ToolStripMenuItem.Checked = false;
                brush2ToolStripMenuItem.Checked = false;
            }
            else
                brush3ToolStripMenuItem.Checked = false;
        }

        //Inside alot of the following methods are basically if-else statements
        //checking if the user is doing image action on selected "bitmap", or just 
        //regular "bitmap"
        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Select == true)
            {
                if (horizontalToolStripMenuItem.Checked == false)
                {
                    horizontalToolStripMenuItem.Checked = true;
                    ActionTextBox.Text = "Horizontal Flip";
                    verticalToolStripMenuItem.Checked = false;
                    SelectBitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    g = Graphics.FromImage(SelectBitmap);
                    g.DrawImage(SelectBitmap, sp.X, sp.Y);
                }
                else
                    horizontalToolStripMenuItem.Checked = false;
            }
            else
            {
                if (horizontalToolStripMenuItem.Checked == false)
                {
                    horizontalToolStripMenuItem.Checked = true;
                    ActionTextBox.Text = "Horizontal Flip";
                    verticalToolStripMenuItem.Checked = false;
                    bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    pictureBox1.Image = bmp;
                }
                else
                    horizontalToolStripMenuItem.Checked = false;
            }
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Select == true)
            {
                if (verticalToolStripMenuItem.Checked == false)
                {
                    verticalToolStripMenuItem.Checked = true;
                    ActionTextBox.Text = "Vertical Flip";
                    horizontalToolStripMenuItem.Checked = false;
                    SelectBitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    pictureBox1.Image = SelectBitmap;
                }
                else
                    verticalToolStripMenuItem.Checked = false;
            }
            else
            {
                if (verticalToolStripMenuItem.Checked == false)
                {
                    verticalToolStripMenuItem.Checked = true;
                    ActionTextBox.Text = "Vertical Flip";
                    horizontalToolStripMenuItem.Checked = false;
                    bmp.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    pictureBox1.Image = bmp;
                }
                else
                    verticalToolStripMenuItem.Checked = false;
            }
        }

        private void degreesToolStripMenuItem90_Click(object sender, EventArgs e)
        {
            if (Select == true)
            {
                if (degreesToolStripMenuItem90.Checked == false)
                {
                    degreesToolStripMenuItem90.Checked = true;
                    ActionTextBox.Text = "90 Degree Rotation";
                    degreesToolStripMenuItem180.Checked = false;
                    degreesToolStripMenuItem270.Checked = false;
                    SelectBitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    pictureBox1.Image = SelectBitmap;
                }
                else
                    degreesToolStripMenuItem90.Checked = false;
            }
            else
            {
                if (degreesToolStripMenuItem90.Checked == false)
                {
                    degreesToolStripMenuItem90.Checked = true;
                    ActionTextBox.Text = "90 Degree Rotation";
                    degreesToolStripMenuItem180.Checked = false;
                    degreesToolStripMenuItem270.Checked = false;
                    bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    pictureBox1.Image = bmp;
                }
                else
                    degreesToolStripMenuItem90.Checked = false;
            }
        }

        private void degreesToolStripMenuItem180_Click(object sender, EventArgs e)
        {
            if (Select == true)
            {
                if (degreesToolStripMenuItem180.Checked == false)
                {
                    degreesToolStripMenuItem180.Checked = true;
                    ActionTextBox.Text = "180 Degree Rotation";
                    degreesToolStripMenuItem90.Checked = false;
                    degreesToolStripMenuItem270.Checked = false;
                    SelectBitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    pictureBox1.Image = SelectBitmap;
                }
                else
                    degreesToolStripMenuItem180.Checked = false;
            }
            else
            {
                if (degreesToolStripMenuItem180.Checked == false)
                {
                    degreesToolStripMenuItem180.Checked = true;
                    ActionTextBox.Text = "180 Degree Rotation";
                    degreesToolStripMenuItem90.Checked = false;
                    degreesToolStripMenuItem270.Checked = false;
                    bmp.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    pictureBox1.Image = bmp;
                }
                else
                    degreesToolStripMenuItem180.Checked = false;
            }
        }

        private void degreesToolStripMenuItem270_Click(object sender, EventArgs e)
        {
            if (Select == true)
            {
                if (degreesToolStripMenuItem270.Checked == false)
                {
                    degreesToolStripMenuItem270.Checked = true;
                    ActionTextBox.Text = "270 Degree Rotation";
                    degreesToolStripMenuItem180.Checked = false;
                    degreesToolStripMenuItem90.Checked = false;
                    SelectBitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    pictureBox1.Image = SelectBitmap;
                }
                else
                    degreesToolStripMenuItem270.Checked = false;
            }
            else
            {
                if (degreesToolStripMenuItem270.Checked == false)
                {
                    degreesToolStripMenuItem270.Checked = true;
                    ActionTextBox.Text = "270 Degree Rotation";
                    degreesToolStripMenuItem180.Checked = false;
                    degreesToolStripMenuItem90.Checked = false;
                    bmp.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    pictureBox1.Image = bmp;
                }
                else
                    degreesToolStripMenuItem270.Checked = false;
            }
        }

        //Didn't have time to do stretch or skew at last minute
        private void stretchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActionTextBox.Text = "Stretch";
        }

        private void skewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActionTextBox.Text = "Skew";
        }

        //When Stop Polygon is clicked
        private void toolStripButton_StopPolygon_Click(object sender, EventArgs e)
        {
            //g = pictureBox1.CreateGraphics();
            Point[] point_arry;
            point_arry = point_list.ToArray();

            Point first_point = point_arry.First();
            Point last_point = point_arry.Last();
            g.DrawLines(p, point_arry);
            //Need this to finish drawing the polgyon, wouldn't draw line from 1st to last point
            g.DrawLine(p, first_point, last_point);
            pictureBox1.Image = bmp;
        }

        //Attempt at select, setting a boolean value
        private void toolStripButton_Select_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox_ToolSelected.Text != "Select On")
            {
                toolStripTextBox_ToolSelected.Text = "Select On";
                Select = true;
            }
            else
            {
                toolStripTextBox_ToolSelected.Text = "Select Off";
                Select = false;
            }
        }

        private void SaveImageOption_Click(object sender, EventArgs e)
        {
            // save image to desired location
            // create new save file dialog
            SaveFileDialog s = new SaveFileDialog();

            // create a new bitmap of the drawing
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);

            // copy the image 
            Rectangle rect = pictureBox1.RectangleToScreen(pictureBox1.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, pictureBox1.Size);
            g.Dispose();

            // adding this saves a few lines, requires a namespace
            ImageFormat format = ImageFormat.Png;
            s.Filter = "Images|*.png; *.jpg; *.bmp";

            // get the file extension
            string extension = System.IO.Path.GetExtension(s.FileName);

            // check if save dialog opened
            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                switch (extension)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                // save file to specified format
                bmp.Save(s.FileName, format);
            }
        }

        //color Dialog thing!
        private void ColorClick(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }
    }
}
