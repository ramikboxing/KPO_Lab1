using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Kpo4381_nmv;

namespace KPO4381_nmv.Main
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
     

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
