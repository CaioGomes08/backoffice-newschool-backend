using MySql.Data.MySqlClient;
using System;

namespace NewSchool.Backoffice.Infra.Data.Context
{
    public class DataContext : IDisposable
    {
        public MySqlConnection Connection { get; }

        public DataContext(string connection)
        {
            Connection = new MySqlConnection(connection);
            Connection.Open();
        }

        public void Dispose() => Connection.Dispose();
    }
}
