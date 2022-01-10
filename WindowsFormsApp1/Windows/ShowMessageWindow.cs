using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class ShowMessageWindow
    {
        public static dynamic Message(string Msg_text, string Msg_type)
        {
            var dialogResult = MessageBox.Show(
                   Msg_text,
                   Msg_type,
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly);
            return dialogResult;
        }
    }
}
