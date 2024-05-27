using MaterialSkin.Controls;
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
    public partial class RoomSizeSelectionForm : MaterialForm
    {
        Utility util = new Utility();

        public RoomSizeSelectionForm()
        {
            InitializeComponent();

            // 최소화, 최대화, 닫기 버튼 숨기기
            this.ControlBox = false;

            // 정사각형 방 크기
            smallRoomRadioButton.Text = "Small (630x630, 3평)";
            mediumRoomRadioButton.Text = "Medium (726x726, 4평)";
            largeRoomRadioButton.Text = "Large (812x812, 5평)";

            // 직사각형 방 크기 (가로가 더 긴 형태)
            smallRectRoomRadioButton.Text = "Small Rectangular (800x495, 3평)";
            mediumRectRoomRadioButton.Text = "Medium Rectangular (916x576, 4평)";
            largeRectRoomRadioButton.Text = "Large Rectangular (1000x660, 5평)";
        }

        // (BTN) OK
        private void btnOK1_Click(object sender, EventArgs e)
        {
            if (!smallRoomRadioButton.Checked && !mediumRoomRadioButton.Checked && !largeRoomRadioButton.Checked &&
            !smallRectRoomRadioButton.Checked && !mediumRectRoomRadioButton.Checked && !largeRectRoomRadioButton.Checked)
            {
                MessageBox.Show("방 크기를 선택해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (smallRoomRadioButton.Checked)
            {
                this.Size = new System.Drawing.Size(630, 630);
            }
            else if (mediumRoomRadioButton.Checked)
            {
                this.Size = new System.Drawing.Size(726, 726);
            }
            else if (largeRoomRadioButton.Checked)
            {
                this.Size = new System.Drawing.Size(812, 812);
            }
            else if (smallRectRoomRadioButton.Checked)
            {
                this.Size = new System.Drawing.Size(800, 495);
            }
            else if (mediumRectRoomRadioButton.Checked)
            {
                this.Size = new System.Drawing.Size(916, 576);
            }
            else if (largeRectRoomRadioButton.Checked)
            {
                this.Size = new System.Drawing.Size(1000, 660);
            }
        }

        // (BTN) Cancel
        private void btnCancel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
