using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Hotel.Ejercicios;
using System.Threading.Tasks;

namespace Hotel.Data
{
    public class SqliteHelper
    {
        SQLiteAsyncConnection db;
        public SqliteHelper(string dbPatch)
        {
            db = new SQLiteAsyncConnection(dbPatch);
            db.CreateTableAsync<trabajo>().Wait();
        }

        public Task<int>SaveActividad1(trabajo trabaj)
        {
            if (trabaj.IdActividad !=0)
            {
                return db.UpdateAsync(trabaj);
            }
            else
            {
                return db.InsertAsync(trabaj);
            }
        }
        public Task<List<trabajo>> GetTrabajosAsync()
        {
            return db.Table<trabajo>().ToListAsync();
        }

        public Task<trabajo> GetTrabajoByIdAsync(int idactividad)
        {
            return db.Table<trabajo>().Where(a => a.IdActividad == idactividad).FirstOrDefaultAsync();
        }

        public Task<int> DeleteTrabajoAsync(trabajo trabaj)
        {
            return db.DeleteAsync(trabaj);
        }
     
    }
}
