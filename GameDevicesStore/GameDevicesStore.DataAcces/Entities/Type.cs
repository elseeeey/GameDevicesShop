using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevicesStore.DataAcces.Entities
{
    public class Type
    {
        public int Id { get; set; }

        public string Name { get; set; }

        /* Navigation Properties*/

        public ICollection<Device> Devices { get; set; }
    }
}
