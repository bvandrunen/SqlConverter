using System;
using System.Windows.Forms;
using log4net.Config;

// Configure LOG4NET Using configuration file.
[assembly: XmlConfigurator(Watch = true)]

namespace Converter.WinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BasicConfigurator.Configure();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}