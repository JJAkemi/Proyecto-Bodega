using System;
using System.Threading;
using System.Reflection;
using System.Windows.Forms;

namespace CapaPresentacion
{


    static class Program
    {
        private static bool FirstInstance
        {
            get
            {
                bool created;
                string name = Assembly.GetEntryAssembly().FullName;
                // created will be True if the current thread creates and owns the mutex.
                // Otherwise created will be False if a previous instance already exists.
                Mutex mutex = new Mutex(true, name, out created);
                return created;
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (FirstInstance)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMenu());
            }
            else
            {
                MessageBox.Show("La aplicación ya se está ejecutando.","BTC v1.0");
                Application.Exit();
            }
        }
    }
}
