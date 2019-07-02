using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PrimeiraWebApiCore.Infrastructure.Data.Contexto.Interface
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection(string connectionString);
    }
}
