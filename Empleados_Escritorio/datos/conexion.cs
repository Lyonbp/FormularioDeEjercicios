using System;
using System.Collections.Generic;
using System.Text;

namespace Empleados_Escritorio.datos
{
    class conexion
    {
        SqlConnection con;
        public conexion()
        {
            con = new SqlConnection("Server=localhost\\DESKTOP-J0BDLOG;Database=empleado_db;integrated security=true");
        }

        public SqlConnection conectar()
        {
            try
            {
                con.Open();
                return con;
            }
            
        
          catch(Exception e)
            {

            }



         }
    }
}
