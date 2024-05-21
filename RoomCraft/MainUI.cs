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
using System.Threading;

namespace RoomCraft
{
    public partial class MainUI : MaterialForm
    {
        Utility util = new Utility();
        private readonly MaterialSkinManager materialSkinManager = null;
         
        public MainUI()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey700, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        // (BTN) Start
        private void BtnStart1_Click_1(object sender, EventArgs e)
        {
            StartUI startUI = new StartUI();

            this.Hide();

            // 같은 위치에 폼 생성
            //Point originalLocation = this.Location;
            //startUI.StartPosition = FormStartPosition.Manual;
            //startUI.Location = originalLocation;
            util.SetFormStartPosition(this, startUI);

            // 새로 열린 폼이 닫힐 때 이벤트를 처리하는 핸들러를 등록
            startUI.FormClosed += StartUI_FormClosed; 
            startUI.Show();

        }

        private void StartUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show(); // = MainUI 폼
        }





        #region Exit Process
        // (BTN) Exit
        private void BtnExit1_Click(object sender, EventArgs e)
        {
            ExitConfirmation();
        }

        private void MainUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 사용자가 X 버튼을 클릭했을 때만 확인 대화상자 표시
            if (e.CloseReason == CloseReason.UserClosing)
            {
                ExitConfirmation(e);
            }
        }

        private void ExitConfirmation(FormClosingEventArgs e = null)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Exit Confirmation", MessageBoxButtons.OKCancel);

            // 사용자가 확인을 선택하지 않은 경우 종료를 취소
            if (result != DialogResult.OK) // 확인이 아니면
            {
                if (e != null)
                {
                    e.Cancel = true;
                }
            }
            else // 확인이면
            {
                Application.Exit();
            }
        }

        #endregion Exit Process

    }
}
