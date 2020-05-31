using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro.Core
{
    public class ProgramSettings
    {
        private static readonly object synch = new Object();
        private static ProgramSettings _instance = null;

        public string conectionString = null;
       // private ImportManager _manager = null;

        //public DbRepositoryManager _DbRepositoryManager = null;

        public static ProgramSettings Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (synch)
                    {
                        _instance = new ProgramSettings();
                    }
                }
                return _instance;
            }
        }


        public string curentAccentName { get; set; }
        public string curentThemeName { get; set; }


        /*
public string Import(string conectionstring, string exelpath)
{
  try
  {
      conectionString = conectionstring;
      _instance._DbRepositoryManager = new DbRepositoryManager();

      var lista = _instance._DbRepositoryManager.DodajJezyk();

      foreach (var item in lista.Rows)
      {


          Console.WriteLine(((Jezyk)item).Nazwa);
      }


      using (ExcelReader excel = new ExcelReader(exelpath))
      {
          if (excel.Read())
          {
              _manager = new ImportManager(excel.GetDataSet());
              _manager.ImportData();
          }


      }

      return "koniec ok";
  }
  catch (Exception ex)
  {

      return ex.Message;
  }


}
   */



    }
}
