using FPStore.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPStore.Core.Models.Store
{
    public class StoreAddress : BaseEntity
    {
        public int StoreId { get; set; }
        public Store Store { get; set; }

        // Adres bilgileri
        [Required]
        public string City { get; set; }
        [Required]
        public string District { get; set; }
        [Required]
        public string FullAddress { get; set; }
        public string PostalCode { get; set; }

        // İletişim
        [Required]
        public string PhoneNumber { get; set; }        
        [Required]
        public string Email { get; set; }

        // Konum bilgileri (opsiyonel)
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        // Fatura adresi mi?
        public bool IsBillingAddress { get; set; }
    }
}
