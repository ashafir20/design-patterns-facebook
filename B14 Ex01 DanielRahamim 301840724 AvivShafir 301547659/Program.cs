using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace B14_Ex01_Daniel_301840724_Aviv_301547659
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
