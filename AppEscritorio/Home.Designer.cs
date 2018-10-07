namespace AppEscritorio
{
    partial class Home
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
            this._Models_DbContextDataSet = new AppEscritorio._Models_DbContextDataSet();
            this.productoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoesTableAdapter = new AppEscritorio._Models_DbContextDataSetTableAdapters.ProductoesTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CantidadTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._Models_DbContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _Models_DbContextDataSet
            // 
            this._Models_DbContextDataSet.DataSetName = "_Models_DbContextDataSet";
            this._Models_DbContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoesBindingSource
            // 
            this.productoesBindingSource.DataMember = "Productoes";
            this.productoesBindingSource.DataSource = this._Models_DbContextDataSet;
            // 
            // productoesTableAdapter
            // 
            this.productoesTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoesBindingSource, "Precio", true));
            this.comboBox1.DataSource = this.productoesBindingSource;
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(343, 165);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Crear un Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad";
            // 
            // CantidadTxtBox
            // 
            this.CantidadTxtBox.Location = new System.Drawing.Point(343, 235);
            this.CantidadTxtBox.Name = "CantidadTxtBox";
            this.CantidadTxtBox.Size = new System.Drawing.Size(121, 20);
            this.CantidadTxtBox.TabIndex = 5;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 673);
            this.Controls.Add(this.CantidadTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Home";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Models_DbContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private _Models_DbContextDataSet _Models_DbContextDataSet;
        private System.Windows.Forms.BindingSource productoesBindingSource;
        private _Models_DbContextDataSetTableAdapters.ProductoesTableAdapter productoesTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CantidadTxtBox;
    }
}