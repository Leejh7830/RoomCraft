using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace RoomCraft
{
    public partial class MainUI : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager = null;

        public MainUI()
        {
            

            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;

            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            //BtnStart1.Font = new Font(BtnStart1.Font.FontFamily, 55);

        }

        private void BtnExit1_Click(object sender, EventArgs e)
        {

        }
    }
}
