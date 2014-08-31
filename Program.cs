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
            var args = Environment.GetCommandLineArgs().Skip(1).ToList(); // skip first item which is this EXE

            if (args.Count() != 1)
            {
                MessageBox.Show("Invalid command sent to LaunchWorkspace. Expecting single file");
                return;
            }

            var workspaceFile = args.Single();

            foreach (var item in File.ReadAllLines(workspaceFile))
            {
                try
                {
                    Process.Start(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Could not launch '{0}'\n\n{1}", item, ex.Message));
                }
            }
        }
    }
}
