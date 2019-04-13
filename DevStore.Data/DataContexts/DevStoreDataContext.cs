using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevStore.Domain;

namespace DevStore.Data.DataContexts
{
    public class DevStoreDataContext : DbContext
    {
        public DevStoreDataContext() : base("DevStoreConnectionString")
        {
            Database.SetInitializer<DevStoreDataContext>(new DevStoreDataContextInitializer());
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }

    public class DevStoreDataContextInitializer : DropCreateDatabaseIfModelChanges<DevStoreDataContext>
    {
        protected override void Seed(DevStoreDataContext context)
        {
            base.Seed(context);
        }
    }
}
