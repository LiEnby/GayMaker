using System;
using System.Windows.Forms;

namespace GayMaker
{
    static class Program
    {
        public static GayMaker GM;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GM = new GayMaker();
            Application.Run(GM);
        }
    }
}
