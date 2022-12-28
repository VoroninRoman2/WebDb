using Oracle.ManagedDataAccess.Client;


namespace WebDbServer.DataBase
{
    class DbConnection
    {

        static readonly OracleConnection conn = new OracleConnection(@"DATA SOURCE = 127.0.0.1:1521/lb3;PASSWORD=111;PERSIST SECURITY INFO=True;USER ID = TEST");
        public static OracleConnection Connection
        {
            get
            {
                return conn;
            }
        }

        public static void OpenConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public static void CloseConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
     
    }
}
