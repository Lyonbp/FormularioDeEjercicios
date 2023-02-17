using System;
using System.Collections.Generic;
using System.Text;

namespace caso2bd.datos
{
    class Empleado
    {
        private string documento;
        private string nombre;
        private string apellido;
        private int edad;
        private string fecha_nac;
        private string direccion;
    


    public Empleado()
        {
            this.documento = "";
            this.nombre = "";
            this.apellido = "";
            this.edad = 0;
            this.fecha_nac = "";
            this.direccion = "";

         }
         public string Documento { get => documento; set => documento = value; }
         public string Nombres { get => nombre; set => nombre = value; }
         public string Apellidos { get => apellido; set => apellido = value; }
         public int Edad { get => edad; set => edad = value; }
         public string Direccion { get => direccion; set => direccion = value; }
         public string Fecha_nac { get => fecha_nac; set => fecha_nac = value; }
    }
}


