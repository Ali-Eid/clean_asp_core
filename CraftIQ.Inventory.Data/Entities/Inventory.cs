using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftIQ.Inventory.Data.Entities
{
    public  class Inventory : BaseEntity
    {
        public Inventory()
        {
            
        }


        public Guid InventoryId { get; set; }
        public Guid ProductId { get; set; } // refrence to prdouct
        public List<Product> Products { get; set; } = new(); // refrence to product list

        public int Quantity { get; set; }

        public int Reorderlevel { get; set; }

        public string Location { get; set; } = string.Empty;

        public DateTimeOffset LastUpdated { get; set; }
    }
}
