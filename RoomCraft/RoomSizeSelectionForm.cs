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
        }

        // (BTN) OK
        private void btnConfirm1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // (BTN) Cancel
        private void btnCancel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
