using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramLauncher.Launchers
{
    public partial class UtilityLauncher : Form
    {
        private ProgramStarter starter = new ProgramStarter();
        public UtilityLauncher()
        {
            InitializeComponent();
        }

        private void CSDev_Launch(object sender, EventArgs e)
        {
            starter.startProgram("C:/Program Files (x86)/Microsoft Visual Studio/2017/Community/Common7/IDE/devenv.exe");
            starter.startProgram("C:/Users/Daniel/AppData/Local/gitkraken/app-2.6.0/gitkraken.exe");
        }

        private void Dock_Launch(object sender, EventArgs e)
        {
            starter.startProgram("C:/Program Files/GamingMouse_Tecknet/GamingMouse_Tecknet.exe");
            starter.startProgram("C:/Program Files (x86)/Corsair/Corsair Utility Engine/CUE.exe");
            starter.startProgram("C:/Program Files (x86)/Seagate/Seagate Dashboard 2.0/Dashboard.exe");
        }
    }
}
