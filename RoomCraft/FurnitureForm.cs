using System;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace RoomCraft
{
    public partial class FurnitureForm : MaterialForm
    {
        public event Action<string> FurnitureSelected;

        public FurnitureForm()
        {
            InitializeComponent();

            // 최소화, 최대화, 닫기 버튼 숨기기
            this.ControlBox = false;
        }

        private void btnAddChair_Click(object sender, EventArgs e)
        {
            FurnitureSelected?.Invoke("Chair");
            this.Close();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            FurnitureSelected?.Invoke("Table");
            this.Close();
        }
    }
}
