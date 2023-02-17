using System;

namespace caso2bd.modelo
{
    internal class SqlCommand
    {
        private string sql;
        private SqlConnection sqlConnection;

        public SqlCommand(string sql, SqlConnection sqlConnection)
        {
            this.sql = sql;
            this.sqlConnection = sqlConnection;
        }

        internal int ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }
    }
}