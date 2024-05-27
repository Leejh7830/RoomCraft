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
        private MaterialTextBox widthTextBox;
        private MaterialTextBox heightTextBox;
        private MaterialLabel widthLabel;
        private MaterialLabel heightLabel;
        private MaterialRadioButton lastCheckedRadioButton;

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

            // 텍스트 박스 및 레이블 설정
            widthLabel = new MaterialLabel() { Text = "Width (px):", AutoSize = true };
            widthTextBox = new MaterialTextBox() { Width = 100 };
            heightLabel = new MaterialLabel() { Text = "Height (px):", AutoSize = true };
            heightTextBox = new MaterialTextBox() { Width = 100 };

            // 컨트롤 배치
            var tableLayout = new TableLayoutPanel() { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 6 };
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F)); // 빈 행 추가
            tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            tableLayout.Controls.Add(smallRoomRadioButton, 0, 0);
            tableLayout.Controls.Add(mediumRoomRadioButton, 0, 1);
            tableLayout.Controls.Add(largeRoomRadioButton, 0, 2);
            tableLayout.Controls.Add(smallRectRoomRadioButton, 1, 0);
            tableLayout.Controls.Add(mediumRectRoomRadioButton, 1, 1);
            tableLayout.Controls.Add(largeRectRoomRadioButton, 1, 2);

            var customSizePanel = new FlowLayoutPanel() { FlowDirection = FlowDirection.LeftToRight, AutoSize = true };
            customSizePanel.Controls.Add(widthLabel);
            customSizePanel.Controls.Add(widthTextBox);
            customSizePanel.Controls.Add(heightLabel);
            customSizePanel.Controls.Add(heightTextBox);
            tableLayout.Controls.Add(customSizePanel, 0, 4);
            tableLayout.SetColumnSpan(customSizePanel, 2);

            var buttonPanel = new FlowLayoutPanel() { FlowDirection = FlowDirection.LeftToRight, AutoSize = true };
            tableLayout.Controls.Add(buttonPanel, 0, 5);
            tableLayout.SetColumnSpan(buttonPanel, 2);

            this.Controls.Add(tableLayout);
        }

        // (BTN) OK
        private void btnOK1_Click(object sender, EventArgs e)
        {
            bool isRadioButtonChecked = smallRoomRadioButton.Checked || mediumRoomRadioButton.Checked || largeRoomRadioButton.Checked ||
                                        smallRectRoomRadioButton.Checked || mediumRectRoomRadioButton.Checked || largeRectRoomRadioButton.Checked;

            bool isTextBoxFilled = !string.IsNullOrWhiteSpace(widthTextBox.Text) && !string.IsNullOrWhiteSpace(heightTextBox.Text);

            // 라디오 버튼과 텍스트 박스를 둘 다 선택한 경우
            if (isRadioButtonChecked && isTextBoxFilled)
            {
                MessageBox.Show("방 크기를 선택하거나 직접 입력하세요. 둘 다 선택할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 아무 것도 선택하지 않은 경우
            if (!isRadioButtonChecked && !isTextBoxFilled)
            {
                MessageBox.Show("방 크기를 선택하거나 직접 입력하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 라디오 버튼이 선택된 경우
            if (isRadioButtonChecked)
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
            else
            {
                // 텍스트 박스에 입력된 값이 유효한 경우
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
        }

        // (BTN) Cancel
        private void btnCancel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
                    }
                }
            }
        }
    }
}
