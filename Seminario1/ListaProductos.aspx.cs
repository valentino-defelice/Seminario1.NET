using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using BussinesModel;
using System.Web.ModelBinding;

namespace Seminario1
{
    public partial class ListaProductos : System.Web.UI.Page
    {
        DatabaseQuerys _dq = new DatabaseQuerys();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Producto> GetProducts([QueryString("id")] int? categoryId)
        {
            var result = _dq.GetProducts(categoryId);
            return result;
        }
    }
}