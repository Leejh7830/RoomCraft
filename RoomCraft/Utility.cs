using System;
using System.Drawing;
using System.Windows.Forms;

namespace RoomCraft
{
    public static class Util
    { 
        // 새로 열리는 폼이 기존 폼의 위치에 열리도록
        public static void SetFormStartPosition(Form originForm, Form newForm)
        {
            Point originalLocation = originForm.Location;
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = originalLocation;
        }

        // 새로 열리는 폼이 기존 폼의 오른쪽에 붙어서 열리도록
        public static void SetFormRightPosition(Form originForm, Form newForm)
        {
            Point originalLocation = originForm.Location;
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = new Point(originalLocation.X + originForm.Width, originalLocation.Y);
        }

        // 폼의 모든 컨트롤을 숨김
        public static void HideAllControls(Form form)
        {
            foreach (Control control in form.Controls)
            {
                control.Visible = false;

            }
        }

        // 부모 폼이 이동할 때 자식 폼도 함께 이동하도록
        public static void SyncChildFormPosition(Form parent, Form child)
        {
            parent.LocationChanged += (s, e) =>
            {
                if (child != null && !child.IsDisposed)
                {
                    child.Location = new Point(parent.Location.X + parent.Width, parent.Location.Y);
                }
            };
        }
    }
}
