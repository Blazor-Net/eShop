using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace eShop.DataStore.SQL.Dapper.Helpers
{
    public class DataAccess : IDataAccess
    {
        private readonly string connectionString;
        public DataAccess(String connectionString)
        {
            this.connectionString = connectionString;
        }
        // return single record
        // T stands --> return output 
        // U stands --> input (parameter) 
        // QuerySingle shows error if record not found but QueryFirst does not
        // Best approach to prefer use QueryFirst
        public T QuerySingle<T, U>(string sql, U parameters)
        {
            using (IDbConnection conn = new SqlConnection(connectionString))
            {
                return conn.QuerySingle<T>(sql, parameters);
            }
        }
        public T QueryFirst<T, U>(string sql, U parameters)
        {
            using (IDbConnection conn = new SqlConnection(connectionString))
            {
                return conn.QueryFirst<T>(sql, parameters);
            }
        }
        // Return multiple records
        public List<T> Query<T, U>(string sql, U parameters)
        {
            using (IDbConnection conn = new SqlConnection(connectionString))
            {
                return conn.Query<T>(sql, parameters).ToList();
            }
        }
        // T stands for input
        public void ExecuteCommand<T>(string sql, T parameters)
        {
            using (IDbConnection conn = new SqlConnection(connectionString))
            {
                conn.Execute(sql, parameters);
            }
        }
    }
}
