using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using BussinesModel;

namespace Seminario1
{
    public partial class Login : System.Web.UI.Page
    {

        DatabaseQuerys _dq = new DatabaseQuerys();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonIngresar_Click1(object sender, EventArgs e)
        {
            var resutl = _dq.comprobarUsuario(TextBoxEmail.Text, TextBoxPass.Text);
            if (resutl)
            {
                HttpContext.Current.Session["Usuario"] = TextBoxEmail.Text;
                Response.Redirect("ShoppingCart.aspx");
            }
            else
                resultado.Text = "Usuario o contraseña incorrecta";
        }

        protected void ButtonCrear_Click1(object sender, EventArgs e)
        {
            var result = _dq.comprobarUsuario(TextBoxEmail.Text, TextBoxPass.Text);

            if (TextBoxEmail != null && TextBoxPass != null)
            {

                if (!result)
                {
                    var newUser = _dq.createUser(TextBoxEmail.Text, TextBoxPass.Text);
                    resultado.Text = "Usuario creado con éxito";
                    resultado.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    resultado.Text = "El usuario ya existe";
                    resultado.ForeColor = System.Drawing.Color.Yellow;
                }
            }
            else
            {
                resultado.Text = "Debe ingresar un Email y contraseña";
                resultado.ForeColor = System.Drawing.Color.Red;
            }
        }

    }
}