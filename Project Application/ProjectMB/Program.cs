using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
       
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SplashForm.ShowSplashScreen();
            MainForm mainForm = new MainForm(); //this takes ages
            SplashForm.CloseForm();           
            Application.Run(mainForm);
            //Application.Run(new MainForm());
        }
    }
}
