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
                new Category { Name = "Mouses"},
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

            var devices = new List<Device>()
            {
                new Device
                {
                    Name = "Razer Naga",
                    Price = 110,
                    ReleaseDate = new DateTime(2009,01,01),
                    Producer = producers.FirstOrDefault(x=>x.Name == "Razer"),
                    Category = categories.FirstOrDefault(x=>x.Name == "Mouses")

                },
                new Device
                {
                    Name = "HyperX Alloy FPS RGB",
                    Price = 130,
                    ReleaseDate = new DateTime(2018,01,01),
                    Producer = producers.FirstOrDefault(x=>x.Name == "Hyper X"),
                    Category = categories.FirstOrDefault(x=>x.Name == "Keyboards")

                },
                new Device
                {
                    Name = "Arctis 1 Wireless Cyberpunk Edition",
                    Price = 150,
                    ReleaseDate = new DateTime(2020,03,05),
                    Producer = producers.FirstOrDefault(x=>x.Name == "Steel Series"),
                    Category = categories.FirstOrDefault(x=>x.Name == "Headsets")

                },
                new Device
                {
                    Name = "G840 XL Gaming Mousepad",
                    Price = 53,
                    ReleaseDate = new DateTime(2019,04,15),
                    Producer = producers.FirstOrDefault(x=>x.Name == "Logitech"),
                    Category = categories.FirstOrDefault(x=>x.Name == "MousePads")

                },
            };

            context.Devices.AddRange(devices);
            context.SaveChanges();
        } 

    }
}
