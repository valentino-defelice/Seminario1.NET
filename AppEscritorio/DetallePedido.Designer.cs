namespace AppEscritorio
{
    partial class DetallePedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridDetalleDelPedido = new System.Windows.Forms.DataGridView();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnMisPedidos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleDelPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDetalleDelPedido
            // 
            this.gridDetalleDelPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetalleDelPedido.Location = new System.Drawing.Point(224, 126);
            this.gridDetalleDelPedido.Name = "gridDetalleDelPedido";
            this.gridDetalleDelPedido.Size = new System.Drawing.Size(380, 166);
            this.gridDetalleDelPedido.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(37, 126);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(118, 32);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnMisPedidos
            // 
            this.btnMisPedidos.Location = new System.Drawing.Point(37, 214);
            this.btnMisPedidos.Name = "btnMisPedidos";
            this.btnMisPedidos.Size = new System.Drawing.Size(118, 32);
            this.btnMisPedidos.TabIndex = 2;
            this.btnMisPedidos.Text = "Mis Pedidos";
            this.btnMisPedidos.UseVisualStyleBackColor = true;
            this.btnMisPedidos.Click += new System.EventHandler(this.btnMisPedidos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(64, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Detalle del pedido";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblResultado.Location = new System.Drawing.Point(179, 38);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 25);
            this.lblResultado.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(431, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblTotal.Location = new System.Drawing.Point(509, 339);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 25);
            this.lblTotal.TabIndex = 6;
            // 
            // DetallePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 388);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMisPedidos);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.gridDetalleDelPedido);
            this.Name = "DetallePedido";
            this.Text = "DetallePedido";
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleDelPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDetalleDelPedido;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnMisPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
    }
}