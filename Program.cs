using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

// include menu.cs
using SedapMakanApp.Class;

namespace SedapMakanApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //default main for program.cs
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //open masterlogin form
            MasterLogin masterLogin = new MasterLogin();
            Application.Run(new ChefForm());



        }
    }
}
