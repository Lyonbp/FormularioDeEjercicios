using System;
using System.Collections.Generic;
using System.Text;

namespace caso2bd.modelo
{
    class conexion
    {


        SqlConnection con;
        public conexion()
        {
            con = new SqlConnection("Server=DESKTOP-J0BDLOG;DataBase=bdcolegio;integrated security=true");
        }
        public SqlConnection conectar()
        {
            try
            {
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                return null;
            }

        }



        public bool desconectar()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }



        }



    }
}
