using ProgramLauncher.Launchers;
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
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        public void GamesButton_Click(object sender, EventArgs e)
        {
            GamesLauncher launcher = new GamesLauncher();
            launcher.Show();
        }

        private void ProgButton_Click(object sender, EventArgs e)
        {
            UtilityLauncher launcher = new UtilityLauncher();
            launcher.Show();
        }
    }
}
