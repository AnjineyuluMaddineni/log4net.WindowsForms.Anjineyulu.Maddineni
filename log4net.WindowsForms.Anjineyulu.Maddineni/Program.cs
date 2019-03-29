using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace log4net.WindowsForms.Anjineyulu.Maddineni
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Step 01 Install log4net package from nuget
            //Step 02 for log4net
            log4net.Config.XmlConfigurator.Configure();
        }
    }
}
