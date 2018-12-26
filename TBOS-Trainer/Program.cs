using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace TBOS_Trainer
{
    public static class Program
    {
        public static bool ApplicationRunning = false;
        public static Mem Memory = new Mem();

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
