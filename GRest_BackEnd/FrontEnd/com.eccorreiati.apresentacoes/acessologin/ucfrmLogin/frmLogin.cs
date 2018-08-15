using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontEnd.com.eccorreiati.controladores.ctrlLogin;

namespace FrontEnd.com.eccorreiati.apresentacoes.acessologin.ucfrmLogin
{
    public partial class frmLogin : UserControl
    {


        private static frmLogin Instancia;

        public static frmLogin GetInstancia
        {
            get
            {
                if (Instancia==null)
                {
                    Instancia = new frmLogin();
                }
                return Instancia;
            }
        }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnLogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(123)))), ((int)(((byte)(31)))));
            this.btnLogar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(123)))), ((int)(((byte)(31)))));
        }

        private void btnLogar_MouseLeave(object sender, EventArgs e)
        {
            this.btnLogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(184)))), ((int)(((byte)(45)))));
            this.btnLogar.FlatAppearance.BorderColor = Color.FromArgb(((byte)(191)), ((int)(((byte)(184)))), ((int)(((byte)(45)))));
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            ManipularObjectosFormLogin.FecharSistemaLogin(this.btnFechar);
        }

       
    }
}
