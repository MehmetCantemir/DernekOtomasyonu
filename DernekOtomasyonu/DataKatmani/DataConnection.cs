using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace DernekOtomasyonu.DataKatmani
{
    internal class DataConnection
    {
        public DataConnection()
        {
            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\dernekdata.accdb");
        }
        
    }
}
