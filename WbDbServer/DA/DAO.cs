using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDbServer.DataBase;

namespace WbDbServer.DA
{
    public static class DAO
    {
        public static DataTable GetData(string queri)
        {
            DataTable Table = new DataTable();
            OracleDataAdapter adapter = new OracleDataAdapter();
            OracleCommand comm = new OracleCommand(queri, DbConnection.Connection);
            DbConnection.OpenConnection();

            adapter.SelectCommand = comm;
            adapter.Fill(Table);

            // Logs.Write(GroupsTable, "Группи");
            DbConnection.CloseConnection();

            return Table;
        }

        public static Exception NoAnswerQueri(string queri)
        {
            OracleCommand comm = new OracleCommand(queri, DbConnection.Connection);
            DbConnection.OpenConnection();
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return e;
            }
            DbConnection.CloseConnection();
            return null;
        }

     
    }
}
