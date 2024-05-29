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
    public partial class StartUI : MaterialForm
    {
        public StartUI()
        {
            InitializeComponent();
        }
        
        // (BTN) Bact To Main
        private void BtnBack1_Click(object sender, EventArgs e)
        {
            this.Close(); // StartUI폼 닫으면 MainUI폼 활성화
        }

        // (BTN) Create
        private void BtnCreate1_Click(object sender, EventArgs e)
        {
            // 새로운 방 크기 선택 폼 생성
            RoomSizeSelectionForm roomSizeSelectionForm = new RoomSizeSelectionForm();

            Util.SetFormStartPosition(this, roomSizeSelectionForm);

            // 방 크기 선택 폼을 모달로 띄움
            roomSizeSelectionForm.ShowDialog();
        }
    }
}
