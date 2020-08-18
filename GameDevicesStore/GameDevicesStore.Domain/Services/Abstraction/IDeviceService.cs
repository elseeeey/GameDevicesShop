using GameDevicesStore.DataAcces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevicesStore.Domain.Services.Abstraction
{
    public interface IDeviceService
    {
        ICollection<Device> GetDevices();
    }
}
