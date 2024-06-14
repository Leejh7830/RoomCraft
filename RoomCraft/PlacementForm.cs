using System;
using System.Drawing;
using System.Windows.Forms;

namespace RoomCraft
{
    public partial class PlacementForm : Form
    {
        private Point mouseDownLocation;
        private FurnitureForm furnitureForm;
        private Control selectedControl;
        private bool isResizing = false;
        private string resizeDirection;
        private const int resizeHandleSize = 10;

        public PlacementForm()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void PlacementForm_Load(object sender, EventArgs e)
        {

            furnitureForm = new FurnitureForm();
            Util.SetFormRightPosition(this, furnitureForm);
            furnitureForm.FurnitureSelected += OnFurnitureSelected;
            furnitureForm.Show(this);

            // 부모-자식 폼 위치 동기화
            Util.SyncChildFormPosition(this, furnitureForm);

            // ContextMenuStrip 초기화 및 설정
            // InitializeContextMenu();
        }
         
        private void InitializeContextMenu()
        {
            contextMenu = new ContextMenuStrip();
            var changeColorMenuItem = new ToolStripMenuItem("Change Color");

            changeColorMenuItem.Click += ChangeColorMenuItem_Click;

            contextMenu.Items.Add(changeColorMenuItem);
        }
         
        private void ChangeColorMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedControl != null)
            {
                using (ColorDialog colorDialog = new ColorDialog())
                {
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        OnColorChanged(colorDialog.Color);
                    }
                }
            } 
        }
         

        /*
        private void AddShapeButtons()
        {
            Button btnAddRectangle = new Button
            {
                Text = "Add Rectangle",
                Location = new Point(10, 10),
                Size = new Size(100, 30)
            };
            btnAddRectangle.Click += (s, e) => AddShape(ShapeType.Rectangle);

            Button btnAddEllipse = new Button
            {
                Text = "Add Ellipse",
                Location = new Point(120, 10),
                Size = new Size(100, 30)
            };
            btnAddEllipse.Click += (s, e) => AddShape(ShapeType.Ellipse);

            this.Controls.Add(btnAddRectangle);
            this.Controls.Add(btnAddEllipse);
        }

        private void AddShape(ShapeType shapeType)
        {
            ShapeControl shape = new ShapeControl
            {
                Shape = shapeType,
                Location = new Point(50, 50) // 초기 위치 설정
            };

            shape.MouseDown += Control_MouseDown;
            shape.MouseMove += Control_MouseMove;
            shape.MouseUp += Control_MouseUp;

            this.Controls.Add(shape);
        }
        */

        private void OnFurnitureSelected(string imagePath)
        {
            PictureBox furniture = new PictureBox
            {
                Image = Image.FromFile(imagePath), // 선택된 이미지 설정
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(50, 50), // 적절한 크기 설정
                Location = new Point(50, 50), // 초기 위치 설정
                Cursor = Cursors.Hand // 드래그를 위한 커서 설정
            };

            furniture.MouseDown += Control_MouseDown;
            furniture.MouseMove += Control_MouseMove;
            furniture.MouseUp += Control_MouseUp;
            furniture.MouseClick += Control_MouseClick;
            furniture.Paint += Control_Paint;

            this.Controls.Add(furniture);
        }

        private void OnColorChanged(Color color)
        {
            if (selectedControl != null && selectedControl is PictureBox pictureBox)
            {
                Bitmap bmp = new Bitmap(pictureBox.Image);
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color pixelColor = bmp.GetPixel(x, y);
                        if (pixelColor.A > 0) // Skip transparent pixels
                        {
                            bmp.SetPixel(x, y, color);
                        }
                    }
                }
                pictureBox.Image = bmp;
            }
        }

        private void OnSizeChanged(int width, int height)
        {
            if (selectedControl != null)
            {
                selectedControl.Size = new Size(width, height);
                selectedControl.Invalidate();
            }
        }
         
        private void Control_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                selectedControl = sender as Control;
                contextMenu.Show(Cursor.Position);
            }
        }
         
        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                selectedControl = sender as Control;
                if (IsInResizeZone(selectedControl, e.Location))
                {
                    isResizing = true;
                }
                else
                {
                    mouseDownLocation = e.Location;
                }
            }
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            Control control = sender as Control;
            if (isResizing)
            {
                control.Width = e.X;
                control.Height = e.Y;
                control.Invalidate();
            }
            else if (e.Button == MouseButtons.Left)
            {
                control.Left = e.X + control.Left - mouseDownLocation.X;
                control.Top = e.Y + control.Top - mouseDownLocation.Y;
            }
            else
            {
                if (IsInResizeZone(control, e.Location))
                {
                    control.Cursor = Cursors.SizeNWSE;
                }
                else
                {
                    control.Cursor = Cursors.Hand;
                }
            }
        }

        private void Control_MouseUp(object sender, MouseEventArgs e)
        {
            isResizing = false;
        }

        private void Control_Paint(object sender, PaintEventArgs e)
        {
            Control control = sender as Control;
            using (Brush brush = new SolidBrush(Color.Black))
            {
                e.Graphics.FillRectangle(brush, new Rectangle(control.Width - resizeHandleSize, control.Height - resizeHandleSize, resizeHandleSize, resizeHandleSize));
            }
        }

        private bool IsInResizeZone(Control control, Point point)
        {
            return point.X >= control.Width - resizeHandleSize && point.Y >= control.Height - resizeHandleSize;
        }
    }
}
