using System;
using System.Windows.Forms;

namespace a2ssdqub
{
    static class Program
    {
        public static UI.MainMenu mainM;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetupDataDirectoryPath();
            mainM = new UI.MainMenu();
            Application.Run(mainM);
        }

        /// <summary>
        /// Overwrite the DataDirectory with the solution-level database location,
        /// which is the folder above the bin folder when the solution runs from. 
        /// </summary>
        private static void SetupDataDirectoryPath()
        {
            string path = Environment.CurrentDirectory;
            for (int i = 0; i < 2; i++) path = System.IO.Path.GetDirectoryName(path);

            AppDomain.CurrentDomain.SetData("DataDirectory", path);
        }
    }
}
