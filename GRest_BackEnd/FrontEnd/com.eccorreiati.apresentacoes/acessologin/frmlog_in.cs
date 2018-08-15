using FrontEnd.com.eccorreiati.controladores.ctrlLogin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrontEnd.com.eccorreiati.apresentacoes.acessologin
{
    public partial class frmlog_in : Form
    {

        private bool arrastar;
        private Point tela;
        private Point cursorPonto;

        public frmlog_in()
        {
            InitializeComponent();
            //this.txtNomeUsuario.Focus();
            //Componetes do Usuario
            if (!this.pnlFundoForms.Contains(ucfrmLogin.frmLogin.GetInstancia))
            {
                this.pnlFundoForms.Controls.Add(ucfrmLogin.frmLogin.GetInstancia);
                ucfrmLogin.frmLogin.GetInstancia.BringToFront();
            }
            else
            {
                ucfrmLogin.frmLogin.GetInstancia.BringToFront();
            }
        }

        private void pnlBarTop_MouseUp(object sender, MouseEventArgs e)
        {
            arrastar = false;
            cursorPonto = Cursor.Position;
            tela = this.Location;
        }

        private void pnlBarTop_MouseDown(object sender, MouseEventArgs e)
        {
            arrastar = true;
        }

        private void pnlBarTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastar == true)
            {
                Point local = Point.Subtract(Cursor.Position, new Size(cursorPonto));
                this.Location = Point.Add(tela, new Size(local));
            }
        }
    }
}
