using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramLauncher
{
    public partial class GamesLauncher : Form
    {
        ProgramStarter starter = new ProgramStarter();
        public GamesLauncher()
        {
            InitializeComponent();
        }

        private void Minecraft_Launch(object sender, EventArgs e)
        {
            starter.startProgram("C:/Program Files (x86)/Minecraft/MinecraftLauncher.exe");
        }

        private void Steam_Launch(object sender, EventArgs e)
        {
            starter.startProgram("C:/Program Files (x86)/Steam/Steam.exe");
        }

        private void TTR_Launch(object sender, EventArgs e)
        {
            starter.startProgram("C:/Program Files (x86)/Toontown Rewritten/Launcher.exe");
        }

        private void P64_Launch(object sender, EventArgs e)
        {
            starter.startProgram("C:/Program Files (x86)/Project64 1.6/Project64.exe");
        }
    }
}
