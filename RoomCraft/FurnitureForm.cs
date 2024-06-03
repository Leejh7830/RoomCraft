using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace RoomCraft
{
    public partial class FurnitureForm : MaterialForm
    {
        public event Action<string> FurnitureSelected;
        public event Action<Color> ColorChanged;

        public FurnitureForm()
        {
            InitializeComponent();

            // 최소화, 최대화, 닫기 버튼 숨기기
            this.ControlBox = false;
            this.TopMost = true;
        }
         
        private void btnAddChair_Click(object sender, EventArgs e)
        {
            OpenFurnitureDialog(@"..\..\Resources\Images\Chair");
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            OpenFurnitureDialog(@"..\..\Resources\Images\Table");
        }

        private void OpenFurnitureDialog(string relativePath)
        {
            string initialDirectory = Path.GetFullPath(relativePath);

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = initialDirectory;
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;
                    FurnitureSelected?.Invoke(selectedImagePath);
                }
            }
        }
    }
}
