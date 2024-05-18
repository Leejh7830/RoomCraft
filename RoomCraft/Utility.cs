using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomCraft
{
    class Utility
    {
        public void SetFormStartPosition(Form originForm, Form newForm)
        {
            Point originalLocation = originForm.Location;
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = originalLocation;


        }
    }
}
