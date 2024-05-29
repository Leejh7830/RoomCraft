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
        // Utility util = new Utility();
        private MaterialRadioButton lastCheckedRadioButton;
        private FurnitureForm furnitureForm;

        public RoomSizeSelectionForm()
        {
            InitializeComponent();

            // 최소화, 최대화, 닫기 버튼 숨기기
            this.ControlBox = false;

            // 폼의 최소 크기 설정
            this.MinimumSize = new System.Drawing.Size(400, 300);
        }

        // RadioButton 클릭 이벤트 핸들러
        private void RadioButton_Click(object sender, EventArgs e)
        {
            var clickedRadioButton = sender as MaterialRadioButton;
            if (clickedRadioButton != null)
            {
                if (clickedRadioButton.Checked)
                {
                    if (lastCheckedRadioButton == clickedRadioButton)
                    {
                        clickedRadioButton.Checked = false;
                        lastCheckedRadioButton = null;
                    }
                    else
                    {
                        lastCheckedRadioButton = clickedRadioButton;
                        ApplyRoomSize();
                    }
                }
            }
        }

        // 방 크기 적용
        private void ApplyRoomSize()
        {
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

        // (BTN) Apply
        private void btnApply_Click(object sender, EventArgs e)
        {
            int width, height;
            if (int.TryParse(widthTextBox.Text, out width) && int.TryParse(heightTextBox.Text, out height))
            {
                // 최소값과 최대값 제한 (예: 최소 100px, 최대 2000px)
                if (width >= 100 && width <= 2000 && height >= 100 && height <= 2000)
                {
                    this.Size = new System.Drawing.Size(width, height);
                }
                else
                {
                    MessageBox.Show("가로와 세로는 100픽셀에서 2000픽셀 사이여야 합니다.", "유효하지 않은 크기", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("가로와 세로에 유효한 숫자 값을 입력하세요.", "유효하지 않은 입력", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // (BTN) OK
        private void btnOK1_Click(object sender, EventArgs e)
        {
            bool isRadioButtonChecked = smallRoomRadioButton.Checked || mediumRoomRadioButton.Checked || largeRoomRadioButton.Checked ||
                                        smallRectRoomRadioButton.Checked || mediumRectRoomRadioButton.Checked || largeRectRoomRadioButton.Checked;

            bool isWidthTextBoxFilled = !string.IsNullOrWhiteSpace(widthTextBox.Text);
            bool isHeightTextBoxFilled = !string.IsNullOrWhiteSpace(heightTextBox.Text);

            // 아무 것도 선택하지 않은 경우
            if (!isRadioButtonChecked && (!isWidthTextBoxFilled || !isHeightTextBoxFilled))
            {
                MessageBox.Show("방 크기를 선택하거나 직접 입력하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("현재 방 사이즈로 진행합니다.", "확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Util.HideAllControls(this);

                // 새로운 폼 생성 및 부모-자식 관계 설정
                furnitureForm = new FurnitureForm();
                furnitureForm.StartPosition = FormStartPosition.Manual;
                furnitureForm.Location = new Point(this.Location.X + this.Width, this.Location.Y);
                furnitureForm.Show(this);

                // 폼 이동 이벤트 핸들러 설정
                Util.SyncChildFormPosition(this, furnitureForm);
            }
        }

        // 부모 폼이 이동할 때 자식 폼도 함께 이동하도록 설정
        private void MainForm_LocationChanged(object sender, EventArgs e)
        {
            if (furnitureForm != null)
            {
                furnitureForm.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            }
        }

        // (BTN) Cancel
        private void btnCancel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // (BTN) Reset
        private void btnReset1_Click(object sender, EventArgs e)
        {
            // 모든 RadioButton의 체크를 해제
            smallRoomRadioButton.Checked = false;
            mediumRoomRadioButton.Checked = false;
            largeRoomRadioButton.Checked = false;
            smallRectRoomRadioButton.Checked = false;
            mediumRectRoomRadioButton.Checked = false;
            largeRectRoomRadioButton.Checked = false;

            // TextBox의 값을 비움
            widthTextBox.Text = "";
            heightTextBox.Text = "";

            // 마지막 체크된 RadioButton 초기화
            lastCheckedRadioButton = null;

            // 폼의 크기를 기본 크기로 설정
            this.Size = new System.Drawing.Size(650, 350);
        }

        private void btnFurniture_Click(object sender, EventArgs e)
        {
            FurnitureForm furnitureSelectionForm = new FurnitureForm();
            furnitureSelectionForm.FurnitureSelected += (furniture) =>
            {
                // 선택된 가구를 방에 추가하는 로직 구현
                AddFurnitureToRoom(furniture);
            };

            Util.SetFormStartPosition(this, furnitureSelectionForm);
            furnitureSelectionForm.ShowDialog();
        }

        private void AddFurnitureToRoom(string furniture)
        {
            // 가구를 방에 추가하는 로직
            MessageBox.Show($"{furniture} added to the room", "Furniture Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
