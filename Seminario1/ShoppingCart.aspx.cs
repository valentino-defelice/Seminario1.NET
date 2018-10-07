using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Web.ModelBinding;
using BussinesModel;
using Models;

namespace Seminario1
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        DatabaseQuerys _dq = new DatabaseQuerys();

        protected void Page_Load(object sender, EventArgs e)
        {
            using (ShoppingCartActions userShoppingCart = new ShoppingCartActions())
            {
                decimal cartTotal = 0;
                cartTotal = userShoppingCart.GetTotal();
                if (cartTotal > 0)
                {
                    lblTotal.Text = String.Format("{0:c}", cartTotal);
                }
                else
                {
                    LabelTotalText.Text = "";
                    lblTotal.Text = "";
                    ShoppingCartTitle.InnerText = "El carrito está vacío.";
                    UpdateBtn.Visible = false;
                }
            }

        }

        public List<LineaProducto> GetLineasDelPedido()
        {
            ShoppingCartActions actions = new ShoppingCartActions();
            return actions.GetListaProductos();
        }

        public List<LineaProducto> UpdateCartItems()
        {
            using (ShoppingCartActions userShoppingCart = new ShoppingCartActions())
            {
                String PedidoId = userShoppingCart.GetCartId();

                ShoppingCartActions.ShoppingCartUpdates[] cartUpdates = new ShoppingCartActions.ShoppingCartUpdates[CartList.Rows.Count];
                for (int i = 0; i < CartList.Rows.Count; i++)
                {
                    IOrderedDictionary rowValues = new OrderedDictionary();
                    rowValues = GetValues(CartList.Rows[i]);
                    cartUpdates[i].ProductoId = Convert.ToInt32(rowValues["ProductoId"]);

                    CheckBox cbRemove = new CheckBox();
                    cbRemove = (CheckBox)CartList.Rows[i].FindControl("Remove");
                    cartUpdates[i].EliminarItem = cbRemove.Checked;

                    TextBox quantityTextBox = new TextBox();
                    quantityTextBox = (TextBox)CartList.Rows[i].FindControl("PurchaseQuantity");
                    cartUpdates[i].CantidadComprada = Convert.ToInt16(quantityTextBox.Text.ToString());
                }
                userShoppingCart.UpdateShoppingCartDatabase(PedidoId, cartUpdates);
                CartList.DataBind();
                lblTotal.Text = String.Format("{0:c}", userShoppingCart.GetTotal());
                return userShoppingCart.GetListaProductos();
            }
        }

        public static IOrderedDictionary GetValues(GridViewRow row)
        {
            IOrderedDictionary values = new OrderedDictionary();
            foreach (DataControlFieldCell cell in row.Cells)
            {
                if (cell.Visible)
                {
                    // Extract values from the cell.
                    cell.ContainingField.ExtractValuesFromCell(values, cell, row.RowState, true);
                }
            }
            return values;
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateCartItems();
        }

        protected void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            using (ShoppingCartActions userShoppingCart = new ShoppingCartActions())
            {
                String PedidoId = userShoppingCart.GetCartId();
                if(!(Session["Usuario"] == null))
                {
                    Usuario usuario = _dq.getUsuarioByEmail(Session["Usuario"].ToString());
                    _dq.crearOrden(PedidoId, usuario.Id);

                    Guid tempCartId = Guid.NewGuid();
                    HttpContext.Current.Session["CartId"] = tempCartId.ToString();
                    Response.Redirect("MisPedidos");
                } else
                {
                    aviso.Text = "Debe registrarse para poder realizar un pedido.";
                }
            }

        }
    }
}