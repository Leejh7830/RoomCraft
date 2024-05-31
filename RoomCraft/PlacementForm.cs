using System;
using System.Drawing;
using System.Windows.Forms;

namespace RoomCraft
{
    public partial class PlacementForm : Form
    {
        private Point mouseDownLocation;
        private FurnitureForm furnitureForm;

        public PlacementForm()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void PlacementForm_Load(object sender, EventArgs e)
        {

            furnitureForm = new FurnitureForm();
            furnitureForm.FurnitureSelected += OnFurnitureSelected;
            Util.SetFormStartPosition(this, furnitureForm);
            furnitureForm.Show(this);

            // 부모-자식 폼 위치 동기화
            Util.SyncChildFormPosition(this, furnitureForm);
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

            this.Controls.Add(furniture);
        }

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
            }
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Control control = sender as Control;
                control.Left = e.X + control.Left - mouseDownLocation.X;
                control.Top = e.Y + control.Top - mouseDownLocation.Y;
            }
        }

        private void Control_MouseUp(object sender, MouseEventArgs e)
        {
            // 필요시 추가 작업을 여기에 작성
        }
    }
}
