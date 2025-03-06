using FPStore.Core.Abstracts;
using FPStore.Core.Models.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPStore.Core.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string ImageUrl { get; set; }

        [Required]  // Kategori seçimi zorunlu
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<StoreProduct> StoreProducts { get; set; }
        public ICollection<Review> Reviews { get; set; }

        public Product()
        {
            StoreProducts = new HashSet<StoreProduct>();
            Reviews = new HashSet<Review>();
        }

    }
}
