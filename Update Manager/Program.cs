﻿using System;
using System.Windows.Forms;

namespace Aldrigo.UltraUpdater.Manager {
    static class Program {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new FMain() );
        }
    }
}