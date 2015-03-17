using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace Custom
{
    public abstract class SqlBase : IDisposable
    {
        private readonly bool _maintainConnection;
        protected readonly SqlConnection Connection;

        protected SqlBase(bool maintainConnection = false)
        {
            _maintainConnection = maintainConnection;
            Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
        }

        protected void OpenConnection()
        {
            try
            {
                if (Connection.State == ConnectionState.Open) return;

                Connection.Open();
            }
            finally
            {
                while (Connection.State == ConnectionState.Connecting)
                {
                    Thread.Sleep(200);
                }
            }
        }

        protected void CloseConnection()
        {
            if (!_maintainConnection) ForceCloseConnection();
        }

        private void ForceCloseConnection()
        {
            if (Connection.State != ConnectionState.Closed) Connection.Close();
        }

        public void Dispose()
        {
            ForceCloseConnection();
        }
    }
}
