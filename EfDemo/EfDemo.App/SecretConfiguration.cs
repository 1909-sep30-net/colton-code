using System;
using System.Collections.Generic;
using System.Text;

namespace EfDemo.App
{
    public static class SecretConfiguration
    {
        public const string ConnectionString = "Server=tcp:1909escalonasql.database.windows.net,1433;Initial Catalog=PokemonDb;Persist Security Info=False;User ID=nick;Password=Password123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    }
}
