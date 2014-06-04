using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Project_TouchCube;

namespace Project_TouchCube
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
