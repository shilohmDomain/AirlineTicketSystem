﻿using System;
using System.Windows.Forms;
using ClassLibrary;

namespace AdminPanel
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SaveLoad.CheckForFiles();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrontForm());
        }
    }
}
