using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProgramLauncher
{
    class ProgramStarter
    {
        public void startProgram(string location)
        {
            Process.Start(location);
        }

        public void startProgram(string location, string args)
        {
            Process.Start(location,args);
        }
    }
}
