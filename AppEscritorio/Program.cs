using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorio
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        public struct ShoppingCartUpdates
        {
            public string PedidoId;
            public Usuario Usuario;
            public int OrdenId;
            public int ProductoId;
            public int CantidadComprada;
            public bool EliminarItem;
        }
    }
}
