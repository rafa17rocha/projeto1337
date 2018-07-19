using System;
using System.Windows.Forms;

namespace EY.Reinf.Interface
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ReinfForm());
            //Application.Run(new PesquisarForm());
        }
    }
}
