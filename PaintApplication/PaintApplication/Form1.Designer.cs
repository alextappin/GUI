namespace PaintApplication
{
    partial class Form_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipVerticallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.degreesToolStripMenuItem90 = new System.Windows.Forms.ToolStripMenuItem();
            this.degreesToolStripMenuItem180 = new System.Windows.Forms.ToolStripMenuItem();
            this.degreesToolStripMenuItem270 = new System.Windows.Forms.ToolStripMenuItem();
            this.stretchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveImageOption = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip_PaintTools = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Bezier = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Ellipse = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Polygon = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Rectangle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Line = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Pencil = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Text = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.brush1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brush2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brush3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton_Select = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel_ToolUsing = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox_ToolSelected = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton_StopPolygon = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ColorPicker = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip_Action = new System.Windows.Forms.ToolStrip();
            this.ActionLabel = new System.Windows.Forms.ToolStripLabel();
            this.ActionTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip_PaintTools.SuspendLayout();
            this.toolStrip_Action.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.imageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.toolToolStripMenuItem.Text = "Tool Box";
            this.toolToolStripMenuItem.Click += new System.EventHandler(this.toolToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.statusBarToolStripMenuItem.Text = "Status Bar";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.statusBarToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flipVerticallyToolStripMenuItem,
            this.rotateToolStripMenuItem,
            this.stretchToolStripMenuItem,
            this.skewToolStripMenuItem,
            this.SaveImageOption});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // flipVerticallyToolStripMenuItem
            // 
            this.flipVerticallyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.flipVerticallyToolStripMenuItem.Name = "flipVerticallyToolStripMenuItem";
            this.flipVerticallyToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.flipVerticallyToolStripMenuItem.Text = "Flip";
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.degreesToolStripMenuItem90,
            this.degreesToolStripMenuItem180,
            this.degreesToolStripMenuItem270});
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.rotateToolStripMenuItem.Text = "Rotate";
            // 
            // degreesToolStripMenuItem90
            // 
            this.degreesToolStripMenuItem90.Name = "degreesToolStripMenuItem90";
            this.degreesToolStripMenuItem90.Size = new System.Drawing.Size(137, 22);
            this.degreesToolStripMenuItem90.Text = "90 Degrees";
            this.degreesToolStripMenuItem90.Click += new System.EventHandler(this.degreesToolStripMenuItem90_Click);
            // 
            // degreesToolStripMenuItem180
            // 
            this.degreesToolStripMenuItem180.Name = "degreesToolStripMenuItem180";
            this.degreesToolStripMenuItem180.Size = new System.Drawing.Size(137, 22);
            this.degreesToolStripMenuItem180.Text = "180 Degrees";
            this.degreesToolStripMenuItem180.Click += new System.EventHandler(this.degreesToolStripMenuItem180_Click);
            // 
            // degreesToolStripMenuItem270
            // 
            this.degreesToolStripMenuItem270.Name = "degreesToolStripMenuItem270";
            this.degreesToolStripMenuItem270.Size = new System.Drawing.Size(137, 22);
            this.degreesToolStripMenuItem270.Text = "270 Degrees";
            this.degreesToolStripMenuItem270.Click += new System.EventHandler(this.degreesToolStripMenuItem270_Click);
            // 
            // stretchToolStripMenuItem
            // 
            this.stretchToolStripMenuItem.Name = "stretchToolStripMenuItem";
            this.stretchToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.stretchToolStripMenuItem.Text = "Stretch";
            this.stretchToolStripMenuItem.Click += new System.EventHandler(this.stretchToolStripMenuItem_Click);
            // 
            // skewToolStripMenuItem
            // 
            this.skewToolStripMenuItem.Name = "skewToolStripMenuItem";
            this.skewToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.skewToolStripMenuItem.Text = "Skew";
            this.skewToolStripMenuItem.Click += new System.EventHandler(this.skewToolStripMenuItem_Click);
            // 
            // SaveImageOption
            // 
            this.SaveImageOption.Name = "SaveImageOption";
            this.SaveImageOption.Size = new System.Drawing.Size(134, 22);
            this.SaveImageOption.Text = "Save Image";
            this.SaveImageOption.Click += new System.EventHandler(this.SaveImageOption_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(981, 684);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // toolStrip_PaintTools
            // 
            this.toolStrip_PaintTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Bezier,
            this.toolStripButton_Ellipse,
            this.toolStripButton_Polygon,
            this.toolStripButton_Rectangle,
            this.toolStripButton_Line,
            this.toolStripButton_Pencil,
            this.toolStripButton_Text,
            this.toolStripDropDownButton1,
            this.toolStripButton_Select,
            this.toolStripLabel_ToolUsing,
            this.toolStripTextBox_ToolSelected,
            this.toolStripButton_StopPolygon,
            this.toolStripSeparator1,
            this.ColorPicker});
            this.toolStrip_PaintTools.Location = new System.Drawing.Point(0, 24);
            this.toolStrip_PaintTools.Name = "toolStrip_PaintTools";
            this.toolStrip_PaintTools.Size = new System.Drawing.Size(984, 25);
            this.toolStrip_PaintTools.TabIndex = 3;
            this.toolStrip_PaintTools.Text = "toolStrip1";
            // 
            // toolStripButton_Bezier
            // 
            this.toolStripButton_Bezier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Bezier.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Bezier.Image")));
            this.toolStripButton_Bezier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Bezier.Name = "toolStripButton_Bezier";
            this.toolStripButton_Bezier.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Bezier.Text = "Bezier";
            this.toolStripButton_Bezier.Click += new System.EventHandler(this.toolStripButton_Bezier_Click);
            // 
            // toolStripButton_Ellipse
            // 
            this.toolStripButton_Ellipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Ellipse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Ellipse.Image")));
            this.toolStripButton_Ellipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Ellipse.Name = "toolStripButton_Ellipse";
            this.toolStripButton_Ellipse.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Ellipse.Text = "Ellipse";
            this.toolStripButton_Ellipse.Click += new System.EventHandler(this.toolStripButton_Ellipse_Click);
            // 
            // toolStripButton_Polygon
            // 
            this.toolStripButton_Polygon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Polygon.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Polygon.Image")));
            this.toolStripButton_Polygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Polygon.Name = "toolStripButton_Polygon";
            this.toolStripButton_Polygon.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Polygon.Text = "Polygon";
            this.toolStripButton_Polygon.Click += new System.EventHandler(this.toolStripButton_Polygon_Click);
            // 
            // toolStripButton_Rectangle
            // 
            this.toolStripButton_Rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Rectangle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Rectangle.Image")));
            this.toolStripButton_Rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Rectangle.Name = "toolStripButton_Rectangle";
            this.toolStripButton_Rectangle.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Rectangle.Text = "Rectangle";
            this.toolStripButton_Rectangle.Click += new System.EventHandler(this.toolStripButton_Rectangle_Click);
            // 
            // toolStripButton_Line
            // 
            this.toolStripButton_Line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Line.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Line.Image")));
            this.toolStripButton_Line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Line.Name = "toolStripButton_Line";
            this.toolStripButton_Line.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Line.Text = "Line";
            this.toolStripButton_Line.Click += new System.EventHandler(this.toolStripButton_Line_Click);
            // 
            // toolStripButton_Pencil
            // 
            this.toolStripButton_Pencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Pencil.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Pencil.Image")));
            this.toolStripButton_Pencil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Pencil.Name = "toolStripButton_Pencil";
            this.toolStripButton_Pencil.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Pencil.Text = "Pencil";
            this.toolStripButton_Pencil.Click += new System.EventHandler(this.toolStripButton_Pencil_Click);
            // 
            // toolStripButton_Text
            // 
            this.toolStripButton_Text.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Text.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Text.Image")));
            this.toolStripButton_Text.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Text.Name = "toolStripButton_Text";
            this.toolStripButton_Text.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Text.Text = "Text";
            this.toolStripButton_Text.Click += new System.EventHandler(this.toolStripButton_Text_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brush1ToolStripMenuItem,
            this.brush2ToolStripMenuItem,
            this.brush3ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "Brushes";
            // 
            // brush1ToolStripMenuItem
            // 
            this.brush1ToolStripMenuItem.Name = "brush1ToolStripMenuItem";
            this.brush1ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.brush1ToolStripMenuItem.Text = "Size 1";
            this.brush1ToolStripMenuItem.Click += new System.EventHandler(this.brush1ToolStripMenuItem_Click);
            // 
            // brush2ToolStripMenuItem
            // 
            this.brush2ToolStripMenuItem.Name = "brush2ToolStripMenuItem";
            this.brush2ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.brush2ToolStripMenuItem.Text = "Size 2";
            this.brush2ToolStripMenuItem.Click += new System.EventHandler(this.brush2ToolStripMenuItem_Click);
            // 
            // brush3ToolStripMenuItem
            // 
            this.brush3ToolStripMenuItem.Name = "brush3ToolStripMenuItem";
            this.brush3ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.brush3ToolStripMenuItem.Text = "Size 3";
            this.brush3ToolStripMenuItem.Click += new System.EventHandler(this.brush3ToolStripMenuItem_Click);
            // 
            // toolStripButton_Select
            // 
            this.toolStripButton_Select.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Select.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Select.Image")));
            this.toolStripButton_Select.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Select.Name = "toolStripButton_Select";
            this.toolStripButton_Select.Size = new System.Drawing.Size(42, 22);
            this.toolStripButton_Select.Text = "Select";
            this.toolStripButton_Select.Click += new System.EventHandler(this.toolStripButton_Select_Click);
            // 
            // toolStripLabel_ToolUsing
            // 
            this.toolStripLabel_ToolUsing.Name = "toolStripLabel_ToolUsing";
            this.toolStripLabel_ToolUsing.Size = new System.Drawing.Size(81, 22);
            this.toolStripLabel_ToolUsing.Text = "Tool Selected:";
            // 
            // toolStripTextBox_ToolSelected
            // 
            this.toolStripTextBox_ToolSelected.Name = "toolStripTextBox_ToolSelected";
            this.toolStripTextBox_ToolSelected.ReadOnly = true;
            this.toolStripTextBox_ToolSelected.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButton_StopPolygon
            // 
            this.toolStripButton_StopPolygon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_StopPolygon.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_StopPolygon.Image")));
            this.toolStripButton_StopPolygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_StopPolygon.Name = "toolStripButton_StopPolygon";
            this.toolStripButton_StopPolygon.Size = new System.Drawing.Size(82, 22);
            this.toolStripButton_StopPolygon.Text = "Stop Polygon";
            this.toolStripButton_StopPolygon.Click += new System.EventHandler(this.toolStripButton_StopPolygon_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ColorPicker
            // 
            this.ColorPicker.Name = "ColorPicker";
            this.ColorPicker.Size = new System.Drawing.Size(70, 22);
            this.ColorPicker.Text = "Select Color";
            this.ColorPicker.Click += new System.EventHandler(this.ColorClick);
            // 
            // toolStrip_Action
            // 
            this.toolStrip_Action.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionLabel,
            this.ActionTextBox});
            this.toolStrip_Action.Location = new System.Drawing.Point(0, 49);
            this.toolStrip_Action.Name = "toolStrip_Action";
            this.toolStrip_Action.Size = new System.Drawing.Size(984, 25);
            this.toolStrip_Action.TabIndex = 4;
            this.toolStrip_Action.Text = "toolStrip1";
            // 
            // ActionLabel
            // 
            this.ActionLabel.Name = "ActionLabel";
            this.ActionLabel.Size = new System.Drawing.Size(81, 22);
            this.ActionLabel.Text = "Image Action:";
            // 
            // ActionTextBox
            // 
            this.ActionTextBox.Name = "ActionTextBox";
            this.ActionTextBox.ReadOnly = true;
            this.ActionTextBox.Size = new System.Drawing.Size(125, 25);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 762);
            this.Controls.Add(this.toolStrip_Action);
            this.Controls.Add(this.toolStrip_PaintTools);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_main";
            this.Text = "Paint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip_PaintTools.ResumeLayout(false);
            this.toolStrip_PaintTools.PerformLayout();
            this.toolStrip_Action.ResumeLayout(false);
            this.toolStrip_Action.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipVerticallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem degreesToolStripMenuItem90;
        private System.Windows.Forms.ToolStripMenuItem degreesToolStripMenuItem180;
        private System.Windows.Forms.ToolStripMenuItem degreesToolStripMenuItem270;
        private System.Windows.Forms.ToolStripMenuItem stretchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skewToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip_PaintTools;
        private System.Windows.Forms.ToolStripButton toolStripButton_Bezier;
        private System.Windows.Forms.ToolStripButton toolStripButton_Ellipse;
        private System.Windows.Forms.ToolStripButton toolStripButton_Polygon;
        private System.Windows.Forms.ToolStripButton toolStripButton_Rectangle;
        private System.Windows.Forms.ToolStripButton toolStripButton_Line;
        private System.Windows.Forms.ToolStripButton toolStripButton_Pencil;
        private System.Windows.Forms.ToolStripButton toolStripButton_Text;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_ToolSelected;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_ToolUsing;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem brush1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brush2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brush3ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip_Action;
        private System.Windows.Forms.ToolStripLabel ActionLabel;
        private System.Windows.Forms.ToolStripTextBox ActionTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton_StopPolygon;
        private System.Windows.Forms.ToolStripButton toolStripButton_Select;
        private System.Windows.Forms.ToolStripMenuItem SaveImageOption;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripLabel ColorPicker;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

