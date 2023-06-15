﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sol_Minimarket.Entidades;
using Sol_Minimarket.Negocio;

namespace Sol_Minimarket.Presentacion
{
    public partial class Frm_Distritos : Form
    {
        public Frm_Distritos()
        {
            InitializeComponent();
        }
        #region "Mis Variables"
        int Codigo_di = 0;
        int Codigo_po = 0;
        int Estadoguarda = 0; //Sin ninguna acción
        #endregion

        #region "Mis Métodos"
        private void Formato_di()
        {
            Dgv_principal.Columns[0].Width = 100;
            Dgv_principal.Columns[0].HeaderText = "CÓDIGO_DI";
            Dgv_principal.Columns[1].Width = 270;
            Dgv_principal.Columns[1].HeaderText = "DISTRITO";
            Dgv_principal.Columns[2].Width = 270;
            Dgv_principal.Columns[2].HeaderText = "PROVINCIA";
            Dgv_principal.Columns[3].Width = 270;
            Dgv_principal.Columns[3].HeaderText = "DEPARTAMENTO";
            Dgv_principal.Columns[4].Visible = false;
        }

        private void Listado_di(string cTexto)
        {
            try
            {
                Dgv_principal.DataSource = N_Distritos.Listado_di(cTexto);
                this.Formato_di();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Estado_Botonesprincipales(bool lEstado)
        {
            this.Btn_nuevo.Enabled = lEstado;
            this.Btn_actualizar.Enabled = lEstado;
            this.Btn_eliminar.Enabled = lEstado;
            this.Btn_reporte.Enabled = lEstado;
            this.Btn_salir.Enabled = lEstado;
        }

        private void Estado_Botonesprocesos(bool lEstado)
        {
            this.Btn_cancelar.Visible = lEstado;
            this.Btn_guardar.Visible = lEstado;
            this.Btn_retornar.Visible = !lEstado;
            this.Btn_lupa1.Visible = lEstado;
        }

        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["codigo_di"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_po = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_po"].Value);
                Txt_descripcion_po.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_po"].Value).Trim();

                this.Codigo_di = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_di"].Value);
                Txt_descripcion_di.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_di"].Value).Trim();                
            }           
        }

        private void Formato_po_personalizado()
        {           
            Dgv_provincias.Columns[0].Width = 300;
            Dgv_provincias.Columns[0].HeaderText = "PROVINCIA";
            Dgv_provincias.Columns[1].Width = 300;
            Dgv_provincias.Columns[1].HeaderText = "DEPARTAMENTO";
            Dgv_provincias.Columns[2].Visible = false;
        }

        private void Listado_po_personalizado(string cTexto)
        {
            try
            {
                Dgv_provincias.DataSource = N_Distritos.Listado_po_personalizado(cTexto);
                this.Formato_po_personalizado();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_item_po_personalizado()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_provincias.CurrentRow.Cells["codigo_po"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_po = Convert.ToInt32(Dgv_provincias.CurrentRow.Cells["codigo_po"].Value);
                Txt_descripcion_po.Text = Convert.ToString(Dgv_provincias.CurrentRow.Cells["descripcion_po"].Value);
            }
        }
        #endregion

        private void Frm_Distritos_Load(object sender, EventArgs e)
        {
            this.Listado_di("%");
            this.Listado_po_personalizado("%");
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (Txt_descripcion_po.Text == String.Empty ||
                Txt_descripcion_di.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresa datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Se procedería a registrar la información
            {
               E_Distritos oDi = new E_Distritos();
                string Rpta = "";
                oDi.Codigo_di = this.Codigo_di;
                oDi.Descripcion_di = Txt_descripcion_di.Text.Trim();
                oDi.Codigo_po = this.Codigo_po;
                Rpta = N_Distritos.Guardar_di(Estadoguarda, oDi);
                if (Rpta=="OK")
                {
                    this.Listado_di("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Estadoguarda = 0; //Sin nunguna acción
                    this.Estado_Botonesprincipales(true);
                    this.Estado_Botonesprocesos(false);
                    Txt_descripcion_di.Text = "";
                    Txt_descripcion_di.ReadOnly = true;
                    Tbc_principal.SelectedIndex = 0;
                    this.Codigo_di = 0;

                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            Estadoguarda = 1; //Nuevo Registro
            this.Estado_Botonesprincipales(false);
            this.Estado_Botonesprocesos(true);
            Txt_descripcion_di.Text = "";
            Txt_descripcion_di.ReadOnly = false;
            Tbc_principal.SelectedIndex = 1;
            Txt_descripcion_di.Focus();
            
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 2; //Actualizar registro
            this.Estado_Botonesprincipales(false);
            this.Estado_Botonesprocesos(true);
            this.Selecciona_item();
            Tbc_principal.SelectedIndex = 1;
            Txt_descripcion_di.ReadOnly = false;           
            Txt_descripcion_di.Focus();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 0; //Sin ninguna acción
            this.Codigo_di = 0;
            Txt_descripcion_di.Text = "";
            Txt_descripcion_di.ReadOnly = true;
            this.Estado_Botonesprincipales(true);
            this.Estado_Botonesprocesos(false);
            Tbc_principal.SelectedIndex = 0;
        }

        private void Dgv_principal_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item();
            this.Estado_Botonesprocesos(false);
            Tbc_principal.SelectedIndex = 1; 
            
        }

        private void Btn_retornar_Click(object sender, EventArgs e)
        {
            this.Estado_Botonesprocesos(false);
            Tbc_principal.SelectedIndex = 0;
            this.Codigo_di = 0;
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["codigo_di"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Estás seguro de eliminar el registro seleccionado?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Opcion==DialogResult.Yes)
                {
                    string Rpta = "";
                    this.Codigo_di = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_di"].Value);
                    Rpta = N_Provincias.Eliminar_po(this.Codigo_po);
                    if (Rpta.Equals("OK"))
                    {
                        this.Listado_di("%");
                        this.Codigo_di = 0;
                        MessageBox.Show("Registro Eliminado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                
               
            }

        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_di(Txt_buscar.Text.Trim());
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            Reportes.Frm_Rpt_Distritos oRpt8 = new Reportes.Frm_Rpt_Distritos();
            oRpt8.txt_p1.Text = Txt_buscar.Text;
            oRpt8.ShowDialog();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_lupa1_Click(object sender, EventArgs e)
        {
            Pnl_Listado_po.Visible = true;
        }

        private void Btn_retornar1_Click(object sender, EventArgs e)
        {
            Pnl_Listado_po.Visible = false;
        }

        private void Dgv_provincias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item_po_personalizado();
            Pnl_Listado_po.Visible = false;
            Txt_descripcion_di.Focus();
        }

        private void Btn_buscar1_Click(object sender, EventArgs e)
        {
            this.Listado_po_personalizado(Txt_buscar1.Text);
        }
    }
}
