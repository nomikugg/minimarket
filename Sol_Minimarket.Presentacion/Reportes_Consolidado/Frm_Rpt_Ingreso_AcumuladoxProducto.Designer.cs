﻿namespace Sol_Minimarket.Presentacion.Reportes_Consolidado
{
    partial class Frm_Rpt_Ingreso_AcumuladoxProducto
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
            this.uSPReporteIngresoAcumuladoxProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Reportes_Consolidado = new Sol_Minimarket.Presentacion.Reportes_Consolidado.DataSet_Reportes_Consolidado();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uSP_Reporte_Ingreso_AcumuladoxProductoTableAdapter = new Sol_Minimarket.Presentacion.Reportes_Consolidado.DataSet_Reportes_ConsolidadoTableAdapters.USP_Reporte_Ingreso_AcumuladoxProductoTableAdapter();
            this.txt_p2 = new System.Windows.Forms.TextBox();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uSPReporteIngresoAcumuladoxProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Reportes_Consolidado)).BeginInit();
            this.SuspendLayout();
            // 
            // uSPReporteIngresoAcumuladoxProductoBindingSource
            // 
            this.uSPReporteIngresoAcumuladoxProductoBindingSource.DataMember = "USP_Reporte_Ingreso_AcumuladoxProducto";
            this.uSPReporteIngresoAcumuladoxProductoBindingSource.DataSource = this.dataSet_Reportes_Consolidado;
            // 
            // dataSet_Reportes_Consolidado
            // 
            this.dataSet_Reportes_Consolidado.DataSetName = "DataSet_Reportes_Consolidado";
            this.dataSet_Reportes_Consolidado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uSPReporteIngresoAcumuladoxProductoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_Minimarket.Presentacion.Reportes_Consolidado.Rpt_Ingreso_AcumuladoxProducto.r" +
    "dlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(993, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // uSP_Reporte_Ingreso_AcumuladoxProductoTableAdapter
            // 
            this.uSP_Reporte_Ingreso_AcumuladoxProductoTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p2
            // 
            this.txt_p2.Location = new System.Drawing.Point(36, 82);
            this.txt_p2.Name = "txt_p2";
            this.txt_p2.Size = new System.Drawing.Size(100, 20);
            this.txt_p2.TabIndex = 5;
            this.txt_p2.Visible = false;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(36, 56);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(100, 20);
            this.txt_p1.TabIndex = 4;
            this.txt_p1.Visible = false;
            // 
            // Frm_Rpt_Ingreso_AcumuladoxProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 450);
            this.Controls.Add(this.txt_p2);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Ingreso_AcumuladoxProducto";
            this.Text = "Frm_Rpt_Ingreso_AcumuladoxProducto";
            this.Load += new System.EventHandler(this.Frm_Rpt_Ingreso_AcumuladoxProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSPReporteIngresoAcumuladoxProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Reportes_Consolidado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPReporteIngresoAcumuladoxProductoBindingSource;
        private DataSet_Reportes_Consolidado dataSet_Reportes_Consolidado;
        private DataSet_Reportes_ConsolidadoTableAdapters.USP_Reporte_Ingreso_AcumuladoxProductoTableAdapter uSP_Reporte_Ingreso_AcumuladoxProductoTableAdapter;
        public System.Windows.Forms.TextBox txt_p2;
        public System.Windows.Forms.TextBox txt_p1;
    }
}