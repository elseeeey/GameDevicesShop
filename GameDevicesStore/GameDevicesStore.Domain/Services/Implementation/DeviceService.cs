using GameDevicesStore.DataAcces.Entities;
using GameDevicesStore.DataAcces.Repository.Abstraction;
using GameDevicesStore.Domain.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevicesStore.Domain.Services.Implementation
{
    public class DeviceService : IDeviceService
    {

        private readonly IGenericRepository<Device> _repos;
        public DeviceService(IGenericRepository<Device> repos)
        {

            _repos = repos;
        }

        public ICollection<Device> GetDevices()
        {
            var games = _repos.GetAll();
            return games.ToList();
        }
    }
}
