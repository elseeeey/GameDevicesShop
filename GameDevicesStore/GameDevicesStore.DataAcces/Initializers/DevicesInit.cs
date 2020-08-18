using GameDevicesStore.DataAcces.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevicesStore.DataAcces.Initializers
{
    public class DevicesInit : DropCreateDatabaseAlways<EFContext>
    {
        protected override void Seed(EFContext context)
        {
            var categories = new List<Category>
            {
                new Category { Name = "Mouse"},
                new Category { Name = "Headsets"},
                new Category { Name = "Keyboards"},
                new Category { Name = "MousePads"},
                new Category { Name = "Microphones"}
            };

            context.Categories.AddRange(categories);
            context.SaveChanges();

            var producers = new List<Producer>
            {
                new Producer { Name = "Hyper X"},
                new Producer { Name = "Razer"},
                new Producer { Name = "Steel Series"},
                new Producer { Name = "Logitech"},
                new Producer { Name = "Asus"},
                new Producer { Name = "Benq"},
                new Producer { Name = "A4tech"},
            };
        }

    }
}
