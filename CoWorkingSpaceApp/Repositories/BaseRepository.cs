using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoWorkingSpaceApp.Helpers;
using Dapper.Contrib.Extensions;

namespace CoWorkingSpaceApp.Repositories
{
    public class BaseRepository<T> where T : class
    {



        // SHOW PRODUCT
        
        public IEnumerable<T> GetAll() 
        {
            using (SqlConnection db = DbConnection.GetConn())
            {
                return db.GetAll<T>();
            }
        }
        public T GetById(int id)
        {
            using (SqlConnection db = DbConnection.GetConn())
            {
                return db.Get<T>(id);
            }
        }

        // INSERT PRODUCT
        public long Insert(T entity)
        {
            using (SqlConnection db = DbConnection.GetConn())
            {
                return db.Insert<T>(entity);
            }
        }

        // UPDATE PRODUCT
        public bool Update(T entity)
        {
            {
                using (SqlConnection db = DbConnection.GetConn())
                {
                    return db.Update<T>(entity);
                }
            }
        }

        // DELETE PRODUCT
        public bool DeleteById(int id)
        {
            using (SqlConnection db = DbConnection.GetConn())
            {
                var entity = db.Get<T>(id);
                if (entity != null)
                {
                    return db.Delete(entity);
                }
                return false;
            }
        }
    }
}
