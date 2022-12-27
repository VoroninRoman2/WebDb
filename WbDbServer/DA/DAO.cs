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
        public static DataTable GetAll(string queri)
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
        public static DataRow GetbyId(string queri)
        {
            DataTable Table = new DataTable();
            OracleDataAdapter adapter = new OracleDataAdapter();
            OracleCommand comm = new OracleCommand(queri, DbConnection.Connection);
            DbConnection.OpenConnection();

            adapter.SelectCommand = comm;
            adapter.Fill(Table);
            if (Table.Rows.Count == 0)
            {
                return null;
            }
            DbConnection.CloseConnection();

            return Table.Rows[0];
        }
        public static void DeleteById(string queri)
        {
            OracleCommand comm = new OracleCommand(queri, DbConnection.Connection);
            DbConnection.OpenConnection();
            comm.ExecuteNonQuery();
            DbConnection.CloseConnection();
        }
        public static void Insert(string queri)
        {
            OracleCommand comm = new OracleCommand(queri, DbConnection.Connection);
            DbConnection.OpenConnection();
            comm.ExecuteNonQuery();
            DbConnection.CloseConnection();
        }
        public static void Update(string queri)
        {
            OracleCommand comm = new OracleCommand(queri, DbConnection.Connection);
            DbConnection.OpenConnection();
            comm.ExecuteNonQuery();
            DbConnection.CloseConnection();
        }
    }
}
