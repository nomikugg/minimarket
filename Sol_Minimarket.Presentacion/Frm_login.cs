using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sol_Minimarket.Negocio;
using Sol_Minimarket.Entidades;

namespace Sol_Minimarket.Presentacion
{
    public partial class Frm_login : Form
    {

        public Frm_login()
        {
            InitializeComponent();
            //this.Txt_login_us.AutoSize = false;
            //this.Txt_login_us.Height = 33;
            //.Txt_login_us.Text = 
            // this.Txt_login_us.Margin = (4, 4, 4, 4);
            // this.Txt_login_us.Multiline = true;
            //this.Txt_login_us.TextAlign= ;
            //this.Txt_login_us.Top. = (this.Height - Txt_login_us.Height) / 2;
        }
        #region "Mis Métodos"
        private void Login_us(string cLogin,string cPassword)
        {
            try
            {
                DataTable data_login = new DataTable();
                data_login = N_Usuarios.Login_us(cLogin, cPassword);
                if (data_login.Rows.Count>0)
                {
                    string cNombres="";
                    string cCargo = "";
                    bool bAdmin = false;

                    cNombres =Convert.ToString(data_login.Rows[0][3]);
                    cCargo= Convert.ToString(data_login.Rows[0][4]);
                    bAdmin = Convert.ToBoolean(data_login.Rows[0][5]);

                    Frm_DashBoard oDashBoard = new Frm_DashBoard();
                    oDashBoard.Lbl_nombres_us.Text = "Nombres: " + cNombres;
                    oDashBoard.Lbl_cargo.Text = "Cargo: " + cCargo;
                    oDashBoard.Chk_admin.Checked = bAdmin;

                    if (bAdmin==true) //Administrador
                    {
                        oDashBoard.Btn_procesos.Enabled = true;
                        oDashBoard.Btn_reportes.Enabled = true;
                        oDashBoard.Btn_datosmaestros.Enabled = true;
                        oDashBoard.Btn_sistemas.Enabled = true;
                    }
                    else // Usuario normal
                    {
                        oDashBoard.Btn_procesos.Enabled = true;
                        oDashBoard.Btn_reportes.Enabled = true;
                        oDashBoard.Btn_datosmaestros.Enabled = false;
                        oDashBoard.Btn_sistemas.Enabled = false;
                    }

                    oDashBoard.Show();
                    oDashBoard.FormClosed += Logout;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Acceso errado", "Aviso del Sistema");
                }

               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            Txt_login_us.Text = "";
            Txt_password_us.Text = "";
            this.Show();
            Txt_login_us.Focus();
        }

        #endregion

        private void Btn_iniciar_Click(object sender, EventArgs e)
        {
            this.Login_us(Txt_login_us.Text,Txt_password_us.Text);
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_login_us_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
