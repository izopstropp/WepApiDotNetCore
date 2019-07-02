using PrimeiraWebApiCore.Infrastructure.Data.Contexto.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PrimeiraWebApiCore.Infrastructure.Data.Contexto
{
    public class DbConnectionFactory : IDbConnectionFactory
    {
        public IDbConnection CreateConnection(string connectionString)
        {
            throw new NotImplementedException();
        }
    }
}
