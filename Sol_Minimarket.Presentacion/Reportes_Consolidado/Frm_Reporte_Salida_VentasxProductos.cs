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
    public partial class Frm_Reporte_Salida_VentasxProductos : Form
    {
        public Frm_Reporte_Salida_VentasxProductos()
        {
            InitializeComponent();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_vistaprevia_Click(object sender, EventArgs e)
        {
            Reportes_Consolidado.Frm_Rpt_Salida_VentasxProductos oRpt_SVP = new Reportes_Consolidado.Frm_Rpt_Salida_VentasxProductos();
            oRpt_SVP.txt_p1.Text =Convert.ToString(Dp_fecha_ini.Value);
            oRpt_SVP.txt_p2.Text = Convert.ToString(Dp_fecha_fin.Value);
            oRpt_SVP.ShowDialog();
        }
    }
}
