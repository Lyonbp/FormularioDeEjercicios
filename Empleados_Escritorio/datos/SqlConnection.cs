﻿using System;

namespace Empleados_Escritorio.datos
{
    internal class SqlConnection
    {
        private string v;

        public SqlConnection(string v)
        {
            this.v = v;
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}