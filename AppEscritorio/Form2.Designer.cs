namespace AppEscritorio
{
    partial class Form2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.OrdensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Models_DbContextDataSet3 = new AppEscritorio._Models_DbContextDataSet3();
            this.OrdensTableAdapter = new AppEscritorio._Models_DbContextDataSet3TableAdapters.OrdensTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReporteVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteVentasTableAdapter = new AppEscritorio._Models_DbContextDataSet3TableAdapters.ReporteVentasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OrdensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Models_DbContextDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteVentasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdensBindingSource
            // 
            this.OrdensBindingSource.DataMember = "Ordens";
            this.OrdensBindingSource.DataSource = this._Models_DbContextDataSet3;
            // 
            // _Models_DbContextDataSet3
            // 
            this._Models_DbContextDataSet3.DataSetName = "_Models_DbContextDataSet3";
            this._Models_DbContextDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OrdensTableAdapter
            // 
            this.OrdensTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReporteVentasDataset";
            reportDataSource1.Value = this.ReporteVentasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppEscritorio.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(638, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteVentasBindingSource
            // 
            this.ReporteVentasBindingSource.DataMember = "ReporteVentas";
            this.ReporteVentasBindingSource.DataSource = this._Models_DbContextDataSet3;
            // 
            // ReporteVentasTableAdapter
            // 
            this.ReporteVentasTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Models_DbContextDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteVentasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource OrdensBindingSource;
        private _Models_DbContextDataSet3 _Models_DbContextDataSet3;
        private _Models_DbContextDataSet3TableAdapters.OrdensTableAdapter OrdensTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteVentasBindingSource;
        private _Models_DbContextDataSet3TableAdapters.ReporteVentasTableAdapter ReporteVentasTableAdapter;
    }
}