namespace AppEscritorio
{
    partial class CrearPedido
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgregarAlCarrito = new System.Windows.Forms.DataGridViewButtonColumn();
            this.productoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Models_DbContextDataSet = new AppEscritorio._Models_DbContextDataSet();
            this.productoesTableAdapter = new AppEscritorio._Models_DbContextDataSetTableAdapters.ProductoesTableAdapter();
            this.ordensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Models_DbContextDataSet2 = new AppEscritorio._Models_DbContextDataSet2();
            this._Models_DbContextDataSet1 = new AppEscritorio._Models_DbContextDataSet1();
            this.modelsDbContextDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordensTableAdapter = new AppEscritorio._Models_DbContextDataSet2TableAdapters.OrdensTableAdapter();
            this.gridOrderLines = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.sequenceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Models_DbContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Models_DbContextDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Models_DbContextDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsDbContextDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderLines)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Producto,
            this.descripcionDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.AgregarAlCarrito});
            this.dataGridView1.DataSource = this.productoesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(127, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 151);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "IdProducto";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "Nombre";
            this.Producto.HeaderText = "Nombre";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // AgregarAlCarrito
            // 
            this.AgregarAlCarrito.DataPropertyName = "Id";
            this.AgregarAlCarrito.HeaderText = "AgregarAlCarrito";
            this.AgregarAlCarrito.Name = "AgregarAlCarrito";
            this.AgregarAlCarrito.ReadOnly = true;
            // 
            // productoesBindingSource
            // 
            this.productoesBindingSource.DataMember = "Productoes";
            this.productoesBindingSource.DataSource = this._Models_DbContextDataSet;
            // 
            // _Models_DbContextDataSet
            // 
            this._Models_DbContextDataSet.DataSetName = "_Models_DbContextDataSet";
            this._Models_DbContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoesTableAdapter
            // 
            this.productoesTableAdapter.ClearBeforeFill = true;
            // 
            // ordensBindingSource
            // 
            this.ordensBindingSource.DataMember = "Ordens";
            this.ordensBindingSource.DataSource = this._Models_DbContextDataSet2;
            // 
            // _Models_DbContextDataSet2
            // 
            this._Models_DbContextDataSet2.DataSetName = "_Models_DbContextDataSet2";
            this._Models_DbContextDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _Models_DbContextDataSet1
            // 
            this._Models_DbContextDataSet1.DataSetName = "_Models_DbContextDataSet1";
            this._Models_DbContextDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modelsDbContextDataSet1BindingSource
            // 
            this.modelsDbContextDataSet1BindingSource.DataSource = this._Models_DbContextDataSet1;
            this.modelsDbContextDataSet1BindingSource.Position = 0;
            // 
            // ordensTableAdapter
            // 
            this.ordensTableAdapter.ClearBeforeFill = true;
            // 
            // gridOrderLines
            // 
            this.gridOrderLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrderLines.Location = new System.Drawing.Point(127, 288);
            this.gridOrderLines.Name = "gridOrderLines";
            this.gridOrderLines.Size = new System.Drawing.Size(445, 150);
            this.gridOrderLines.TabIndex = 1;
            this.gridOrderLines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridOrderLines_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label1.Location = new System.Drawing.Point(120, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pedido:";
            // 
            // sequenceLabel
            // 
            this.sequenceLabel.AutoSize = true;
            this.sequenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.sequenceLabel.Location = new System.Drawing.Point(258, 22);
            this.sequenceLabel.Name = "sequenceLabel";
            this.sequenceLabel.Size = new System.Drawing.Size(0, 39);
            this.sequenceLabel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // CrearPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sequenceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridOrderLines);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CrearPedido";
            this.Text = "CrearPedido";
            this.Load += new System.EventHandler(this.CrearPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Models_DbContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Models_DbContextDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Models_DbContextDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsDbContextDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _Models_DbContextDataSet _Models_DbContextDataSet;
        private System.Windows.Forms.BindingSource productoesBindingSource;
        private _Models_DbContextDataSetTableAdapters.ProductoesTableAdapter productoesTableAdapter;
        private System.Windows.Forms.BindingSource modelsDbContextDataSet1BindingSource;
        private _Models_DbContextDataSet1 _Models_DbContextDataSet1;
        private _Models_DbContextDataSet2 _Models_DbContextDataSet2;
        private System.Windows.Forms.BindingSource ordensBindingSource;
        private _Models_DbContextDataSet2TableAdapters.OrdensTableAdapter ordensTableAdapter;
        private System.Windows.Forms.DataGridView gridOrderLines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sequenceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn AgregarAlCarrito;
    }
}