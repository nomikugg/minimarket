﻿namespace Sol_Minimarket.Presentacion.Reportes_Consolidado
{
    partial class Frm_Reporte_Salida_AcumuladoxProducto
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
            this.Btn_vistaprevia = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Dp_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Dp_fecha_ini = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Btn_vistaprevia
            // 
            this.Btn_vistaprevia.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_vistaprevia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_vistaprevia.ForeColor = System.Drawing.Color.White;
            this.Btn_vistaprevia.Location = new System.Drawing.Point(257, 38);
            this.Btn_vistaprevia.Name = "Btn_vistaprevia";
            this.Btn_vistaprevia.Size = new System.Drawing.Size(97, 29);
            this.Btn_vistaprevia.TabIndex = 18;
            this.Btn_vistaprevia.Text = "Vista previa";
            this.Btn_vistaprevia.UseVisualStyleBackColor = false;
            this.Btn_vistaprevia.Click += new System.EventHandler(this.Btn_vistaprevia_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.Salmon;
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.ForeColor = System.Drawing.Color.White;
            this.Btn_salir.Location = new System.Drawing.Point(257, 70);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(97, 29);
            this.Btn_salir.TabIndex = 17;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fecha fin:";
            // 
            // Dp_fecha_fin
            // 
            this.Dp_fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dp_fecha_fin.Location = new System.Drawing.Point(128, 70);
            this.Dp_fecha_fin.Name = "Dp_fecha_fin";
            this.Dp_fecha_fin.Size = new System.Drawing.Size(91, 20);
            this.Dp_fecha_fin.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fecha inicio:";
            // 
            // Dp_fecha_ini
            // 
            this.Dp_fecha_ini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dp_fecha_ini.Location = new System.Drawing.Point(128, 44);
            this.Dp_fecha_ini.Name = "Dp_fecha_ini";
            this.Dp_fecha_ini.Size = new System.Drawing.Size(91, 20);
            this.Dp_fecha_ini.TabIndex = 13;
            // 
            // Frm_Reporte_Salida_AcumuladoxProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 155);
            this.Controls.Add(this.Btn_vistaprevia);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dp_fecha_fin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dp_fecha_ini);
            this.Name = "Frm_Reporte_Salida_AcumuladoxProducto";
            this.Text = "Frm_Reporte_Salida_AcumuladoxProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_vistaprevia;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dp_fecha_fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dp_fecha_ini;
    }
}