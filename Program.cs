using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaunchWorkspace
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var args = Environment.GetCommandLineArgs().Skip(1).ToList();

            if (!args.Any())
                return;

            args.ForEach((item) => Process.Start(item));
        }
    }
}
