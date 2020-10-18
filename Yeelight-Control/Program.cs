using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yeelight_Control.Helpers;

namespace Yeelight_Control
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!File.Exists(GlobalVariables.PATH_DEVICES))
            {
                File.WriteAllText(GlobalVariables.PATH_DEVICES, "[]");
            }
            if (!File.Exists(GlobalVariables.PATH_PRESETS))
            {
                File.WriteAllText(GlobalVariables.PATH_PRESETS, "[]");
            }
            Application.Run(new Devices());
        }
    }
}
