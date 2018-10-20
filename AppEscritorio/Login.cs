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
        ApplicationDbContext _db = new ApplicationDbContext();

        public Login()
        {
            InitializeComponent();
            PasswordTxtBox.PasswordChar = '*';
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void IngresarBtn_Click(object sender, EventArgs e)
        {
            var result = _dq.comprobarUsuario(EmailTxtBox.Text, PasswordTxtBox.Text);
            if (!result)
            { 
                resultado.Text = "Usuario o contraseña incorrecto.";
                resultado.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                Usuario User = new Usuario();
                    User = _dq.getUsuarioByEmail(EmailTxtBox.Text);
                if (!User.Adimn)
                {
                    Home h = new Home(User);

                    this.Hide();
                    h.Show();
                }
                else
                {
                    AdminHome ah = new AdminHome();

                    this.Hide();
                    ah.Show();
                }
            }
        }

        private void CrearBtn_Click(object sender, EventArgs e)
        {
            var result = _dq.comprobarUsuario(EmailTxtBox.Text, PasswordTxtBox.Text);

            if (!(String.IsNullOrEmpty(EmailTxtBox.Text) || String.IsNullOrEmpty(PasswordTxtBox.Text)))
            {
                if (!result)
                {
                    if (_dq.createUser(EmailTxtBox.Text, PasswordTxtBox.Text))
                    {
                        resultado.Text = "Usuario creado con éxito.";
                        resultado.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        resultado.Text = "Hubo un inconveniente creando el usuario";
                        resultado.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    resultado.Text = "Ya existe un usuario con ese E-mail";
                    resultado.ForeColor = System.Drawing.Color.YellowGreen;
                }
            }
            else
            {
                resultado.Text = "Debe ingresar un E-mail y Contraseña";
                resultado.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
