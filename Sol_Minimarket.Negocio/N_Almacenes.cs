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
    public class N_Almacenes
    {
        public static DataTable Listado_al(string cTexto)
        {
            D_Almacenes Datos = new D_Almacenes();
            return Datos.Listado_al(cTexto);
        }

        public static string Guardar_al(int nOpcion, E_Almacenes oAl)
        {
            D_Almacenes Datos = new D_Almacenes();
            return Datos.Guardar_al(nOpcion, oAl);
        }

        public static string Eliminar_al(int Codigo_al)
        {
            D_Almacenes Datos = new D_Almacenes();
            return Datos.Eliminar_al(Codigo_al);
        }
    }
}
