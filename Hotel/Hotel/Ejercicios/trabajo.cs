using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace Hotel.Ejercicios
{
    public  class trabajo
    {
        [PrimaryKey,AutoIncrement]
        public int IdActividad { get; set; }
        [MaxLength(100)]
        public string Actividad1 { get; set; }
        [MaxLength(50)]
        public string Actividad2 { get; set; }
        [MaxLength(50)]
        public string Actividad3 { get; set; }
        [MaxLength(50)]
        public string Actividad4 {get; set; }
        [MaxLength(50)]
        public string Actividad5 { get; set; }
        [MaxLength(50)]
        public string Actividad6 { get; set; }
        [MaxLength(50)]
        public string Actividad7 { get; set; }
        [MaxLength(50)]
        public string Actividad8 { get; set; }
        [MaxLength(50)]
        public string Actividad9 { get; set; }
        [MaxLength(50)]
        public string Actividad10 { get; set; }
    }
}
