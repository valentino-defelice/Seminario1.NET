using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using BussinesModel;

namespace AppEscritorio
{
    public partial class Login : Form
    {
        DatabaseQuerys _dq = new DatabaseQuerys();

        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IngresarBtn_Click(object sender, EventArgs e)
        {
            var result = _dq.comprobarUsuario(EmailTxtBox.Text, PasswordTxtBox.Text);
            if (!result)
                resultado.Text = "Usuario o contraseña incorrecto.";
            else
            {
                Usuario u = new Usuario();
                u = _dq.getUsuarioByEmail(EmailTxtBox.Text);

                this.Hide();
                Home objHome = new Home(u);
                objHome.Show();
            }
        }
    }
}
