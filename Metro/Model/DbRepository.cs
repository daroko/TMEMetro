using Metro.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro.Model
{
    public class DbRepository
    {
        private IDbManager _dbMenager = null;

        public DbRepository(DbManager dbMenager)
        {
            _dbMenager = dbMenager;
        }

        public List<int> GetUsedNumbers()
        {
            return _dbMenager.GetTableInt("SELECT UsedNumber FROM numbers");
        }
        public List<int> GetUsedNumbersCount()
        {
            return _dbMenager.GetTableInt("SELECT count(*) as UsedNumber FROM numbers");
        }

        public string CheckVersion()
        {
            return _dbMenager.CheckVersion();
        }

        public bool NumbersInsert(List<int> numberRandom)
        {
           return  _dbMenager.NumbersInsert(numberRandom);
        }

        public bool ClearTable()
        {
          return  _dbMenager.ClearTable("DROP TABLE IF EXISTS numbers", "CREATE TABLE numbers(Id INTEGER PRIMARY KEY, UsedNumber INT)");
        }

        public bool CreateTableNumericIFNotExist()
        {
           return _dbMenager.CheckTableExistAndCreate("CREATE TABLE IF NOT EXISTS numbers(Id INTEGER PRIMARY KEY, UsedNumber INT)");
        }



    }
}
