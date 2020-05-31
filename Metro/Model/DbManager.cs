using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro.Model
{
    public interface IDbManager
    {
        List<int> GetTableInt(string query);

        string CheckVersion();

        bool NumbersInsert(List<int> numberRandom);

        bool ClearTable(string query1, string query2);

        bool CheckTableExistAndCreate(string query1);
    }


    public class DbManager : IDbManager, IDisposable
    {
        private string _connectionString;
        private SQLiteConnection _sqlConnection = null;

        public DbManager(string con)
        {
            try
            {
                _connectionString = con;
                if (string.IsNullOrEmpty(_connectionString))
                    throw new Exception($"connection null");

                Initialize();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Initialize()
        {
            try
            {
                _sqlConnection = new SQLiteConnection(_connectionString);
                _sqlConnection.Open();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public string CheckVersion()
        {
            string cs = "Data Source=:memory:";
            string stm = "SELECT SQLITE_VERSION()";
            string version = null;

            using (var con = new SQLiteConnection(cs))
            {
                con.Open();

                using (var cmd = new SQLiteCommand(stm, con))
                {
                     version = cmd.ExecuteScalar().ToString();
                }

            }

            Console.WriteLine($"SQLite version: {version}");
            return version;
        }




        public List<int> GetTableInt(string query)
        {
            try
            {
                List<int> ImportedFiles = new List<int>();
                using (SQLiteCommand fmd = new SQLiteCommand(_sqlConnection))
                {
                    fmd.CommandText = query;
                    fmd.CommandType = CommandType.Text;
                    using (SQLiteDataReader r = fmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            ImportedFiles.Add(Convert.ToInt32(r["UsedNumber"]));
                        }
                    }
                }
                return ImportedFiles;

            }
            catch (Exception e)
            {
                throw new Exception($" {e.Message} : {query}");
            }
        }


        public bool NumbersInsert(List<int> numberRandom)
        {
            try
            {

                using (var cmd = new SQLiteCommand(_sqlConnection))
                {
                    using (var transaction = _sqlConnection.BeginTransaction())
                    {
                        for (var i = 0; i < numberRandom.Count(); i++)
                        {
                            cmd.CommandText =
                                "INSERT INTO numbers (UsedNumber) VALUES ('" + numberRandom[i] + "');";
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                }

            }
            catch (Exception e)
            {
                throw new Exception($" {e.Message} ");
            }
            return true;
        }

        public bool ClearTable(string query1,string query2)
        {
            try
            {
                    using (SQLiteCommand cmd = new SQLiteCommand(_sqlConnection))
                    {
                        cmd.CommandText = query1;
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = query2;
                        cmd.ExecuteNonQuery();

                    }
            }
            catch (Exception e)
            {
                throw new Exception($" {e.Message} ");
            }
            return true;
        }

        public bool CheckTableExistAndCreate(string query1)
        {
            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(_sqlConnection))
                {
                    cmd.CommandText = query1;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception e)
            {
                throw new Exception($" {e.Message} ");
            }
            return true;
        }








        public void Dispose()
        {
            if (_sqlConnection != null)
            {

                if (_sqlConnection.State == ConnectionState.Open)
                    _sqlConnection.Close();

                _sqlConnection.Dispose();
            }
        }


    }
}
