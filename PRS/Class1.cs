﻿using PRS.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Presentation

{
    public class Class1
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PRS.Forms.LoginUI());
            //Application.Run(new PRS.Forms.barraCargaUI());


        }
    }
}
