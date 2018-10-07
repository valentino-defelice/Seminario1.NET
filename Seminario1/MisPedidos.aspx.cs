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
    public partial class MisPedidos : System.Web.UI.Page
    {
        DatabaseQuerys _dq = new DatabaseQuerys();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Orden> GetOrdenes()
        {
            Usuario usuario = new Usuario();
            usuario = _dq.getUsuarioByEmail(Session["Usuario"].ToString());

            return _dq.getOrdenesConfirmadas(usuario.Id);
        }
    }
}