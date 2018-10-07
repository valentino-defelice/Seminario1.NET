using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using BussinesModel;


namespace Seminario1
{
    public partial class OrdenDetail : System.Web.UI.Page
    {
        DatabaseQuerys _dq = new DatabaseQuerys();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public List<LineaProducto> GetOrden([QueryString("OrdenId")] int? ordenId)
        {
            var result = _dq.getProductosByOrden(ordenId);
            return result;
        }

    }
}