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
    public partial class SiteMaster : MasterPage
    {
        DatabaseQuerys _dq = new DatabaseQuerys();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!(Session["Usuario"] == null))
            {
                var user = _dq.getUsuarioByEmail(Session["Usuario"].ToString());
                if(user.Adimn == true)
                { 
                    vistaCerrarSesion.Visible = true;
                    adminLink.Visible = true;
                    dashboard.Visible = true;
                    vistaLogin.Visible = false;
                }
                else if (!(Session["Usuario"] == null))
                {
                    vistaCerrarSesion.Visible = true;
                    vistaLogin.Visible = false;
                    dashboard.Visible = true;
                }
            }   
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            using (ShoppingCartActions userShoppingCart = new ShoppingCartActions())
            {
                string cartStr = string.Format("Su Carrito ({0})", userShoppingCart.GetCount());
                cartCount.InnerText = cartStr;
            }
        }

        public IQueryable<Categoria> GetCategorias()
        {
            DatabaseQuerys queryable = new DatabaseQuerys();
            IQueryable<Categoria> query = queryable.GetCategorias();

            return query;
        }
    }
}