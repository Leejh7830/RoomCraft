using System;
using System.Drawing;
using System.Windows.Forms;

namespace RoomCraft
{
    public enum ShapeType
    {
        Rectangle,
        Ellipse
    }

    public partial class ShapeControl : Control
    {
        public ShapeType Shape { get; set; }

        public ShapeControl()
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
            this.Shape = ShapeType.Rectangle;
            this.Size = new Size(50, 50);
            this.Cursor = Cursors.Hand;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Graphics g = e.Graphics)
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (Brush brush = new SolidBrush(Color.Blue))
                {
                    switch (Shape)
                    {
                        case ShapeType.Rectangle:
                            g.FillRectangle(brush, this.ClientRectangle);
                            break;
                        case ShapeType.Ellipse:
                            g.FillEllipse(brush, this.ClientRectangle);
                            break;
                    }
                }
            }
        }

    }
}
