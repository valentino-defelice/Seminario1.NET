﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorio
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Models_DbContextDataSet3.ReporteVentas' table. You can move, or remove it, as needed.
            this.ReporteVentasTableAdapter.Fill(this._Models_DbContextDataSet3.ReporteVentas);
            // TODO: This line of code loads data into the '_Models_DbContextDataSet3.Ordens' table. You can move, or remove it, as needed.
            this.OrdensTableAdapter.Fill(this._Models_DbContextDataSet3.Ordens);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
