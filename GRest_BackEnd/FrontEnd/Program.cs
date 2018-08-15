using FrontEnd.com.eccorreiati.apresentacoes.acessologin;
using System;
using System.Windows.Forms;

namespace FrontEnd
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmlog_in());

        }
    }
}
