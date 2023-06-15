﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_Minimarket.Presentacion.Reportes_Consolidado
{
    public partial class Frm_Rpt_Ingreso_AcumuladoxProducto : Form
    {
        public Frm_Rpt_Ingreso_AcumuladoxProducto()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Ingreso_AcumuladoxProducto_Load(object sender, EventArgs e)
        {
            this.uSP_Reporte_Ingreso_AcumuladoxProductoTableAdapter.Fill(this.dataSet_Reportes_Consolidado.USP_Reporte_Ingreso_AcumuladoxProducto, Fecha_ini: Convert.ToDateTime(txt_p1.Text), Fecha_fin: Convert.ToDateTime(txt_p2.Text));

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
