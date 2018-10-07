using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinesModel;
using Models;

namespace Seminario1
{
    public partial class Admin : System.Web.UI.Page
    {
        DatabaseQuerys _dq = new DatabaseQuerys();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var result = _dq.crearCategoria(CategoriaNombre.Text, CategoriaDescripcion.Text);

            if (result)
                resultado.Text = "Categoria creada con éxito";
            else
                resultado.Text = "Ocurrio un problema, la categoría no pudo ser cargada";
        }

        protected void ProductoCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Categorias = _dq.GetCategorias().ToList();
        }

        protected void CrearProducto_Click(object sender, EventArgs e)
        {
            /*Producto nuevo = new Producto();

            nuevo.Nombre = ProductoNombre.Text;
            nuevo.Descripcion = ProductoDescripcion.Text;
            nuevo.RutaImagen = ProductoImagenRute.Text;
            nuevo.Precio = Int32.Parse(ProductoPrecio.Text);
            nuevo.CategoriaId = Int32.Parse(ProductoCategoria.Text);
            */
            var result = _dq.crearProducto(ProductoNombre.Text, ProductoDescripcion.Text, ProductoImagenRute.Text, Int32.Parse(ProductoPrecio.Text), Int32.Parse(ProductoCategoria.Text));
            if (result)
                ResultadoProducto.Text = "Producto creado con éxito.";
            else
                ResultadoProducto.Text = "Ocurrio un problema, el producto no pudo ser creado.";
        }
    }
}