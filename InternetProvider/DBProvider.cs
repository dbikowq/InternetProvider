using InternetProvider.Classes;
using System.Data.Entity;

namespace InternetProvider
{
    public class DBProvider:DbContext
    {
        private static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=InternetProviderBase;";
        public DBProvider():base(connectionString)
        {
            Database.CreateIfNotExists();
        }

        public DbSet<Provider>Providers { get; set; }
        public DbSet<Client> Clients { get; set; }    
        public DbSet<Connection> Connections { get; set; }    
    }
}
