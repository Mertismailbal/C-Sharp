using FPStore.Core.Abstracts;
using FPStore.Core.Models.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPStore.Core.Models
{
    public class OrderItem : BaseEntity
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int StoreProductId { get; set; }
        public StoreProduct StoreProduct { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }  // Sipariş anındaki fiyat
        public decimal TotalPrice { get; set; } // Miktar * Birim Fiyat

        public OrderItem()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
