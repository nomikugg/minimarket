﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sol_Minimarket.Entidades;
using Sol_Minimarket.Datos;

namespace Sol_Minimarket.Negocio
{
    public class N_Usuarios
    {
        public static DataTable Listado_us(string cTexto)
        {
            D_Usuarios Datos = new D_Usuarios();
            return Datos.Listado_us(cTexto);
        }

        public static string Guardar_us(int nOpcion, E_Usuarios oUs)
        {
            D_Usuarios Datos = new D_Usuarios();
            return Datos.Guardar_us(nOpcion, oUs);
        }

        public static string Eliminar_us(int Codigo_us)
        {
            D_Usuarios Datos = new D_Usuarios();
            return Datos.Eliminar_us(Codigo_us);
        }

        public static DataTable Login_us(string cLogin, string cPassword)
        {
            D_Usuarios Datos = new D_Usuarios();
            return Datos.Login_us(cLogin, cPassword);
        }
    }
}
