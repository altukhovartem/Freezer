using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Freezer.Data
{
    class Context: DbContext
    {
        public Context()
            :base("FreezerDB")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
        }

        public DbSet<Product> ProductSet { get; set; }
    }
}
