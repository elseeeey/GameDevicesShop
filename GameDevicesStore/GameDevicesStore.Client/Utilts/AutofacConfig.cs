using Autofac;
using Autofac.Integration.Mvc;
using GameDevicesStore.Client.Controllers;
using GameDevicesStore.DataAcces;
using GameDevicesStore.DataAcces.Entities;
using GameDevicesStore.DataAcces.Repository.Abstraction;
using GameDevicesStore.DataAcces.Repository.Implementation;
using GameDevicesStore.Domain.Services.Abstraction;
using GameDevicesStore.Domain.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameDevicesStore.Client.Utilts
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            //Створюємо білдер  нашого контейнера
            var builder = new ContainerBuilder();

            //Ми реєстуреємо всі білдери в проекті
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<EFContext>().As<DbContext>();
            builder.RegisterGeneric(typeof(EfRepository<>)).As(typeof(IGenericRepository<>));
            builder.RegisterType<DeviceService>().As<IDeviceService>();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));

            //var controller = new DevicesController(new DeviceService(new EfRepository<Device>(new EFContext)));
        }
    }
}