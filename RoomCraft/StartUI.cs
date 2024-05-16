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

        private void BtnBack1_Click(object sender, EventArgs e)
        {
            this.Close(); // StartUI폼 닫으면 MainUI폼 활성화
        }
    }
}
