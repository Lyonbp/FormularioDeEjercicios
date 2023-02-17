using System;
using System.Collections.Generic;
using System.Text;

namespace caso2bd.modelo
{
    class Empleados
    {
        public static bool guardar(Empleado e)
        {
            try
            {
                conexion con = new conexion();
                String sql = "insert into empleado values ('" + e.Documento + "','" + e.Nombres + "','" + e.Apellidos + "'," + e.Edad + ",'" + e.Direccion + "','" + e.Fecha_nac + "')";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    return true;
                }
                else return false;
                con.desconectar();



            }
            catch (Exception ex)
            {
                return false;
            }
        }



    }
}
