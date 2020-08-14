using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDevicesStore.DataAcces.Entities;

namespace GameDevicesStore.DataAcces
{
    using GameDevicesStore.DataAcces.Entities;
    using GameDevicesStore.DataAcces.Initializers;
    using System.Data.Entity;

    public class ApplicationContext : DbContext
    {
        public DbSet<Device> Devices { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Producer> Producers { get; set; }

        public ApplicationContext()
            : base("name=ApplicationContext")
        {
            Database.SetInitializer(new DevicesInit());
        }
    }
}