using FPStore.Core.Abstracts;
using FPStore.Core.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPStore.Core.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        // SuperAdmin tarafından yönetim
        public string CreatedById { get; set; }  // SuperAdmin ID'si
        public ApplicationUser CreatedBy { get; set; }  // SuperAdmin referansı

        public bool IsActive { get; set; }  // Kategorinin aktif/pasif durumu

        // Ürün ilişkisi
        public ICollection<Product> Products { get; set; }

        public Category()
        {
            Products = new HashSet<Product>();
            IsActive = true;  // Varsayılan olarak aktif
        }
    }
}
