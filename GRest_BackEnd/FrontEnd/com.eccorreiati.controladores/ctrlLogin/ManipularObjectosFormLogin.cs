using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrontEnd.com.eccorreiati.controladores.ctrlLogin
{
    public class ManipularObjectosFormLogin
    {
        //Capiturar o botão de fechar e fechar o sistema
        public static void FecharSistemaLogin(object nome_object)
        {
            Button nome_botao = (Button)nome_object;
            if (nome_botao.Name=="btnFechar")
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        public static void MoverFormulario(object form)
        {
            Panel bgFormLogin = (Panel)form;
            if (bgFormLogin.GetType()==typeof(Panel))
            {
                //TODO
            }
        }

        public static void AlterarEtiquetaInformacaoFormulario(object o)
        {
            Form form = (Form)o;
            if (true)
            {

            }
        }
    }
}
