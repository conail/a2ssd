﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a2ssdqub
{
    static class Program
    {
        public static MainMenu mainM;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetupDataDirectoryPath();
            mainM = new MainMenu();
            Application.Run(mainM);
        }

/*
 * Overwrite the DataDirectory with the
 * solution-level database location
 * which is the folder above the bin folder
 * (and the solution runs from the bin folder)
 */
        private static void SetupDataDirectoryPath()
        {
            string debugPath = System.IO.Path.GetDirectoryName(Environment.CurrentDirectory);
            string dataDirectoryPath = System.IO.Path.GetDirectoryName(debugPath);
            AppDomain.CurrentDomain.SetData("DataDirectory", dataDirectoryPath);
        }
    }
}
