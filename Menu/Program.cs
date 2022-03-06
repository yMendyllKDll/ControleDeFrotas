using Ferramentas;
using Menu.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
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
            frmLogin f = new frmLogin();
            Application.Run(f);
            //f.Dispose();
            //VERIFICA SE O USUÁRIO FOI AUTENTICADO
            if (SessaoUsuario.Session.Instance.UsuID > 0)
            {
                Application.Run(new Home());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
