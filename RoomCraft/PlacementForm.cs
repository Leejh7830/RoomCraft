using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            furniture.MouseDown += Furniture_MouseDown;
            furniture.MouseMove += Furniture_MouseMove;
            furniture.MouseUp += Furniture_MouseUp;

            this.Controls.Add(furniture);
        }

        // 마우스 버튼을 눌렀을 때
        private void Furniture_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
            }
        }

        // 마우스 이동할 때
        private void Furniture_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox furniture = sender as PictureBox;
                furniture.Left = e.X + furniture.Left - mouseDownLocation.X;
                furniture.Top = e.Y + furniture.Top - mouseDownLocation.Y;
            }
        }

        // 마우스 버튼을 뗐을 때
        private void Furniture_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
    }
}
