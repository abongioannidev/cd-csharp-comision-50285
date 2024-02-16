using System.Data.SqlClient;

namespace clase15022024.AdoNet
{
    public static class ConnectionADO
    {
        private static string stringConnection;
        private static SqlConnection connection;
        static ConnectionADO()
        {
            ConnectionADO.stringConnection = @"Server=.; Database=coderhouse; Trusted_Connection=True;";
        }
        public static SqlConnection GetConnection()
        {
            if (ConnectionADO.connection is null || ConnectionADO.connection.State == System.Data.ConnectionState.Broken || ConnectionADO.connection.State == System.Data.ConnectionState.Closed)
            {
                ConnectionADO.connection = new SqlConnection(ConnectionADO.stringConnection);
            }


            ConnectionADO.connection.Open();
            
            return ConnectionADO.connection;
        }

    }
}
