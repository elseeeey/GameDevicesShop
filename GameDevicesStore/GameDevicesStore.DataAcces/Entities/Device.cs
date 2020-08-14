using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevicesStore.DataAcces.Entities
{
    public class Device
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public DateTime ReleaseDate { get; set; }

        /* Navigation Properties*/

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int ProducerId { get; set; }

        public Producer Producer { get; set; }

    }
}
