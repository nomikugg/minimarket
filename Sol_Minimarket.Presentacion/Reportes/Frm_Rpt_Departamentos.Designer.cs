﻿namespace Sol_Minimarket.Presentacion.Reportes
{
    partial class Frm_Rpt_Departamentos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_MiniMarket = new Sol_Minimarket.Presentacion.Reportes.DataSet_MiniMarket();
            this.uSPListadodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_Listado_deTableAdapter = new Sol_Minimarket.Presentacion.Reportes.DataSet_MiniMarketTableAdapters.USP_Listado_deTableAdapter();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_MiniMarket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadodeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.uSPListadodeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_Minimarket.Presentacion.Reportes.Rpt_Departamentos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet_MiniMarket
            // 
            this.dataSet_MiniMarket.DataSetName = "DataSet_MiniMarket";
            this.dataSet_MiniMarket.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPListadodeBindingSource
            // 
            this.uSPListadodeBindingSource.DataMember = "USP_Listado_de";
            this.uSPListadodeBindingSource.DataSource = this.dataSet_MiniMarket;
            // 
            // uSP_Listado_deTableAdapter
            // 
            this.uSP_Listado_deTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(22, 54);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(100, 20);
            this.txt_p1.TabIndex = 4;
            this.txt_p1.Visible = false;
            // 
            // Frm_Rpt_Departamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Departamentos";
            this.Text = "Frm_Rpt_Departamentos";
            this.Load += new System.EventHandler(this.Frm_Rpt_Departamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_MiniMarket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadodeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPListadodeBindingSource;
        private DataSet_MiniMarket dataSet_MiniMarket;
        private DataSet_MiniMarketTableAdapters.USP_Listado_deTableAdapter uSP_Listado_deTableAdapter;
        public System.Windows.Forms.TextBox txt_p1;
    }
}